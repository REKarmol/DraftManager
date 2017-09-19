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
	public partial class frmTeam : Form
	{
		private List<Ffl> ffl;
		private List<Confidence> confidence;
		private List<Weight> weight;
		private List<Limit> limit;
		private List<Comment> comment;
		private List<Position> position;
		private int teams;
		private int rounds;
		private int current;
		private int loaded;

		//***********************************************************
		public frmTeam ()
		//***********************************************************
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel (List<Ffl> f, List<Confidence> cn, List<Weight> w, List<Limit> lm, List<Comment> cm, List<Position> p, int tms, int rnds)
		//***********************************************************
		{
			ffl = new List<Ffl>(f);
			confidence = new List<Confidence>(cn);
			weight = new List<Weight>(w);
			limit = new List<Limit>(lm);
			comment = new List<Comment>(cm);
			position = p;
			teams = tms;
			rounds = rnds;

			// main list view
			xlvTeams.Items.Clear();
			for (int i=1; i<=teams; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem(i.ToString("##"));
				lvi.SubItems.Add(ffl[i].Name);
				lvi.SubItems.Add(ffl[i].Owner);
				lvi.SubItems.Add(ffl[i].Email);
				this.xlvTeams.Items.Add(lvi);
			}

			for (int i = 1; i < position.Count; i++)
			{
				this.xlvComments.Columns[i].Text = position[i].Name;
			}

			// confidence listview setup
			this.xlvConfidence.fxdColumn = "/Position//";
			this.xlvComments.fxdColumn = "/Round//";
			//xlvTeams.Items[0].Selected = true;
			current = 0;
			loaded = 0;
		}

		//***********************************************************
		public List<Comment> GetComment ()
		//***********************************************************
		{
			comment.Sort();
			return comment;
		}

		//***********************************************************
		public List<Confidence> GetConfidence ()
		//***********************************************************
		{
			confidence.Sort();
			return confidence;
		}

		//***********************************************************
		public List<Limit> GetLimit ()
		//***********************************************************
		{
			limit.Sort();
			return limit;
		}

		//***********************************************************
		public List<Weight> GetWeight ()
		//***********************************************************
		{
			weight.Sort();
			return weight;
		}

		//***********************************************************
		public List<Ffl> GetFfl ()
		//***********************************************************
		{
			ffl.Clear();
			ffl.Add(new Ffl("", "", ""));

			foreach (ListViewItem lvi in this.xlvTeams.Items)
			{
				string team, owner, email;
				team = lvi.SubItems[1].Text.Trim();
				owner = lvi.SubItems[2].Text.Trim();
				email = lvi.SubItems[3].Text.Trim();

				ffl.Add(new Ffl(team, owner, email));
			}
			return ffl;
		}

		//***********************************************************
		private void xlvTeams_SelectedIndexChanged (object sender, EventArgs e)
		//***********************************************************
		{
			current = 0;
			UnloadListView();
			for (int i=0; i<xlvTeams.Items.Count; i++)
			{
				if (xlvTeams.Items[i].Selected==true)
				{
					current = i + 1;
					LoadListView();
					break;
				}
			}
		}

		//***********************************************************
		private void LoadListView () // puts Lists into listviews
		//***********************************************************
		{
			int p, i, d, r;

			groupBox1.Text = "Position Information for Team #" + current + ":" + ffl[current].Name;
			groupBox2.Text = "Round Information for Team #" + current + ":" + ffl[current].Name;

			// confidence
			this.xlvConfidence.Items.Clear();
			for (p = 1; p < position.Count; p++) // position: line by line 
			{
				ListViewItem lvi;
				lvi = new ListViewItem(position[p].Name);

				float v = 0.0F;
				for (i = 0; i < confidence.Count; i++) // confidence on row
				{
					if (confidence[i].Ffl != current)
						continue;
					if (confidence[i].Position != p)
						continue;
					v = confidence[i].Value;
					break;
				}
				lvi.SubItems.Add(v.ToString("0.00"));
				lvi.SubItems.Add("");
				this.xlvConfidence.Items.Add(lvi);
			}

			// weight
			this.xlvWeight.Items.Clear();
			string groups = ":";
			for (p = 1; p < position.Count; p++) // filter groups from position: line by line 
			{
				if (groups.Contains(":"+position[p].Group+":"))
					continue;
				groups = groups + position[p].Group+":";

				ListViewItem lvi;
				lvi = new ListViewItem(position[p].Group);

				float v = 0.0F;
				for (d = 1; d <= 6; d++) // 6 weights on row
				{
					v = 0.0F;
					for (i = 0; i < weight.Count; i++)
					{
						if (weight[i].Ffl != current)
							continue;
						if (weight[i].Group != position[p].Group)
							continue;
						if (weight[i].Depth != d)
							continue;
						v = weight[i].Value;
						break;
					}
					lvi.SubItems.Add(v.ToString("0.00"));
				}

				this.xlvWeight.Items.Add(lvi);
			}

			// comments
			this.xlvComments.Items.Clear();
			for (r = 1; r <= rounds; r++) // round: line by line
			{
				ListViewItem lvi;
				lvi = new ListViewItem(r.ToString("#0"));

				for (p = 1; p < position.Count; p++) // limit for each position up to 8
				{
					int x = 0;
					for (i = 0; i < limit.Count; i++)
					{
						if (limit[i].Ffl != current)
							continue;
						if (limit[i].Position != p)
							continue;
						if (limit[i].Round != r)
							continue;
						x = limit[i].Value;
						break;
					}
					lvi.SubItems.Add(x.ToString());
				}

				for (p=position.Count; p <= 9; p++)
				{
					lvi.SubItems.Add(""); // limit blanks out to 9
				}

				string c="";
				for (i = 0; i < comment.Count; i++) // comment on row
				{
					if (comment[i].Ffl != current)
						continue;
					if (comment[i].Round != r)
						continue;
					c = comment[i].Text;
					break;
				}
				lvi.SubItems.Add(c);
				this.xlvComments.Items.Add(lvi);
			}
			loaded = current;
		}


		//***********************************************************
		private void UnloadListView () // put listview into Lists
		//***********************************************************
		{
			int i, p, r;

			if (loaded == 0)
				return;

			// remove old ones
			for (i = confidence.Count - 1; i >= 0; i--)
			{
				if (confidence[i].Ffl == loaded)
					confidence.RemoveAt(i);
			}
			for (i = limit.Count - 1; i >= 0; i--)
			{
				if (limit[i].Ffl == loaded)
					limit.RemoveAt(i);
			}
			for (i = comment.Count - 1; i >= 0; i--)
			{
				if (comment[i].Ffl == loaded)
					comment.RemoveAt(i);
			}
			for (i = weight.Count - 1; i >= 0; i--)
			{
				if (weight[i].Ffl == loaded)
					weight.RemoveAt(i);
			}

			// confidence
			p=1;
			foreach (ListViewItem lvi in this.xlvConfidence.Items)
			{
				string con;
				float conf;
				//pos = lvi.SubItems[0].Text.Trim();
				con = lvi.SubItems[1].Text.Trim();
				float.TryParse(con, out conf);
				confidence.Add(new Confidence(loaded, p, conf));
				p++;
			}

			// weight
			p=1;
			foreach (ListViewItem lvi in this.xlvWeight.Items)
			{
				string gms1, gms2, gms3, gms4, gms5, gms6, grp;
				float g1, g2, g3, g4, g5, g6;
				grp = lvi.SubItems[0].Text.Trim();
				gms1 = lvi.SubItems[1].Text.Trim();
				gms2 = lvi.SubItems[2].Text.Trim();
				gms3 = lvi.SubItems[3].Text.Trim();
				gms4 = lvi.SubItems[4].Text.Trim();
				gms5 = lvi.SubItems[5].Text.Trim();
				gms6 = lvi.SubItems[6].Text.Trim();
				float.TryParse(gms1, out g1);
				float.TryParse(gms2, out g2);
				float.TryParse(gms3, out g3);
				float.TryParse(gms4, out g4);
				float.TryParse(gms5, out g5);
				float.TryParse(gms6, out g6);

				weight.Add(new Weight(loaded, grp, 1, g1));
				weight.Add(new Weight(loaded, grp, 2, g2));
				weight.Add(new Weight(loaded, grp, 3, g3));
				weight.Add(new Weight(loaded, grp, 4, g4));
				weight.Add(new Weight(loaded, grp, 5, g5));
				weight.Add(new Weight(loaded, grp, 6, g6));
				p++;
			}

			// comment
			r=1;
			foreach (ListViewItem lvi in this.xlvComments.Items)
			{
				string com, pos1 = "", pos2 = "", pos3 = "", pos4 = "", pos5 = "", pos6 = "", pos7 = "", pos8 = "";
				int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0;
				//pos = lvi.SubItems[0].Text.Trim();
				if (position.Count > 0) pos1 = lvi.SubItems[1].Text.Trim();
				if (position.Count > 1) pos2 = lvi.SubItems[2].Text.Trim();
				if (position.Count > 2) pos3 = lvi.SubItems[3].Text.Trim();
				if (position.Count > 3) pos4 = lvi.SubItems[4].Text.Trim();
				if (position.Count > 4) pos5 = lvi.SubItems[5].Text.Trim();
				if (position.Count > 5) pos6 = lvi.SubItems[6].Text.Trim();
				if (position.Count > 6) pos7 = lvi.SubItems[7].Text.Trim();
				if (position.Count > 7) pos8 = lvi.SubItems[8].Text.Trim();

				com = lvi.SubItems[10].Text.Trim();
				if (position.Count > 0) int.TryParse(pos1, out p1);
				if (position.Count > 1) int.TryParse(pos2, out p2);
				if (position.Count > 2) int.TryParse(pos3, out p3);
				if (position.Count > 3) int.TryParse(pos4, out p4);
				if (position.Count > 4) int.TryParse(pos5, out p5);
				if (position.Count > 5) int.TryParse(pos6, out p6);
				if (position.Count > 6) int.TryParse(pos7, out p7);
				if (position.Count > 7) int.TryParse(pos8, out p8);

				comment.Add(new Comment(loaded, r, com));
				if (position.Count > 0) limit.Add(new Limit(loaded, 1, r, p1));
				if (position.Count > 1) limit.Add(new Limit(loaded, 2, r, p2));
				if (position.Count > 2) limit.Add(new Limit(loaded, 3, r, p3));
				if (position.Count > 3) limit.Add(new Limit(loaded, 4, r, p4));
				if (position.Count > 4) limit.Add(new Limit(loaded, 5, r, p5));
				if (position.Count > 5) limit.Add(new Limit(loaded, 6, r, p6));
				if (position.Count > 6) limit.Add(new Limit(loaded, 7, r, p7));
				if (position.Count > 7) limit.Add(new Limit(loaded, 8, r, p8));
				r++;
			}
			loaded = 0;
		}

		private void buttonOK_Click (object sender, EventArgs e)
		{
			UnloadListView();
		}

		private void listView1_SelectedIndexChanged (object sender, EventArgs e)
		{

		}
	}
}
