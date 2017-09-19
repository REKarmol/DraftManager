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
	public partial class frmTrade : Form
	{
		private List<Player> player;
		private List<Pick> pick;
		private List<Ffl> ffl;
		private int teams, rounds;

		public frmTrade ()
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel(List<Ffl> f, List<Pick> p, List<Player> pl, int t, int r)
		//***********************************************************
		{
			int i;

			pick = new List<Pick>(p);
			player = pl;
			ffl = f;
			teams = t;
			rounds = r;

			// fill ffl comboboxes
			this.cbTeamA.Items.Clear();
			this.cbTeamB.Items.Clear();
			for (i = 0; i < ffl.Count; i++)
			{
				this.cbTeamA.Items.Add(ffl[i].Name);
				this.cbTeamB.Items.Add(ffl[i].Name);
			}
			this.cbTeamA.SelectedIndex = 0;
			this.cbTeamB.SelectedIndex = 0;
		}

		//***********************************************************
		public List<Pick> GetPicks()
		//***********************************************************
		{
			return pick;
		}

		private void cbTeamA_SelectedIndexChanged (object sender, EventArgs e)
		{
			int sel = cbTeamA.SelectedIndex;
			lvTeamA.Items.Clear();
			if (sel==0)
				return;

			int i,j;
			lvTeamA.BeginUpdate();
			for (i=0; i<pick.Count; ++i)
			{
				if (pick[i].Ffl != sel)
					continue;

				j = i + 1;
				ListViewItem lvi;
				lvi = new ListViewItem(j.ToString("###"));
				lvi.SubItems.Add(string.Format("{0}:{1}", (1 + (i / (teams))).ToString(), (1 + (i % (teams))).ToString()));
				lvi.SubItems.Add(string.Format("{0} {1}", player[pick[i].Player].First, player[pick[i].Player].Last));
				lvTeamA.Items.Add(lvi);
			}
			lvTeamA.EndUpdate();
		}

		private void cbTeamB_SelectedIndexChanged (object sender, EventArgs e)
		{
			int sel = cbTeamB.SelectedIndex;
			lvTeamB.Items.Clear();
			if (sel == 0)
				return;

			int i,j;
			lvTeamB.BeginUpdate();
			for (i = 0; i < pick.Count; ++i)
			{
				if (pick[i].Ffl != sel)
					continue;

				j = i + 1;
				ListViewItem lvi;
				lvi = new ListViewItem(j.ToString("###"));
				lvi.SubItems.Add(string.Format("{0}:{1}", (1 + (i / (teams))).ToString(), (1 + (i % (teams))).ToString()));
				lvi.SubItems.Add(string.Format("{0} {1}", player[pick[i].Player].First, player[pick[i].Player].Last));
				lvTeamB.Items.Add(lvi);
			}
			lvTeamB.EndUpdate();
		}

		private void btnTrade_Click(object sender, EventArgs e)
		{
			int teamA = cbTeamA.SelectedIndex;
			int teamB = cbTeamB.SelectedIndex;
			if (teamA == teamB)
				return;

			foreach (ListViewItem lvi in lvTeamA.Items)
			{
				string pic;
				int p;

				if (lvi.Checked)
				{
					pic = lvi.SubItems[0].Text.Trim();
					int.TryParse(pic, out p);

					pick[p-1].Ffl = teamB;
				}
			}

			foreach (ListViewItem lvi in lvTeamB.Items)
			{
				string pic;
				int p;

				if (lvi.Checked)
				{
					pic = lvi.SubItems[0].Text.Trim();
					int.TryParse(pic, out p);

					pick[p-1].Ffl = teamA;
				}
			}
		}
	}
}
