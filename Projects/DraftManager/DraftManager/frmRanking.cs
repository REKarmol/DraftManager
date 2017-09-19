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
	public partial class frmRanking : Form
	{
		private List<Nfl> nfl;
		private List<Position> position;
		private List<Player> player;
		private List<Ranking> ranking;
		private List<Ffl> ffl;
		private List<Average> avg;
		private List<Score> score;

		//***********************************************************
		public frmRanking ()
		//***********************************************************
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel (List<Ranking> r, List<Ffl> f, List<Position> p, List<Player> pl, List<Nfl> n, List<Average> a, List<Score> s)
		//***********************************************************
		{
			int i;

			ranking = new List<Ranking>(r);
			nfl = n;
			position = p;
			player = pl;
			ffl = f;
			avg = a;
			score = s;

			if (avg.Count == 0)
				buttonRank.Enabled = false;
			else
				buttonRank.Enabled = true;

			// fill position combobox
			comboBoxPosition.Items.Clear();
			for (i=0; i<position.Count; i++)
			{
				if (i==0)
					comboBoxPosition.Items.Add("All");
				else
					comboBoxPosition.Items.Add(position[i].Name);
			}
			comboBoxPosition.SelectedIndex = 0;

			// fill ffl combobox
			comboBoxFFL.Items.Clear();
			for (i = 1; i < ffl.Count; i++)
			{
				comboBoxFFL.Items.Add(ffl[i].Name);
			}
			comboBoxFFL.SelectedIndex = 0;

			this.listViewExRankings.fxdColumn = "/Pos/Last/First/NFL/";
			FillListView();
		}

		//***********************************************************
		public List<Ranking> GetRanking ()
		//***********************************************************
		{
			return ranking;
		}

		//***********************************************************
		private void FillListView ()
		//***********************************************************
		{
			int i;

			// fill Rankings list
			this.listViewExRankings.BeginUpdate();
			this.listViewExRankings.Items.Clear();
			for (i=0; i<ranking.Count; i++)
			{
				if (ranking[i].Ffl - 1 != comboBoxFFL.SelectedIndex)
					continue;
				if (comboBoxPosition.SelectedIndex != 0 && ranking[i].Position != comboBoxPosition.SelectedIndex)
					continue;

				int plr = ranking[i].Player;
				ListViewItem lvi;
				lvi = new ListViewItem(position[ranking[i].Position].Name);
				lvi.SubItems.Add(player[plr].Last);
				lvi.SubItems.Add(player[plr].First);
				lvi.SubItems.Add(nfl[player[plr].Nfl].Name);
				lvi.SubItems.Add(ranking[i].Risk);
				lvi.SubItems.Add(ranking[i].Line.ToString());
				lvi.SubItems.Add(player[plr].Adp.ToString("0.0"));
				lvi.SubItems.Add(ranking[i].Rank.ToString());
				lvi.SubItems.Add(ranking[i].Tier.ToString());
				lvi.SubItems.Add(ranking[i].Points.ToString("0.0"));
				lvi.SubItems.Add(ranking[i].Ppg.ToString("0.0"));
				this.listViewExRankings.Items.Add(lvi);
			}
			this.listViewExRankings.EndUpdate();
		}

		//***********************************************************************
		private int PositionIdx (string p)
		//***********************************************************************
		{
			string[] delim = new string[] { " ", ",", ";", ":", "/", "\\", "|" };

			for (int i=1; i<position.Count; i++)
			{
				string[] key = position[i].Conversion.Split(delim, StringSplitOptions.RemoveEmptyEntries);
				foreach (string k in key)
				{
					if (k.Equals(p, StringComparison.OrdinalIgnoreCase))
						return i;
				}
			}
			return 0;
		}

		//***********************************************************************
		private int NflIdx (string name)
		//***********************************************************************
		{
			string[] delim = new string[] { " ", ",", ";", ":", "/", "\\", "|" };

			for (int i=1; i<nfl.Count; i++)
			{
				string[] key = nfl[i].Conversion.Split(delim, StringSplitOptions.RemoveEmptyEntries);
				foreach (string k in key)
				{
					if (k.Equals(name, StringComparison.OrdinalIgnoreCase))
						return i;
				}
			}
			return 0;
		}

		//***********************************************************
		private void button1_Click (object sender, EventArgs e)
		//***********************************************************
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Team Rankings (*.prj)|*.prj";
			ofd.InitialDirectory = Model.importDirectory;
			ofd.Title = "Select a File";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				ReadRanking(ofd.FileName);
			}
		}

		//***********************************************************************
		public void ReadRanking (string filepath)
		//***********************************************************************
		{
			int    errs=0;
			StringBuilder elist = new StringBuilder("");

			int   poskey=0;
			int   tierkey=1;
			int   rankkey=0;
			float games = 1.0F;
			string delim = " ,;:/\\|";
			string pars = "[ ]";

			string[] item;
			string[] column = new string[32] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
			float[]  colval = new float[32];

			// can't rank if no players in main list
			if (player.Count<3)
				return;

			// read rankings; we are (1) overlaying / (2) inserting entries
			string[] line = File.ReadAllLines(filepath);
			for (int i=0; i<line.Length; i++)
			{
				// parse empty line/comment
				if (line[i].Trim().Length == 0 || line[i].StartsWith("//"))
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
						poskey = PositionIdx(s1[0]);
						s = s1[1];
					}
					if (poskey==0)
						continue;

					// extract columns
					string[] s2 = s.Split(',');
					for (int x=0; x<s2.Length; x++)
					{
						float f = 0.0f;
						foreach (Score sc in score)
						{
							if (sc.Position == 0 && s2[x].Equals(sc.Category))
							{
								f = sc.Value;
							}
						}
						foreach (Score sc in score)
						{
							if (sc.Position == poskey && s2[x].Equals(sc.Category))
							{
								f = sc.Value;
							}
						}
						column[x] = s2[x];
						colval[x] = f;
					}

					rankkey = 1;
					continue;
				}

				// parse regular line
				item = line[i].Split(',');

				string lastkey="";
				string firstkey="";
				int    nflkey = -1;
				string riskkey = "NULL";
				float  ppgkey = 0.0F;
				float  pointskey = 0.0F;
				float  sumkey = 0.0F;
				int    linekey = i+1;
				string namekey="";

				for (int h=0; h<column.Length && h<item.Length; h++)
				{
					switch (column[h])
					{
						case "LAST":
							lastkey = A2Z(item[h]);
							break;
						case "FIRST":
							firstkey = A2Z(item[h]);
							break;
						case "NAME":
							namekey = A2Z(item[h]);
							break;
						case "NFL":
							nflkey = NflIdx(item[h].Trim());
							break;
						case "RISK":
							riskkey = item[h];
							break;
						case "POS":
							poskey = PositionIdx(item[h].Trim());
							break;
						case "TIER":
							int.TryParse(item[h], out tierkey);
							break;
						case "RANK":
							int.TryParse(item[h], out rankkey);
							break;
						case "PPG":
							float.TryParse(item[h], out ppgkey);
							break;
						case "POINTS":
							float.TryParse(item[h], out pointskey);
							break;
						case "FIRST NFL POS":
							string[] d = item[h].Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							int dl = d.Length-1;
							if (dl>1) poskey = PositionIdx(d[dl]);
							if (dl>0) nflkey = NflIdx(d[dl-1]);
							string temp = "";
							for (int jj=0; jj<=dl-2; jj++)
							{
								if (temp.Length>0)
									temp = temp + " " + d[jj];
								else temp = d[jj];
							}
							firstkey = temp;
							break;
						default:
							float f;
							float.TryParse(item[h], out f);
							sumkey = sumkey + (f*colval[h]);
							break;
					}
				}
				if (namekey.Length < 1)
					namekey = firstkey + " " + lastkey;
				if (nflkey<0)
				{
					if (lastkey.Length>0)
					{
						nflkey = NflIdx(lastkey);
						firstkey = nfl[nflkey].City;
						lastkey = nfl[nflkey].Team;
						namekey = firstkey + " " + lastkey;
					}
					else
					{
						string[] delim2 = new string[] { " " };
						string[] key = namekey.Split(delim2, StringSplitOptions.RemoveEmptyEntries);
						if (key.Length>0)
							nflkey = NflIdx(key[key.Length-1]);
					}
				}

				// get ready in case of error
				string elistadd = "Line(" + i.ToString() + "):" + line[i] + "\n";
				errs++;

				// find player
				int playeridx=0;
				for (int plidx=2; plidx<player.Count; plidx++)
				{
					if (player[plidx].Position!=poskey) continue;
					if (player[plidx].Nfl != nflkey) continue;
					string nm = player[plidx].First + " " + player[plidx].Last;
					if (nm.Equals(namekey, StringComparison.OrdinalIgnoreCase))
					{
						playeridx = plidx;
						elistadd="";
						errs--;
						break;
					}
				}

				elist.Append(elistadd);

				if (pointskey == 0.0F && sumkey > 0.0F)
					pointskey = sumkey;
				if (ppgkey == 0.0F && sumkey > 0.0F)
					ppgkey = sumkey / games;

				bool found = false;
				if (playeridx>1)
				{
					int r;
					for (r=0; r<ranking.Count; r++)
					{
						if (ranking[r].Ffl != comboBoxFFL.SelectedIndex + 1) continue;
						if (ranking[r].Player != playeridx) continue;

						found = true;
						ranking[r].Name = namekey;			// will match Players, so ok
						ranking[r].Position = poskey;		// will also match Players
						//ranking[r].Line = linekey;		// let's not overwrite, use original added in new()
						//ranking[r].Rank = rankkey;
						//ranking[r].Tier = tierkey;
						if (riskkey!="NULL")
							ranking[r].Risk = riskkey;
						if (pointskey > 0.0F)
							ranking[r].Points = pointskey;
						if (ppgkey > 0.0F)
							ranking[r].Ppg = ppgkey;
					}
				}

				if (!found)
				{
					if (riskkey=="NULL")
						riskkey="";
					Ranking rank = new Ranking(namekey, comboBoxFFL.SelectedIndex + 1, linekey, poskey, playeridx, rankkey, 0, tierkey, pointskey, ppgkey, riskkey);
					ranking.Add(rank);
				}
				rankkey++;
			}
			ranking.Sort();
			FillListView();
			if (errs > 0)
				MessageBox.Show(elist.ToString(),
							 "Lines with no match",
							 MessageBoxButtons.OK,
							 MessageBoxIcon.Exclamation);

		}

		private void buttonClear_Click (object sender, EventArgs e)
		{
			// remove selected ffl from rankings
			for (int r = ranking.Count - 1; r >= 0; r--)
			{
				if (comboBoxFFL.SelectedIndex + 1 == ranking[r].Ffl)
					ranking.RemoveAt(r);
			}
			FillListView();
		}

		private void buttonPoints_Click (object sender, EventArgs e)
		{
			int i, p;
			for (i = 0; i < ranking.Count; i++)
			{
				if (ranking[i].Ffl != comboBoxFFL.SelectedIndex + 1)
					continue;

				ranking[i].Ppg = (float) Math.Floor((double) (ranking[i].Points / 17.0F + 0.5F));
				ranking[i].Rank2 = ranking[i].Rank;
				ranking[i].Rank = 0;
				ranking[i].Tier = 0;
				ranking[i].Line = 0;
			}
			ranking.Sort();

			for (p = 1; p < position.Count; p++)
			{
				int r = 1;
				int t = 0;
				float ppg = 0.0F;
				for (i = 0; i < ranking.Count; i++)
				{
					if (ranking[i].Position != p)
						continue;
					if (ranking[i].Ffl != comboBoxFFL.SelectedIndex + 1)
						continue;

					if (ppg != ranking[i].Ppg)
						t++;
					ppg = ranking[i].Ppg;

					ranking[i].Rank = r++;
					ranking[i].Tier = t;
					ranking[i].Rank2 = 0;
				}
			}
			FillListView();
		}

		private void buttonRank_Click (object sender, EventArgs e)
		{
			int i, p, a;

			ranking.Sort();
			for (i = 0; i < ranking.Count; i++)
			{
				if (ranking[i].Ffl != comboBoxFFL.SelectedIndex + 1)
					continue;

				for (a = 0; a < avg.Count; a++)
				{
					if (avg[a].Position != ranking[i].Position)
						continue;
					if (avg[a].Rank != ranking[i].Rank)
						continue;

					ranking[i].Ppg = avg[a].Value;
				}
				ranking[i].Rank2 = 0;
			}

			for (p = 1; p < position.Count; p++)
			{
				bool tiers = true;
				while (tiers)
				{
					int t = 1;
					float sum = 0.0F;
					float cnt = 0.0F;
					tiers = false;
					for (i = 0; i < ranking.Count; i++)
					{
						if (ranking[i].Position != p)
							continue;
						if (ranking[i].Ffl != comboBoxFFL.SelectedIndex + 1)
							continue;
						if (ranking[i].Tier != t)
							continue;

						sum = sum + ranking[i].Ppg;
						cnt = cnt + 1.0F;
						tiers = true;
					}
					if (cnt > 0.0F)
						sum = sum / cnt;
					sum = (float) Math.Floor((double) (sum + 0.5F));
					for (i = 0; i < ranking.Count; i++)
					{
						if (ranking[i].Position != p)
							continue;
						if (ranking[i].Ffl != comboBoxFFL.SelectedIndex + 1)
							continue;
						if (ranking[i].Tier != t)
							continue;

						ranking[i].Ppg = sum;
					}
					t++;
				}
			}
			FillListView();
		}

		private void comboBoxFFL_SelectedIndexChanged (object sender, EventArgs e)
		{
			FillListView();
		}

		private void comboBoxPosition_SelectedIndexChanged (object sender, EventArgs e)
		{
			FillListView();
		}

		private string A2Z (string s)
		{
			StringBuilder b = new StringBuilder("");
			for (int i=0; i<s.Length; i++)
			{
				char c = s[i];
				if (c==' ' || (c>='A' && c<='Z') || (c>='a' && c<='z') || (c>='0' && c<='9'))
					b.Append(c);
			}
			return b.ToString();
		}
	}
}
