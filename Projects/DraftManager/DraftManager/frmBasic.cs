using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DraftManager
{
	public partial class frmBasic : Form
	{
		//***********************************************************
		public frmBasic ()
		//***********************************************************
		{
			InitializeComponent();
		}

		//********************************************
		public void SetModel (List<Nfl> n, List<Position> p, string[] c, int s, int t, int r, int tm, float a, float m)
		//********************************************
		{
			int i;
			for (i=1; i<n.Count; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem(n[i].Name);
				lvi.SubItems.Add(n[i].City);
				lvi.SubItems.Add(n[i].Team);
				lvi.SubItems.Add(n[i].Bye);
				lvi.SubItems.Add(n[i].Conversion);
				this.xlvNFL.Items.Add(lvi);
			}

			for (; i <= Model.maxNfls; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				this.xlvNFL.Items.Add(lvi);
			}

			// editable pos array
			for (i=1; i<p.Count; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem(p[i].Name);
				lvi.SubItems.Add(p[i].Group);
				lvi.SubItems.Add(p[i].Num.ToString());
				lvi.SubItems.Add(p[i].Min.ToString());
				lvi.SubItems.Add(p[i].Max.ToString());
				lvi.SubItems.Add(p[i].Conversion);
				this.xlvPOS.Items.Add(lvi);
			}

			for (; i <= Model.maxPositions; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				this.xlvPOS.Items.Add(lvi);
			}

			// combo choices for style
			this.comboBoxStyle.Items.Clear();
			foreach (string ls in c)
			{
				this.comboBoxStyle.Items.Add(ls);
			}

			// other
			textBoxTeams.Text = t.ToString();
			textBoxRounds.Text = r.ToString();
			textBoxTimer.Text = tm.ToString();
			textBoxCap.Text = a.ToString("0.00");
			textBoxMin.Text = m.ToString("0.00");
			comboBoxStyle.SelectedIndex = s;
		}

		//********************************************
		public int GetTeams ()
		//********************************************
		{
			int i;
			int.TryParse(textBoxTeams.Text, out i);
			return i;
		}

		//********************************************
		public int GetRounds ()
		//********************************************
		{
			int i;
			int.TryParse(textBoxRounds.Text, out i);
			return i;
		}

		//********************************************
		public int GetTimer ()
		//********************************************
		{
			int i;
			int.TryParse(textBoxTimer.Text, out i);
			return i;
		}

		//********************************************
		public float GetSalCap ()
		//********************************************
		{
			float i;
			float.TryParse(textBoxCap.Text, out i);
			return i;
		}

		//********************************************
		public float GetMinBid ()
		//********************************************
		{
			float i;
			float.TryParse(textBoxMin.Text, out i);
			return i;
		}

		//***********************************************************
		public int GetStyle ()
		//***********************************************************
		{
			return comboBoxStyle.SelectedIndex;
		}

		//********************************************
		public void GetNFLs (List<Nfl> nfl)
		//********************************************
		{
			nfl.Clear();
			nfl.Add(new Nfl("", "", "", "", ""));
			foreach (ListViewItem lvi in this.xlvNFL.Items)
			{
				string name, city, team, byew, syms;
				name = lvi.SubItems[0].Text.Trim();
				city = lvi.SubItems[1].Text.Trim();
				team = lvi.SubItems[2].Text.Trim();
				byew = lvi.SubItems[3].Text.Trim();
				syms = lvi.SubItems[4].Text.Trim();
				if (name.Length>0)
					nfl.Add(new Nfl(name, city, team, byew, syms));
			}
			return;
		}

		//********************************************
		public void GetPositions (List<Position> pos)
		//********************************************
		{
			pos.Clear();
			pos.Add(new Position("", "", 0, 0, 0, ""));
			foreach (ListViewItem lvi in this.xlvPOS.Items)
			{
				string name;
				string group;
				string groupnum;
				string posmin;
				string posmax;
				string syms;
				int gn,pn,px;
				name = lvi.SubItems[0].Text.Trim();
				group = lvi.SubItems[1].Text.Trim();
				if (group=="") group = name;
				groupnum = lvi.SubItems[2].Text.Trim();
				posmin = lvi.SubItems[3].Text.Trim();
				posmax = lvi.SubItems[4].Text.Trim();
				syms = lvi.SubItems[5].Text.Trim();
				int.TryParse(groupnum, out gn);
				int.TryParse(posmin, out pn);
				int.TryParse(posmax, out px);
				if (name.Length>0)
					pos.Add(new Position(name, group, gn, pn, px, syms));
			}
			return;
		}

		private void xlvPOS_MouseLeave (object sender, EventArgs e)
		{

		}
	}
}
