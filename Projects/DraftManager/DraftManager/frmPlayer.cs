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
	public partial class frmPlayer : Form
	{
		private List<Player> player;
		private List<Position> pos;
		private List<Nfl> nfl;
        
		//***********************************************************
		public frmPlayer ()
		//***********************************************************
		{
			InitializeComponent();
		}

		//***********************************************************
		public void SetModel (List<Player> pl, List<Position> po, List<Nfl> n)
		//***********************************************************
		{
			int i;

			player = new List<Player>(pl);
			nfl = new List<Nfl>(n);
			pos = po;

			xlvPlayer.cmbBox1.Items.Clear();
			xlvPlayer.cmbBox2.Items.Clear();

            for (i=0; i<nfl.Count; i++)
				xlvPlayer.cmbBox1.Items.Add(nfl[i].Name);
            for (i=0; i<pos.Count; i++)
				xlvPlayer.cmbBox2.Items.Add(pos[i].Name);

			this.xlvPlayer.cmbColumn1 = "/NFL/";
			this.xlvPlayer.cmbColumn2 = "/Pos/";

			FillListView();
		}

		//***********************************************************
		public List<Player> GetPlayers ()
		//***********************************************************
		{
			//players = new List<Player>(player);
			player.Clear();
			player.Add(new Player("", "", 0, 0, 0, 0.0F));
			player.Add(new Player("", "PASS", 0, 0, 0, 0.0F));
			
			foreach (ListViewItem lvi in this.xlvPlayer.Items)
			{
				string last, first, p, n, a;
				int nfli = 0, posi = 0;
				float adp;
				last = lvi.SubItems[0].Text.Trim();
				first = lvi.SubItems[1].Text.Trim();
				n = lvi.SubItems[2].Text.Trim();
				p = lvi.SubItems[3].Text.Trim();
				a = lvi.SubItems[4].Text.Trim();

				for (int i = 1; i < nfl.Count; i++)
				{
					if (n.Equals(nfl[i].Name))
						nfli = i;
				}
				for (int i = 1; i < pos.Count; i++)
				{
					if (p.Equals(pos[i].Name))
						posi = i;
				}
				float.TryParse(a, out adp);
				//xlvPlayer.cmbBox1.Text = n;
				//xlvPlayer.cmbBox2.Text = p;
				//nfli = xlvPlayer.cmbBox1.SelectedIndex;
				//posi = xlvPlayer.cmbBox2.SelectedIndex;

				if (last.Length>0)
					player.Add(new Player(last, first, posi, nfli, 0, adp));
			}
			player.Sort();
			return player;
		}

		//***********************************************************
		public List<Nfl> GetNfls()
		//***********************************************************
		{
			return nfl;
		}

		//***********************************************************
		private void FillListView ()
		//***********************************************************
		{
			int i;
			this.xlvPlayer.Items.Clear();
			for (i=2; i<player.Count; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem(player[i].Last);
				lvi.SubItems.Add(player[i].First);
				lvi.SubItems.Add(nfl[player[i].Nfl].Name);
				lvi.SubItems.Add(pos[player[i].Position].Name);
				lvi.SubItems.Add(player[i].Adp.ToString("0.0"));
				this.xlvPlayer.Items.Add(lvi);
			}
			for (i = 0; i < 20; i++)
			{
				ListViewItem lvi;
				lvi = new ListViewItem("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				lvi.SubItems.Add("");
				this.xlvPlayer.Items.Add(lvi);
			}
		}

		//***********************************************************************
		private int PositionIdx (string p)
		//***********************************************************************
		{
			string[] delim = new string[] { " ", ",", ";", ":", "/", "\\", "|" };

			for (int i=1; i<pos.Count; i++)
			{
				string[] key = pos[i].Conversion.Split(delim,StringSplitOptions.RemoveEmptyEntries);
				foreach (string k in key)
				{
					if (k.ToLower()==p.ToLower())
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
					if (k.ToLower()==name.ToLower())
						return i;
				}
			}
			return 0;
		}

		//***********************************************************************
		private void bnPlayers_Click (object sender, EventArgs e)
		//***********************************************************************
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Players List (players.lst)|players.lst";
			ofd.InitialDirectory = Model.importDirectory;
			ofd.Title = "Select a List";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				ReadPlayerList(ofd.FileName);
				FillListView();
			}
		}

        //***********************************************************************
		public void ReadPlayerList (string filepath)
		//***********************************************************************
		{
			string[] key = new string[] { "LAST", "FIRST", "NFL", "POS", "BYE" };
			string[] item;
			string[] delim = new string[] { " ", ",", ";", ":", "/", "\\", "|" };
			string pars = "[ ]";

			player.Clear();
			player.Add(new Player("", "", 0, 0, 0, 0.0F));
			player.Add(new Player("", "PASS", 0, 0, 0, 0.0F));

			string[] plist = File.ReadAllLines(filepath);
			for (int n=0; n<plist.Length; n++)
			{
				// empty line
				if (plist[n].Trim().Length==0)
					continue;

				// [directive]
				if (plist[n].StartsWith("["))
                {
					string s = plist[n].Trim(pars.ToCharArray()).Replace("  "," ").Replace(" ,",",").Replace(", ",",");
					key = s.ToUpper().Split(',');
					continue;
				}

				// or parse regular line
				item = plist[n].Split(',');

				Player p = new Player("", "", 0, 0, 0, 0.0F);
				for (int x=0; x<key.Length && x<item.Length; x++)
				{
					switch (key[x])
					{
						case "LAST":
							p.Last = A2Z(item[x].Trim());
							break;
						case "FIRST":
							p.First = A2Z(item[x].Trim());
							break;
						case "NFL":
							p.Nfl = NflIdx(item[x].Trim());
							break;
						case "POS":
							p.Position = PositionIdx(item[x].Trim());
							break;
                        case "FIRST NFL POS":
							string[] d = item[x].Split(delim, StringSplitOptions.RemoveEmptyEntries);
							int dl = d.Length-1;
							if (dl>1) p.Position = PositionIdx(d[dl]);
							if (dl>0) p.Nfl = NflIdx(d[dl-1]);
							string temp = "";
							for (int jj=0; jj<=dl-2; jj++)
							{
								if (temp.Length>0)
									temp = temp + " " + d[jj];
								else temp = d[jj];
							}
							p.First = A2Z(temp);
							break;
					}
				}
				for (int x=0; x<key.Length && x<item.Length; x++)
				{
					switch (key[x])
					{
						case "BYE":
							if (p.Nfl>0)
							{
								nfl[p.Nfl].Bye = item[x].Trim();
							}
							break;
					}
				}
				player.Add(p);
			}
		}

		//***********************************************************************
		public void ReadADPList(string filepath)
		//***********************************************************************
		{
			int    errs=0;
			StringBuilder elist = new StringBuilder("");

			string[] key = new string[] { "LAST", "FIRST", "NFL", "POS", "ADP" };
			string[] item;
			string[] delim = new string[] { " ", ",", ";", ":", "/", "\\", "|" };
			string pars = "[ ]";
			int poskey = 0;

			// can't rank if no players in main list
			if (player.Count < 3)
				return;
			for (int plidx=2; plidx<player.Count; plidx++)
			{
				player[plidx].Adp = 0;
			}

			string[] plist = File.ReadAllLines(filepath);
			for (int n = 0; n < plist.Length; n++)
			{
				// empty line
				if (plist[n].Trim().Length == 0)
					continue;

				// [directive]
				if (plist[n].StartsWith("["))
				{
					string s = plist[n].Trim(pars.ToCharArray()).Replace("  ", " ").Replace(" ,", ",").Replace(", ", ",");
					key = s.ToUpper().Split(',');
					continue;
				}

				// or parse regular line
				item = plist[n].Split(',');

				string lastkey = "";
				string firstkey = "";
				string namekey = "";
				int nflkey = -1;
				float adpkey = 0.0F;
				int linekey = n;

				for (int x = 0; x < key.Length && x < item.Length; x++)
				{
					switch (key[x])
					{
						case "LAST":
							lastkey = A2Z(item[x].Trim());
							break;
						case "FIRST":
							firstkey = A2Z(item[x].Trim());
							break;
						case "NAME":
							namekey = A2Z(item[x].Trim());
							break;
						case "NFL":
							nflkey = NflIdx(item[x].Trim());
							break;
						case "POS":
							poskey = PositionIdx(item[x].Trim());
							break;
						case "ADP":
							float.TryParse(item[x].Trim(), out adpkey);
							break;
						case "FIRST NFL POS":
							string[] d = item[x].Split(delim, StringSplitOptions.RemoveEmptyEntries);
							int dl = d.Length - 1;
							if (dl > 1) poskey = PositionIdx(d[dl]);
							if (dl > 0) nflkey = NflIdx(d[dl - 1]);
							string temp = "";
							for (int jj = 0; jj <= dl - 2; jj++)
							{
								if (temp.Length > 0)
									temp = temp + " " + d[jj];
								else temp = d[jj];
							}
							firstkey = temp;
							break;
					}
				}
				if (nflkey<0)
					nflkey = NflIdx(lastkey);
				if (namekey.Length < 1)
					namekey = firstkey + " " + lastkey;

				// get ready in case of error
				string elistadd = "Line(" + n.ToString() + "):" + plist[n] + "\n";
				errs++;

				// find player
				for (int plidx=2; plidx<player.Count; plidx++)
				{
					if (player[plidx].Position != poskey) continue;
					if (player[plidx].Nfl != nflkey) continue;
					string nm = player[plidx].First + " " + player[plidx].Last;
					if (nm.Equals(namekey, StringComparison.OrdinalIgnoreCase))
                    {
						player[plidx].Adp = adpkey;
                        elistadd="";
                        errs--;
                        break;
                    }
				}
				elist.Append(elistadd);
			}
			if (errs > 0)
				MessageBox.Show(elist.ToString(),
							 "Lines with no match",
							 MessageBoxButtons.OK,
							 MessageBoxIcon.Exclamation);

		}

		private void btnADP_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Players List (players.adp)|players.adp";
			ofd.InitialDirectory = Model.importDirectory;
			ofd.Title = "Select a List";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				ReadADPList(ofd.FileName);
				FillListView();
			}
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
