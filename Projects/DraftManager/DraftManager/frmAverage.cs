using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DraftManager
{
	public partial class frmAverage : Form
	{
		private List<Average> avt;
		private List<Position> pos;
		private List<Score> score;

		//***********************************************************
		public frmAverage ()
		//***********************************************************
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel (List<Average> av, List<Position> p, List<Score> s)
		//***********************************************************
		{
			int i;

			avt = new List<Average>(av);
			pos = p;
			score = s;

			// put Position names into Header
			for (i=1; i<pos.Count && i<=8; i++)
				xlvScores.Columns[i].Text = pos[i].Name;
			xlvScores.fxdColumn = "/Slot//";

			FillListView();
		}

		//***********************************************************
		public List<Average> GetAverages ()
		//***********************************************************
		{
			avt.Clear();
			foreach (ListViewItem lvi in this.xlvScores.Items)
			{
				int sl;
				float avg;
				string slot, val="";
				slot = lvi.SubItems[0].Text.Trim();
				int.TryParse(slot, out sl);
				for (int p = 1; p < pos.Count; p++)
				{
					val = lvi.SubItems[p].Text.Trim();
					float.TryParse(val, out avg);
					if (avg>0.0F)
						avt.Add(new Average(sl, p, avg));
				}
			}
			avt.Sort();
			return avt;
		}

		//***********************************************************
		private void FillListView ()
		//***********************************************************
		{
			// sort avt
			avt.Sort();

			// load avt[] into listview
			this.xlvScores.Items.Clear();
			for (int slot = 1; slot <= Model.maxRanks; slot++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem((slot).ToString());

				for (int position=1; position<pos.Count; position++)
				{
					for (int i=0; i<avt.Count; i++)
					{
						if (avt[i].Rank!=slot) continue;
						if (avt[i].Position!=position) continue;

						lvi.SubItems.Add(avt[i].Value.ToString("0.00"));
					}
				}
				xlvScores.Items.Add(lvi);
			}
		}

		//***********************************************************
		private void button1_Click_1 (object sender, EventArgs e)
		//***********************************************************
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Historical Scoring (*.avt)|*.avt";
			ofd.InitialDirectory = Model.importDirectory;
			ofd.Title = "Select a File";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				ReadAVTList(ofd.FileName);
				FillListView();
			}
		}

		//***********************************************************************
		public void ReadAVTList (string filepath)
		//***********************************************************************
		{
			int slot=0;
			int slots = 0;
			int position=0;
			string[] item;
			string[] column = new string[32] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
			float[]  colval = new float[32];
			float[]  colden = new float[32];
			float[,] val = new float[Model.maxPositions, Model.maxRanks+1];
			string pars = "[ ]";

			float games = 1.0F;

			// clear avt
			avt.Clear();

			string[] line = File.ReadAllLines(filepath);
			for (int i=0; i<line.Length; i++)
			{
				// parse empty line
				if (line[i].Trim().Length == 0)
				{
					continue;
				}

				// [directive]
				if (line[i].StartsWith("["))
				{
					string s = line[i].Trim(pars.ToCharArray()).Replace("  ", " ").Replace(" ,", ",").Replace(", ", ",");

					// GAMES=#
					if (s.StartsWith("GAMES"))
					{
						string t = s.Substring(s.IndexOf('=') + 1);
						float.TryParse(t, out games);
						continue;
					}

					// POS=COL,COL,COL...]
					string[] s1 = s.Split('=');
					if (s1.Length > 1)
					{
						position = PositionIdx(s1[0]);
						if (position==0) continue;
						colden[position] = colden[position]+1.0F;
						s = s1[1];
					}

					// extract columns
					string[] s2 = s.Split(',');
					for (int x=0; x<s2.Length; x++)
					{
						float f=0.0f;
						foreach (Score sc in score)
						{
							if (sc.Position==0 && s2[x].Equals(sc.Category))
							{
								f = sc.Value;
							}
						}
						foreach (Score sc in score)
						{
							if (sc.Position == position && s2[x].Equals(sc.Category))
							{
								f = sc.Value;
							}
						}
						column[x] = s2[x];
						colval[x] = f;
					}

					slot = 0;
					continue;
				}

				// parse regular line
				item = line[i].Split(',');

				// save this one
				StringBuilder elist = new StringBuilder("");
				if (false && slot==0)
				{
					elist.Append(line[i]);
					elist.Append("\n");
				}
				if (slot<=Model.maxRanks)
				{
					for (int h=0; h<column.Length && h<item.Length; h++)
					{
						float f;
						float.TryParse(item[h], out f);
						val[position, slot] = val[position, slot] + (f*colval[h])/games;
						//if (false && slot==0 && colval[h]!=0.0F)
						//{
						//   elist.Append("   ");
						//   elist.Append(column[h]);
						//   elist.Append(": ");
						//   elist.Append(f.ToString());
						//   elist.Append("*");
						//   elist.Append(colval[h].ToString());
						//   elist.Append("/");
						//   elist.Append(games.ToString());
						//}
						elist.Append("\n");
					}
					//if (false && slot == 0)
					//{
					//   MessageBox.Show(elist.ToString(),
					//          "Value breakdown",
					//          MessageBoxButtons.OK,
					//          MessageBoxIcon.Exclamation);
					//}
					slot++;
					if (slot > slots)
						slots = slot;
				}
			}

			for (int p = 1; p < pos.Count; p++)
			{
				int i, j;
				float x;
				for (i = 0; i < slots; i++)
				{
					for (j = i + 1; j < slots; j++)
					{
						if (val[p, i] < val[p, j])
						{
							x = val[p, i];
							val[p, i] = val[p, j];
							val[p, j] = x;
						}
					}
				}
			}

			for (int p=1; p<pos.Count; p++)
			{
				for (int i0 = 0; i0 < Model.maxRanks; i0++)
				{
					if (colden[p]>0.0F)
					{
						val[p, i0] = val[p, i0]/colden[p];
						avt.Add(new Average(i0+1, p, val[p, i0]));
					}
				}
			}
		}

		//***********************************************************************
		private int PositionIdx (string p)
		//***********************************************************************
		{
			string[] delim = new string[] { " ", ",", ";", ":", "/", "\\", "|" };

			for (int i = 1; i < pos.Count; i++)
			{
				string[] key = pos[i].Conversion.Split(delim, StringSplitOptions.RemoveEmptyEntries);
				foreach (string k in key)
				{
					if (k.ToLower() == p.ToLower())
						return i;
				}
			}
			return 0;
		}
	}
}
