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
	public partial class frmScoring : Form
	{
		private List<Score> score;
		private List<Position> pos;

		//***********************************************************
		public frmScoring()
		//***********************************************************
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel(List<Score> s, List<Position> p)
		//***********************************************************
		{
			int i;

			score = new List<Score>(s);
			pos = p;

			listViewEx1.cmbBox1.Items.Clear();
			for (i = 0; i < pos.Count; i++)
			{
				if (i == 0)
					listViewEx1.cmbBox1.Items.Add("All");
				else
					listViewEx1.cmbBox1.Items.Add(pos[i].Name);
			}
			listViewEx1.cmbColumn1 = "/Position/";

			FillListView();
		}

		//***********************************************************
		public List<Score> GetScores()
		//***********************************************************
		{
			score.Clear();
			foreach (ListViewItem lvi in this.listViewEx1.Items)
			{
				string category, p, v;
				int posi = 0;
				float value;
				category = lvi.SubItems[0].Text.Trim();
				p = lvi.SubItems[1].Text.Trim();
				v = lvi.SubItems[2].Text.Trim();

				for (int i = 1; i < pos.Count; i++)
				{
					if (p.Equals(pos[i].Name))
						posi = i;
				}
				//listViewEx1.cmbBox1.Text = p;
				//posi = listViewEx1.cmbBox1.SelectedIndex;
				float.TryParse(v, out value);

				if (category.Length > 0)
					score.Add(new Score(posi, category, value));
			}
			return score;
		}

		//***********************************************************
		private void FillListView()
		//***********************************************************
		{
			int i;
			this.listViewEx1.Items.Clear();
			for (i = 0; i < score.Count; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem(score[i].Category);
				if (score[i].Position==0)
					lvi.SubItems.Add("All");
				else
					lvi.SubItems.Add(pos[score[i].Position].Name);
				lvi.SubItems.Add(score[i].Value.ToString("0.00"));
				this.listViewEx1.Items.Add(lvi);
			}
			for (i = 0; i < 20; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				this.listViewEx1.Items.Add(lvi);
			}
		}
	}
}
