using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;
using System.Net.Mail;

namespace DraftManager
{
	public partial class frmDraft : Form
	{
		public Model model;
		private String leagueDir;
		private String leagueName;
		private Boolean dirty;

		//******************************************************************
		public frmDraft ()
		//******************************************************************
		{
			InitializeComponent();
			leagueName = "";
			leagueDir = @"C:\DraftManager\Drafts"; //Application.StartupPath + "\\Drafts";
			model = new Model();
			model.New();
			dirty = true;
			model.SetLeagueDirectory(leagueDir);
			FillRosterCombo();
			RefillPickListView();
		}


		bool IsPaused = true;
		int ClockTicks = 121;

		//******************************************************************
		private void btnStart_Click (object sender, EventArgs e)
		//******************************************************************
		{
			ClockTicks = model.Timer+1;
			if (IsPaused == true)
			{
				IsPaused = false;
				tmrClock.Start();
				btnPause.Text = "Pause";
			}
		}

		//******************************************************************
		private void btnPause_Click (object sender, EventArgs e)
		//******************************************************************
		{
			if (IsPaused == true)
			{
				if (ClockTicks == 0)
					ClockTicks = 121;
				IsPaused = false;
				tmrClock.Start();
				btnPause.Text = "Pause";
			}
			else
			{
				tmrClock.Stop();
				IsPaused = true;
				btnPause.Text = "Resume";
			}
		}

		//******************************************************************
		private void tmrClock_Tick (object sender, EventArgs e)
		//******************************************************************
		{
			if (ClockTicks > 0)
				--ClockTicks;
			if (ClockTicks == 0)
			{
				tmrClock.Stop();
				IsPaused = true;
				btnStart.ForeColor = Color.FromName("ControlText");
				btnStart.Text = "Start";
			}
			else
			{
				if (ClockTicks > 30)
					btnStart.ForeColor = Color.FromName("DarkGreen");
				else if (ClockTicks < 31 && ClockTicks > 10)
					btnStart.ForeColor = Color.FromName("GoldenRod");
				else if (ClockTicks < 11)
					btnStart.ForeColor = Color.FromName("Red");
				int minutes = ClockTicks / 60;
				int seconds = ClockTicks % 60;
				btnStart.Text = minutes.ToString() + ":" + seconds.ToString("00");
			}
		}

		//******************************************************************
		private void btnTrade_Click (object sender, EventArgs e)
		//******************************************************************
		{
			frmTrade t = new frmTrade();
			t.SetModel(model.Ffl, model.Pick, model.Player, model.Ffls, model.Rounds);

			DialogResult dr = t.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Pick = t.GetPicks();
			}
			RefillRosterListView();
		}

		//*****************************************************
		private void btnPass_Click (object sender, EventArgs e)
		//*****************************************************
		{
			if (model.CurrentPick != model.TotalPicks)
				model.Pick[model.CurrentPick].Player = 1;
			RefillPickListView();
		}

		//*****************************************************
		private void btnUndo_Click (object sender, EventArgs e)
		//*****************************************************
		{
			int i;
			if (model.CurrentPick != 0)
			{
				--model.CurrentPick;
				i = model.Pick[model.CurrentPick].Player;
				model.Pick[model.CurrentPick].Player = 0;
				if (i != 1)
					model.Player[i].Ffl = 0;
				RefillPickListView();
			}
		}

		//*****************************************************
		private void btnClear_Click (object sender, EventArgs e)
		//*****************************************************
		{
			int i;
			if (model.CurrentPick != 0)
			{
				DialogResult dlgRes;
				dlgRes = MessageBox.Show("Are you sure you want to clear all the picks?",
															"Confirm Pick Reset",
															MessageBoxButtons.YesNo,
															MessageBoxIcon.Question);
				if (dlgRes == DialogResult.Yes)
				{
					while (model.CurrentPick != 0)
					{
						--model.CurrentPick;
						i = model.Pick[model.CurrentPick].Player;
						model.Pick[model.CurrentPick].Player = 0;
						if (i != 1)
							model.Player[i].Ffl = 0;
					}
					RefillPickListView();
				}
			}
		}

		//*****************************************************
		private void btnSave_Click (object sender, EventArgs e)
		//*****************************************************
		{
			model.Save(leagueName);
		}

		//*****************************************************
		private void btnPost_Click (object sender, EventArgs e)
		//*****************************************************
		{
			DraftBoard();
		}

		//*****************************************************
		// Pick ListView
		//*****************************************************
		private void RefillPickListView ()
		{
			int i;

			lvwPick.BeginUpdate();
			lvwPick.Items.Clear();
			model.SetPickCountersComments();

			ListViewItem lvi;
			for (i = 0; i < model.TotalPicks; ++i)
			{
				lvi = lvwPick.Items.Add(string.Format("{0}:{1}", (1 + (i / (model.Ffls))).ToString(), (1 + (i % (model.Ffls))).ToString()));
				lvi.SubItems.Add(model.Ffl[model.Pick[i].Ffl].Name);
				lvi.SubItems.Add(string.Format("{0},{1}", model.Player[model.Pick[i].Player].Last, model.Player[model.Pick[i].Player].First));
			}

			if (model.CurrentPick != model.TotalPicks)
				lvwPick.EnsureVisible(model.CurrentPick);
			else
				lvwPick.EnsureVisible(model.CurrentPick - 1);

			lvwPick.EndUpdate();

			DisplayUpNext();

			if (model.CurrentPick < model.TotalPicks)
				cmbRoster.SelectedIndex = model.Pick[model.CurrentPick].Ffl - 1;
			else
				cmbRoster.SelectedIndex = 0;

			RefillRosterListView();
			model.ValDraft();
			RefillPlayerListView();

			textComment.Text = model.DraftComment;
			btnStart.PerformClick();
		}

		//*****************************************************
		private void lvwPick_SelectedIndexChanged (object sender, EventArgs e)
		//*****************************************************
		{
			ListView.SelectedIndexCollection picks = lvwPick.SelectedIndices;

			foreach (int pick in picks)
			{
				cmbRoster.SelectedIndex = model.Pick[pick].Ffl - 1;
				RefillRosterListView();
			}
		}

		//*****************************************************
		// Up/Next Textboxes
		//*****************************************************
		private void DisplayUpNext ()
		{
			if (model.CurrentPick < model.TotalPicks)
			{
				textUp.Text = model.Ffl[model.Pick[model.CurrentPick].Ffl].Name;
				NotifyOnClock(model.Pick[model.CurrentPick].Ffl);
			}
			else
				textUp.Text = "No more picks";
			if (model.CurrentPick + 1 < model.TotalPicks)
			{
				textNext.Text = model.Ffl[model.Pick[model.CurrentPick + 1].Ffl].Name;
				NotifyOnDeck(model.Pick[model.CurrentPick + 1].Ffl);
			}
			else
				textNext.Text = "No more picks";
		}

		//*****************************************************
		// Combo Rosters
		//*****************************************************
		private void FillRosterCombo ()
		{
			cmbRoster.BeginUpdate();
			cmbRoster.Items.Clear();
			int i;
			for (i = 1; i <= model.Ffls; ++i)
				cmbRoster.Items.Add(model.Ffl[i].Name);
			cmbRoster.EndUpdate();
			cmbRoster.Refresh();
		}

		//*****************************************************
		private void cmbRoster_SelectedIndexChanged (object sender, EventArgs e)
		//*****************************************************
		{
			RefillRosterListView();
		}

		//*****************************************************
		// Roster ListView
		//*****************************************************
		private void RefillRosterListView ()
		{
			lvwRoster.BeginUpdate();
			lvwRoster.Items.Clear();

			int i, ffl;
			ffl = cmbRoster.SelectedIndex + 1;

			int[] pos1 = new int[16]; int pos1c = 0;
			int[] pos2 = new int[16]; int pos2c = 0;
			int[] pos3 = new int[16]; int pos3c = 0;
			int[] pos4 = new int[16]; int pos4c = 0;
			int[] pos5 = new int[16]; int pos5c = 0;
			int[] pos6 = new int[16]; int pos6c = 0;
			//int[] pos7 = new int[16]; int pos7c = 0;
			//int[] pos8 = new int[16]; int pos8c = 0;

			for (i = 0; i < model.TotalPicks; ++i)
			{
				if (model.Pick[i].Ffl != ffl) continue;
				if (model.Pick[i].Player == 0) continue;

				if (model.Player[model.Pick[i].Player].Position == 1) { pos1[pos1c++] = model.Pick[i].Player; }
				if (model.Player[model.Pick[i].Player].Position == 2) { pos2[pos2c++] = model.Pick[i].Player; }
				if (model.Player[model.Pick[i].Player].Position == 3) { pos3[pos3c++] = model.Pick[i].Player; }
				if (model.Player[model.Pick[i].Player].Position == 4) { pos4[pos4c++] = model.Pick[i].Player; }
				if (model.Player[model.Pick[i].Player].Position == 5) { pos5[pos5c++] = model.Pick[i].Player; }
				if (model.Player[model.Pick[i].Player].Position == 6) { pos6[pos6c++] = model.Pick[i].Player; }
				//if (model.Player[model.Pick[i].Player].Position == 7) { pos1[pos1c++] = model.Pick[i].Player; }
				//if (model.Player[model.Pick[i].Player].Position == 8) { pos1[pos1c++] = model.Pick[i].Player; }
			}

			ListViewItem lvi;
			for (i = 0; i < pos1c || i < pos2c || i < pos3c || i < pos4c || i < pos5c || i < pos6c; ++i)
			{
				lvi = lvwRoster.Items.Add(string.Format("{0}", i + 1));
				lvi.SubItems.Add((i < pos1c) ? string.Format("{0} {1} {2}, {3}", model.Nfl[model.Player[pos1[i]].Nfl].Name.PadRight(3, ' '), model.Nfl[model.Player[pos1[i]].Nfl].Bye.PadLeft(2, ' '), model.Player[pos1[i]].Last, model.Player[pos1[i]].First) : "");
				lvi.SubItems.Add((i < pos2c) ? string.Format("{0} {1} {2}, {3}", model.Nfl[model.Player[pos2[i]].Nfl].Name.PadRight(3, ' '), model.Nfl[model.Player[pos2[i]].Nfl].Bye.PadLeft(2, ' '), model.Player[pos2[i]].Last, model.Player[pos2[i]].First) : "");
				lvi.SubItems.Add((i < pos3c) ? string.Format("{0} {1} {2}, {3}", model.Nfl[model.Player[pos3[i]].Nfl].Name.PadRight(3, ' '), model.Nfl[model.Player[pos3[i]].Nfl].Bye.PadLeft(2, ' '), model.Player[pos3[i]].Last, model.Player[pos3[i]].First) : "");
				lvi.SubItems.Add((i < pos4c) ? string.Format("{0} {1} {2}, {3}", model.Nfl[model.Player[pos4[i]].Nfl].Name.PadRight(3, ' '), model.Nfl[model.Player[pos4[i]].Nfl].Bye.PadLeft(2, ' '), model.Player[pos4[i]].Last, model.Player[pos4[i]].First) : "");
				lvi.SubItems.Add((i < pos5c) ? string.Format("{0} {1} {2}, {3}", model.Nfl[model.Player[pos5[i]].Nfl].Name.PadRight(3, ' '), model.Nfl[model.Player[pos5[i]].Nfl].Bye.PadLeft(2, ' '), model.Player[pos5[i]].Last, model.Player[pos5[i]].First) : "");
				lvi.SubItems.Add((i < pos6c) ? string.Format("{0} {1} {2}, {3}", model.Nfl[model.Player[pos6[i]].Nfl].Name.PadRight(3, ' '), model.Nfl[model.Player[pos6[i]].Nfl].Bye.PadLeft(2, ' '), model.Player[pos6[i]].Last, model.Player[pos6[i]].First) : "");
			}
			lvwRoster.EndUpdate();
		}

		//*****************************************************
		private void DraftBoard ()
		//*****************************************************
		{
			int i, j, r;
			model.SavePicks();
			StreamWriter html = new StreamWriter(@"C:\DraftManager\Drafts\DraftBoard.html", false);
			html.WriteLine("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 3.2 Final//EN\">");
			html.WriteLine("<HTML>");
			html.WriteLine("<HEAD>");
			html.WriteLine("<TITLE>PassTime Draftboard</TITLE>");
			html.WriteLine("<META HTTP-EQUIV=REFRESH CONTENT=60>");
			html.WriteLine("</HEAD>");
			html.WriteLine("<BODY BGCOLOR=\"#FFFFFF\" TEXT=\"#000000\" LINK=\"#FF0000\" VLINK=\"#800000\" ALINK=\"#FF00FF\">");
			html.WriteLine("<TABLE ALIGN=\"left\" BORDER=1 CELLSPACING=0 CELLPADDING=0 WIDTH=\"100%\">");

			html.WriteLine("<TR ALIGN=\"left\" VALIGN=\"middle\">");
			html.WriteLine("<TH></TH>");
			for (i = 1; i <=model.Ffls; ++i)
			{
				html.WriteLine("<TH>{0}</TH>", model.Ffl[i].Name);
			}
			html.WriteLine("</TR>");
			for (r = 0; r < 16; ++r)
			{
				html.WriteLine("<TR ALIGN=\"left\" VALIGN=\"middle\">");
				html.WriteLine("<TD>Rnd {0}</TD>", r + 1);
				for (i = 1; i <= model.Ffls; ++i)
				{
					for (j = (r * model.Ffls); j < (r * model.Ffls) + model.Ffls; ++j)
					{
						if (model.Pick[j].Ffl == i)
						{
							int plr = model.Pick[j].Player;
							int pos = model.Player[plr].Position;
							int nfx = model.Player[plr].Nfl;
							if (plr > 2)
								html.WriteLine("<TD>{0} {1} {2}</TD>", model.Position[pos].Name, model.Nfl[nfx].Name, model.Player[plr].Last);
							else if (plr == 1)
								html.WriteLine("<TD>Pass</TD>");
							else
								html.WriteLine("<TD></TD>");
						}
					}
				}
				html.WriteLine("</TR>");
			}
			html.WriteLine("</TABLE>");
			html.WriteLine("</BODY>");
			html.WriteLine("</HTML>");

			html.Close();
			Upload(@"C:\DraftManager\Drafts\DraftBoard.html");
		}

		//*****************************************************
		private void NotifyOnClock (int team)
		//*****************************************************
		{
			int i, j, r;

			if (model.Ffl[team].Email==null || model.Ffl[team].Email.Length<1)
				return;
			return;

			StringBuilder sb = new StringBuilder();

			sb.AppendLine("You are up.  Please reply with your next pick.");
			sb.AppendLine("");
			sb.AppendLine("Here is the current Draftboard of players taken:");
			sb.AppendLine("");
			sb.Append("     ");
			for (i = 1; i <=model.Ffls; ++i)
			{
				sb.Append(model.Ffl[i].Name.PadRight(20,' '));
			}
			sb.AppendLine("");

			sb.Append("     ");
			for (i = 1; i <=model.Ffls; ++i)
			{
				sb.Append("------------------- ");
			}
			sb.AppendLine("");

			for (r = 0; r < 16; ++r)
			{
				sb.AppendFormat("R {0} ",(r+1).ToString("00"));
				for (i = 1; i <= model.Ffls; ++i)
				{
					for (j = (r * model.Ffls); j < (r * model.Ffls) + model.Ffls; ++j)
					{
						if (model.Pick[j].Ffl == i)
						{
							int plr = model.Pick[j].Player;
							int pos = model.Player[plr].Position;
							int nfx = model.Player[plr].Nfl;
							string plyr = model.Position[pos].Name + " " + model.Nfl[nfx].Name + " " + model.Player[plr].Last;
							if (plr > 2)
								sb.Append(plyr.PadRight(20,' '));
							else if (plr == 1)
								sb.Append("Pass".PadRight(20, ' '));
							else
								sb.Append("".PadRight(20, ' '));
						}
					}
				}
				sb.AppendLine("");
			}

			try
			{
				MailMessage mail = new MailMessage();
				SmtpClient smptserver = new SmtpClient("smpt.googlemail.com");
				mail.From = new MailAddress("randykarmolinski@gmail.com");
				mail.To.Add(model.Ffl[team].Email);
				mail.Subject = model.Ffl[team].Name;
				mail.Body = sb.ToString();

				smptserver.Port = 587;
				smptserver.Credentials = new System.Net.NetworkCredential("randykarmolinski@gmail.com", "InstantRando8");
				smptserver.EnableSsl = true;
				smptserver.Send(mail);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		//*****************************************************
		private void NotifyOnDeck (int team)
		//*****************************************************
		{
			int i, j, r;

			if (model.Ffl[team].Email==null || model.Ffl[team].Email.Length<1)
				return;
			// TODO: check for valid email format
			return;

			StringBuilder sb = new StringBuilder();

			sb.AppendLine("You are up next.  Here is the current Draftboard of players taken:");
			sb.AppendLine("");
			sb.Append("     ");
			for (i = 1; i <=model.Ffls; ++i)
			{
				sb.Append(model.Ffl[i].Name.PadRight(20,' '));
			}
			sb.AppendLine("");

			sb.Append("     ");
			for (i = 1; i <=model.Ffls; ++i)
			{
				sb.Append("------------------- ");
			}
			sb.AppendLine("");

			for (r = 0; r < 16; ++r)
			{
				sb.AppendFormat("R {0} ",(r+1).ToString("00"));
				for (i = 1; i <= model.Ffls; ++i)
				{
					for (j = (r * model.Ffls); j < (r * model.Ffls) + model.Ffls; ++j)
					{
						if (model.Pick[j].Ffl == i)
						{
							int plr = model.Pick[j].Player;
							int pos = model.Player[plr].Position;
							int nfx = model.Player[plr].Nfl;
							string plyr = model.Position[pos].Name + " " + model.Nfl[nfx].Name + " " + model.Player[plr].Last;
							if (plr > 2)
								sb.Append(plyr.PadRight(20,' '));
							else if (plr == 1)
								sb.Append("Pass".PadRight(20, ' '));
							else
								sb.Append("".PadRight(20, ' '));
						}
					}
				}
				sb.AppendLine("");
			}

			try
			{
				MailMessage mail = new MailMessage();
				SmtpClient smptserver = new SmtpClient("smpt.googlemail.com");
				mail.From = new MailAddress("randykarmolinski@gmail.com");
				mail.To.Add(model.Ffl[team].Email);
				mail.Subject = model.Ffl[team].Name + " on deck";
				mail.Body = sb.ToString();

				smptserver.Port = 587;
				smptserver.Credentials = new System.Net.NetworkCredential("randykarmolinski@gmail.com", "InstantRando8");
				smptserver.EnableSsl = true;
				smptserver.Send(mail);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		//*****************************************************
		private void bnValue_Click (object sender, EventArgs e)
		//*****************************************************
		{
			model.ValDraft();
			RefillPlayerListView();
		}

		//*****************************************************
		private void btnCS_Click (object sender, EventArgs e)
		//*****************************************************
		{
			RefillPlayerListViewCS();
		}

		//*****************************************************
		private void bnAlpha_Click (object sender, EventArgs e)
		//*****************************************************
		{
			model.ABCDraft();
			RefillPlayerListView();
		}

		//*****************************************************
		private void btnADP_Click (object sender, EventArgs e)
		//*****************************************************
		{
			model.ADPDraftFull();
			RefillPlayerListView();
		}

		//*****************************************************
		private void lvwPlayer_SelectedIndexChanged (object sender, EventArgs e)
		//*****************************************************
		{
			if (model.CurrentPick < model.TotalPicks)
			{
				ListView.SelectedIndexCollection players = lvwPlayer.SelectedIndices;
				foreach (int player in players)
				{
					model.Pick[model.CurrentPick].Player = model.PlayerIndex[player];
					model.Player[model.PlayerIndex[player]].Ffl = model.Pick[model.CurrentPick].Ffl;
				}
				RefillPickListView();
			}
		}
		//*****************************************************
		// Player ListView
		//*****************************************************
		private void RefillPlayerListView ()
		{
			int ply;

			lvwPlayer.BeginUpdate();
			lvwPlayer.Items.Clear();

			ListViewItem lvi;
			for (ply = 0; ply < model.PlayerIndexes; ++ply)
			{
				int pos = model.Player[model.PlayerIndex[ply]].Position;
				int n = model.Player[model.PlayerIndex[ply]].Nfl;
				string first = model.Player[model.PlayerIndex[ply]].First;
				string last = model.Player[model.PlayerIndex[ply]].Last;
				string val = model.PlayerValue[ply].ToString("0");
				int adp = (int) (model.Player[model.PlayerIndex[ply]].Adp + 0.5F);

				string risk = "";
				if (model.PlayerRanking[ply]!=model.Ranking.Count)
					risk = model.Ranking[model.PlayerRanking[ply]].Risk;
				if (risk!="")
					risk = " ("+risk+")";

				string token = string.Format("{0} {1} {2}, {3}", model.Nfl[n].Name.PadRight(3, ' '), model.Nfl[n].Bye.PadLeft(2, ' '), last, first+risk);
				lvi = lvwPlayer.Items.Add(val);
				lvi.SubItems.Add(pos == 1 ? token : "");
				lvi.SubItems.Add(pos == 2 ? token : "");
				lvi.SubItems.Add(pos == 3 ? token : "");
				lvi.SubItems.Add(pos == 4 ? token : "");
				lvi.SubItems.Add(pos == 5 ? token : "");
				lvi.SubItems.Add(pos == 6 ? token : "");

				if (model.CurrentPick + ply > model.NextPick)
				{
					lvi.BackColor = Color.LightGray;
				}
				else
				{
					lvi.BackColor = Color.White;
					lvwPlayer.Items[ply].UseItemStyleForSubItems = false;
					if (adp <= model.NextPick)
					{
						lvwPlayer.Items[ply].SubItems[pos].ForeColor = Color.Green;
					}
					else
					{
						lvwPlayer.Items[ply].SubItems[pos].ForeColor = Color.Red;
					}
				}
			}
			lvwPlayer.EndUpdate();
		}

		//*****************************************************
		// Player ListViewCS
		//*****************************************************
		private void RefillPlayerListViewCS ()
		{
			int row;

			lvwPlayer.BeginUpdate();
			lvwPlayer.Items.Clear();

			if (model.CurrentPick < model.TotalPicks)
			{
				for (int targetrow = 1; targetrow<84; ++targetrow)
				{
					int targetteam = model.Pick[model.CurrentPick].Ffl;

					ListViewItem lvi;
					string val = targetrow.ToString("0");
					lvi = lvwPlayer.Items.Add(val);

					for (int pos = 1; pos<model.Position.Count; ++pos)
					{
						int handled = 0;
						for (row = 0; row < model.Ranking.Count; ++row)
						{
							if (model.Ranking[row].Ffl!=targetteam) continue;
							if (model.Ranking[row].Position!=pos) continue;
							if (model.Ranking[row].Rank!=targetrow) continue;

							int plr = model.Ranking[row].Player;
							int n = model.Player[plr].Nfl;
							string first = model.Player[plr].First;
							string last = model.Player[plr].Last;

							string risk = model.Ranking[row].Risk;
							if (risk!="")
								risk = " ("+risk+")";

							string token = string.Format("{0} {1} {2}, {3}", model.Nfl[n].Name.PadRight(3, ' '), model.Nfl[n].Bye.PadLeft(2, ' '), last, first+risk);
							lvi.SubItems.Add(token);
							handled = 1;

							lvi.BackColor = Color.White;
							lvwPlayer.Items[targetrow-1].UseItemStyleForSubItems = false;
							if (model.Player[plr].Ffl==0)
							{
								lvwPlayer.Items[targetrow-1].SubItems[pos].ForeColor = Color.Black;
							}
							else
							{
								lvwPlayer.Items[targetrow-1].SubItems[pos].ForeColor = Color.Red;
							}
						}
						if (handled==0)
						{
							lvi.SubItems.Add("");
						}
					}
				}
			}
			lvwPlayer.EndUpdate();
		}

		private void Upload (string filename)
		{
			if (model.Password.Length>0)
			{
				try
				{
					FileInfo fileInf = new FileInfo(filename);
					string uri = model.URI + "/public_html/" + fileInf.Name;
					FtpWebRequest request = (FtpWebRequest) WebRequest.Create(uri);
					request.Method = WebRequestMethods.Ftp.UploadFile;
					request.KeepAlive = false;
					request.Method = WebRequestMethods.Ftp.UploadFile;
					request.UseBinary = false;
					request.UsePassive = true;

					// This example assumes the FTP site uses anonymous logon.
					request.Credentials = new NetworkCredential(model.Username, model.Password);

					// Copy the contents of the file to the request stream.
					StreamReader sourceStream = new StreamReader(filename);
					byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
					sourceStream.Close();
					request.ContentLength = fileContents.Length;

					Stream requestStream = request.GetRequestStream();
					requestStream.Write(fileContents, 0, fileContents.Length);
					requestStream.Close();
				}
				catch (Exception E)
				{
					MessageBox.Show(E.ToString());
				}
				//FtpWebResponse response = (FtpWebResponse) request.GetResponse();
				//string x = string.Format("Upload File Complete, status {0}", response.StatusDescription);
				//response.Close();
			}
		}

		//<*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*>
		// menu handler section
		//<*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*><*>

		//*****************************************************
		private void newDraftToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			leagueName = "";
			dirty = true;
			model.New();
		}

		//*****************************************************
		private void openDraftToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Draft Files (*.draft)|*.draft";
			ofd.InitialDirectory = leagueDir;
			ofd.Title = "Open Draft";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				leagueName = ofd.FileName;
				model.Open(leagueName);
				FillRosterCombo();
				RefillPickListView();
				RefillPlayerListView();
				//model.RebuildPicks();
			}
		}

		//*****************************************************
		private void closeToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			DialogResult dlgRes = DialogResult.Yes;
			if (dirty)
			{
				dlgRes = MessageBox.Show("Are you sure you want to close?  No changes will be saved.",
												 "Confirm Draft Manager close",
												 MessageBoxButtons.YesNo,
												 MessageBoxIcon.Question);
			}
			if (dlgRes == DialogResult.Yes)
			{
				this.Text = "Draft Manager";
				leagueName = "";
				dirty = true;
				model.New();
			}
		}

		//*****************************************************
		private void SaveAs ()
		//*****************************************************
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Draft Files (*.draft)|*.draft";
			sfd.InitialDirectory = leagueDir;
			sfd.FileName = leagueName;
			sfd.Title = "Save Draft";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				leagueName = sfd.FileName;
				model.Save(leagueName);
				dirty = false;
			}
		}

		//*****************************************************
		private void saveToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			if (leagueName.Equals(""))
			{
				SaveAs();
			}
			else
			{
				model.Save(leagueName);
				dirty = false;
			}
		}

		//*****************************************************
		private void saveAsToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			SaveAs();
		}

		//*****************************************************
		private void exitToolStripMenuItem1_Click (object sender, EventArgs e)
		//*****************************************************
		{
			DialogResult dlgRes = DialogResult.Yes;
			if (dirty)
			{
				dlgRes = MessageBox.Show("Are you sure you want to exit?  No changes will be saved.",
												 "Confirm Draft Manager exit",
												 MessageBoxButtons.YesNo,
												 MessageBoxIcon.Question);
			}
			if (dlgRes == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		//*****************************************************
		private void generalInformationToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmBasic p = new frmBasic();
			p.SetModel(model.Nfl, model.Position, model.orderchoices, model.Style, model.Ffls, model.Rounds, model.Timer, 0.0f, 0.0f);

			DialogResult dr = p.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Ffls = p.GetTeams();
				model.Rounds = p.GetRounds();
				model.Timer = p.GetTimer();
				model.Style = p.GetStyle();
				model.Salary = p.GetSalCap();
				model.MinBid = p.GetMinBid();

				if (model.Ffls > Model.maxFfls) model.Ffls = Model.maxFfls;
				if (model.Rounds > Model.maxRounds) model.Rounds = Model.maxRounds;
				if (model.Positions > Model.maxPositions) model.Positions = Model.maxPositions;

				p.GetNFLs(model.Nfl);
				model.Nfls = model.Nfl.Count - 1;
				model.Nfl.Sort();

				p.GetPositions(model.Position);
				model.Positions = model.Position.Count - 1;
				model.RebuildPicks(); // note: also rebuilds Order from Style and Rounds
			}
		}

		//*****************************************************
		private void fTPInformationToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmFTP f = new frmFTP();
			f.SetModel(model.URI, model.Username, model.Password);

			DialogResult dr = f.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.URI = f.GetURI();
				model.Username = f.GetUsername();
				model.Password = f.GetPassword();
			}
		}

		//*****************************************************
		private void scoringToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmScoring s = new frmScoring();
			s.SetModel(model.Score, model.Position);

			DialogResult dr = s.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Score = s.GetScores();
			}
		}

		//*****************************************************
		private void averagesToolStripMenuItem_Click_1 (object sender, EventArgs e)
		//*****************************************************
		{
			frmAverage a = new frmAverage();
			a.SetModel(model.Average, model.Position, model.Score);

			DialogResult dr = a.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Average = a.GetAverages();
			}
		}

		//*****************************************************
		private void playersToolStripMenuItem1_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmPlayer p = new frmPlayer();
			p.SetModel(model.Player, model.Position, model.Nfl);

			DialogResult dr = p.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Nfl = p.GetNfls(); // byes may change
				model.Player = p.GetPlayers();
				model.Players = model.Player.Count;
			}
		}

		//*****************************************************
		private void teamsToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmTeam t = new frmTeam();
			t.SetModel(model.Ffl, model.Confidence, model.Weight, model.Limit, model.Comment, model.Position, model.Ffls, model.Rounds);

			DialogResult dr = t.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Ffl = t.GetFfl();
				model.Comment = t.GetComment();
				model.Confidence = t.GetConfidence();
				model.Limit = t.GetLimit();
				model.Weight = t.GetWeight();
				FillRosterCombo();
			}
		}

		//*****************************************************
		private void picksToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmPick p = new frmPick();
			p.SetModel(model.Ffl, model.Pick, model.Player, model.Ffls);

			DialogResult dr = p.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Pick = p.GetPicks();
			}
		}

		//*****************************************************
		private void rankingsToolStripMenuItem_Click (object sender, EventArgs e)
		//*****************************************************
		{
			frmRanking r = new frmRanking();
			r.SetModel(model.Ranking, model.Ffl, model.Position, model.Player, model.Nfl, model.Average, model.Score);

			DialogResult dr = r.ShowDialog();
			if (dr == DialogResult.OK)
			{
				dirty = true;
				model.Ranking = r.GetRanking();
			}
		}
	}
}
