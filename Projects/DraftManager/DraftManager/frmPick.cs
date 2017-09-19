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
	public partial class frmPick : Form
	{
		private List<Player> player;
		private List<Pick> pick;
		private List<Ffl> ffl;
		private int teams;

		public frmPick()
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel(List<Ffl> f, List<Pick> p, List<Player> pl, int t)
		//***********************************************************
		{
			int i;

			pick = new List<Pick>(p);
			player = pl;
			ffl = f;
			teams = t;

			for (i = 1; i < ffl.Count; i++)
				xlvPicks.cmbBox1.Items.Add(ffl[i].Name);
			this.xlvPicks.cmbColumn1 = "/Ffl Team/";
			this.xlvPicks.fxdColumn = "/Pick/Round/Player/";
			FillListView();
		}

		//***********************************************************
		private void FillListView()
		//***********************************************************
		{
			int i,j;
			this.xlvPicks.Items.Clear();
			for (i =0; i < pick.Count; i++)
			{
				j = i + 1;

				ListViewItem lvi;
				lvi = new ListViewItem(j.ToString("###"));
				lvi.SubItems.Add(string.Format("{0}:{1}", (1 + (i / (teams))).ToString(), (1 + (i % (teams))).ToString()));
				lvi.SubItems.Add(ffl[pick[i].Ffl].Name);
				lvi.SubItems.Add(string.Format("{0} {1}", player[pick[i].Player].First, player[pick[i].Player].Last)); 
				this.xlvPicks.Items.Add(lvi);
			}
		}

		//***********************************************************
		public List<Pick> GetPicks()
		//***********************************************************
		{
			pick.Clear();
			foreach (ListViewItem lvi in this.xlvPicks.Items)
			{
				string ff;
				int ffli = 0;
				ff = lvi.SubItems[2].Text.Trim();
				for (int i = 1; i < ffl.Count; i++)
				{
					if (ff.Equals(ffl[i].Name))
						ffli = i;
				}
				//xlvPicks.cmbBox1.Text = ff;
				//ffli = xlvPicks.cmbBox1.SelectedIndex+1;
				pick.Add(new Pick(ffli,0));
			}
			return pick;
		}
	}
}
