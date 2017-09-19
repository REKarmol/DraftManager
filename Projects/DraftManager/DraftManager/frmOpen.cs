using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DraftManager
{
	public partial class frmOpen : Form
	{
		public string sDefaultDir;

        //******************************************************************
        // MainForm data
        //******************************************************************
        int nSelected = 0;
        List<string> lstDrafts;

		//******************************************************************
		public frmOpen ()
		//******************************************************************
		{
			InitializeComponent();

            // fill selection Listbox and path list
            lstDrafts = new List<string>();

            lbDrafts.Items.Add("[New Draft]");
            lstDrafts.Add("");

            DirectoryInfo di = new DirectoryInfo(sDefaultDir);
            FileInfo[] list = di.GetFiles("*.setup");

            foreach (FileInfo d in list)
            {
                lbDrafts.Items.Add(d.Name);
                lstDrafts.Add(d.FullName);
            }
            lbDrafts.SelectedIndex = 0;
            tbNewDraft.Text = "";
        }

        //******************************************************************
        private void lbDrafts_SelectedIndexChanged(object sender, EventArgs e)
        //******************************************************************
        {
            nSelected = lbDrafts.SelectedIndex;
            if (nSelected==0)
            {
                bnOpen.Text = "Create";
                bnDelete.Enabled = false;
                tbNewDraft.Enabled = true;
                if (tbNewDraft.Text.Equals(""))
                    bnOpen.Enabled = false;
            }
            else
            {
                bnOpen.Text = "Open";
                bnOpen.Enabled = true;
                bnDelete.Enabled = true;
                tbNewDraft.Enabled = false;
            }
            return;
        }

        //******************************************************************
        private void bnOpen_Click(object sender, EventArgs e)
        //******************************************************************
        {
            // new draft
            if (nSelected==0)
            {
                string s = @"C:\DraftManager\Drafts\"+tbNewDraft.Text;

                // exists already?  just use it
                if (Directory.Exists(s))
                {
                    Draft(s);
                    return;
                }

                // else create new one, add to listbox, and use it
                try
                {
                    System.IO.DirectoryInfo c = Directory.CreateDirectory(s);
                    lstDrafts.Add(s);
                    lbDrafts.Items.Add(tbNewDraft.Text);
                    tbNewDraft.Text = "";
                    lbDrafts.SelectedIndex = 0;
                    lbDrafts.Refresh();
                    Draft(s);
                    return;
                }
                catch (Exception x)
                {
                    MessageBox.Show("Create failed: "+x.Message,"Create New Draft",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
            }

            // not a new draft; use existing
            Draft(lstDrafts[nSelected]);
        }

        //******************************************************************
        private void bnDelete_Click(object sender, EventArgs e)
        //******************************************************************
        {
            if (nSelected>0)
            {
                DialogResult dlgRes=DialogResult.Yes;
                dlgRes = MessageBox.Show("Are you sure?",
                         "Confirm Delete",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                if (dlgRes==DialogResult.Yes)
                {
                    Directory.Delete(lstDrafts[nSelected]);
                    lstDrafts.RemoveAt(nSelected);
                    lbDrafts.Items.RemoveAt(nSelected);
                    tbNewDraft.Text = "";
                    lbDrafts.SelectedIndex = 0;
                    lbDrafts.Refresh();
                }
            }
        }

        //******************************************************************
        private void tbNewDraft_TextChanged(object sender, EventArgs e)
        //******************************************************************
        {
            if (tbNewDraft.Text.Equals(""))
                bnOpen.Enabled = false;
            else
                bnOpen.Enabled = true;
        }

        //******************************************************************
        //private void bnExit_Click(object sender, EventArgs e)
        //******************************************************************
        //{
            //Application.Exit();
        //}

        //******************************************************************
        //private void Draft(string p)
        //******************************************************************
        //{
			//sDefaultDir = p;
			//frmDraft df = new frmDraft(p);
            //df.ShowDialog();
        //}

    }
}
