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
	public partial class frmFTP : Form
	{
		public frmFTP()
		{
			InitializeComponent();
		}

		//********************************************
		public void SetModel(string uri, string un, string p)
		//********************************************
		{
			textURI.Text = uri.ToString();
			textUsername.Text = un.ToString();
			textPassword.Text = p.ToString();
		}

		//********************************************
		public string GetURI()
		//********************************************
		{
			return textURI.Text;
		}

		//********************************************
		public string GetUsername()
		//********************************************
		{
			return textUsername.Text;
		}

		//********************************************
		public string GetPassword()
		//********************************************
		{
			return textPassword.Text;
		}
	}
}
