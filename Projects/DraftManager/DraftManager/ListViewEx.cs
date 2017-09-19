using System;
using System.Windows.Forms;
using System.Drawing;

namespace DraftManager
{
	public class ListViewEx : ListView
	{
		private ListViewItem li;
		private int X=0;
		private int Y=0;
		private string subItemText;
		private int subItemSelected = 0;
		private TextBox  editBox = new TextBox();
		public NumericUpDown numericUpDown = new NumericUpDown();
		public ComboBox cmbBox1 = new ComboBox();
		public ComboBox cmbBox2 = new ComboBox();
		public ComboBox cmbBox3 = new ComboBox();
		public string cmbColumn1 = "";
		public string cmbColumn2 = "";
		public string cmbColumn3 = "";
		public string fxdColumn = "";
		public string numColumn = "";

		public ListViewEx ()
		{
			cmbBox1.Size  = new System.Drawing.Size(0, 0);
			cmbBox1.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.cmbBox1 });
			cmbBox1.SelectedIndexChanged += new System.EventHandler(this.Cmb1Selected);
			cmbBox1.LostFocus += new System.EventHandler(this.Cmb1FocusOver);
			cmbBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb1KeyPress);
			cmbBox1.BackColor = Color.SkyBlue;
			cmbBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbBox1.Hide();

			cmbBox2.Size  = new System.Drawing.Size(0, 0);
			cmbBox2.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.cmbBox2 });
			cmbBox2.SelectedIndexChanged += new System.EventHandler(this.Cmb2Selected);
			cmbBox2.LostFocus += new System.EventHandler(this.Cmb2FocusOver);
			cmbBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb2KeyPress);
			cmbBox2.BackColor = Color.SkyBlue;
			cmbBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbBox2.Hide();

			cmbBox3.Size  = new System.Drawing.Size(0, 0);
			cmbBox3.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.cmbBox3 });
			cmbBox3.SelectedIndexChanged += new System.EventHandler(this.Cmb3Selected);
			cmbBox3.LostFocus += new System.EventHandler(this.Cmb3FocusOver);
			cmbBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb3KeyPress);
			cmbBox3.BackColor = Color.SkyBlue;
			cmbBox3.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbBox3.Hide();

			this.FullRowSelect = true;
			//this.Name = "listView1";
			this.Size = new System.Drawing.Size(0, 0);
			this.TabIndex = 0;
			this.View = System.Windows.Forms.View.Details;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SMKMouseDown);
			this.Click += new System.EventHandler(this.SMKClick);
			this.GridLines = true;

			editBox.Size  = new System.Drawing.Size(0, 0);
			editBox.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.editBox });
			editBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOver);
			editBox.LostFocus += new System.EventHandler(this.FocusOver);
			editBox.BackColor = Color.LightYellow;
			editBox.BorderStyle = BorderStyle.Fixed3D;
			editBox.Hide();
			editBox.Text = "";

			numericUpDown.Size  = new System.Drawing.Size(0, 0);
			numericUpDown.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.numericUpDown });
			numericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOver);
			numericUpDown.LostFocus += new System.EventHandler(this.NumFocusOver);
			numericUpDown.BackColor = Color.LightYellow;
			numericUpDown.BorderStyle = BorderStyle.Fixed3D;
			numericUpDown.Hide();
			numericUpDown.Value = (decimal) 0;
			numericUpDown.Minimum = (decimal) 0;
			numericUpDown.Maximum = (decimal) 9999999;
			numericUpDown.DecimalPlaces = 2;
			numericUpDown.TextAlign = HorizontalAlignment.Right;
			numericUpDown.UpDownAlign = LeftRightAlignment.Right;
		}

		private void Cmb1KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13 || e.KeyChar == 27)
			{
				cmbBox1.Hide();
			}
		}
		private void Cmb2KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13 || e.KeyChar == 27)
			{
				cmbBox2.Hide();
			}
		}
		private void Cmb3KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13 || e.KeyChar == 27)
			{
				cmbBox3.Hide();
			}
		}
		
		private void Cmb1Selected (object sender, System.EventArgs e)
		{
			int sel = cmbBox1.SelectedIndex;
			if (sel>=0 && li!=null)
			{
				string itemSel = cmbBox1.Items[sel].ToString();
				li.SubItems[subItemSelected].Text = itemSel;
			}
		}
		private void Cmb2Selected (object sender, System.EventArgs e)
		{
			int sel = cmbBox2.SelectedIndex;
			if (sel>=0 && li!=null)
			{
				string itemSel = cmbBox2.Items[sel].ToString();
				li.SubItems[subItemSelected].Text = itemSel;
			}
		}
		private void Cmb3Selected (object sender, System.EventArgs e)
		{
			int sel = cmbBox3.SelectedIndex;
			if (sel>=0 && li!=null)
			{
				string itemSel = cmbBox3.Items[sel].ToString();
				li.SubItems[subItemSelected].Text = itemSel;
			}
		}

		private void Cmb1FocusOver (object sender, System.EventArgs e)
		{
			cmbBox1.Hide();
		}
		private void Cmb2FocusOver (object sender, System.EventArgs e)
		{
			cmbBox2.Hide();
		}
		private void Cmb3FocusOver (object sender, System.EventArgs e)
		{
			cmbBox3.Hide();
		}

		private void EditOver (object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				li.SubItems[subItemSelected].Text = editBox.Text;
				editBox.Hide();
			}

			if (e.KeyChar == 27)
				editBox.Hide();
		}

		private void NumOver (object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				li.SubItems[subItemSelected].Text = numericUpDown.Text;
				numericUpDown.Hide();
			}

			if (e.KeyChar == 27)
				numericUpDown.Hide();
		}

		private void FocusOver (object sender, System.EventArgs e)
		{
			li.SubItems[subItemSelected].Text = editBox.Text;
			editBox.Hide();
		}

		private void NumFocusOver (object sender, System.EventArgs e)
		{
			li.SubItems[subItemSelected].Text = numericUpDown.Text;
			//numericUpDown.Hide();
		}

		public void SMKClick (object sender, System.EventArgs e)
		{
			// Check the subitem clicked .
			int nStart = X;
			int spos = 0;
			int epos = this.Columns[0].Width;

			for (int i=0; i<this.Columns.Count; i++)
			{
				subItemSelected = i;
				if (nStart>spos && nStart<epos)
					break;
				spos = epos;
				epos += this.Columns[i+1].Width;
			}

			subItemText = li.SubItems[subItemSelected].Text;
			numericUpDown.Hide();

			string colName = "/"+this.Columns[subItemSelected].Text+"/";
			if (fxdColumn.Contains(colName))
			{ }
			else if (cmbColumn1.Contains(colName))
			{
				Rectangle r = new Rectangle(spos, li.Bounds.Y, epos, li.Bounds.Bottom);
				cmbBox1.Size  = new System.Drawing.Size(epos - spos, li.Bounds.Bottom-li.Bounds.Top);
				cmbBox1.Location = new System.Drawing.Point(spos, li.Bounds.Y);
				cmbBox1.Show();
				cmbBox1.Text = subItemText;
				cmbBox1.SelectAll();
				cmbBox1.Focus();
			}
			else if (cmbColumn2.Contains(colName))
			{
				Rectangle r = new Rectangle(spos, li.Bounds.Y, epos, li.Bounds.Bottom);
				cmbBox2.Size  = new System.Drawing.Size(epos - spos, li.Bounds.Bottom-li.Bounds.Top);
				cmbBox2.Location = new System.Drawing.Point(spos, li.Bounds.Y);
				cmbBox2.Show();
				cmbBox2.Text = subItemText;
				cmbBox2.SelectAll();
				cmbBox2.Focus();
			}
			else if (cmbColumn3.Contains(colName))
			{
				Rectangle r = new Rectangle(spos, li.Bounds.Y, epos, li.Bounds.Bottom);
				cmbBox3.Size  = new System.Drawing.Size(epos - spos, li.Bounds.Bottom-li.Bounds.Top);
				cmbBox3.Location = new System.Drawing.Point(spos, li.Bounds.Y);
				cmbBox3.Show();
				cmbBox3.Text = subItemText;
				cmbBox3.SelectAll();
				cmbBox3.Focus();
			}
			else if (numColumn.Contains(colName))
			{
				Rectangle r = new Rectangle(spos, li.Bounds.Y, epos, li.Bounds.Bottom);
				numericUpDown.Size  = new System.Drawing.Size(epos - spos, li.Bounds.Bottom-li.Bounds.Top);
				numericUpDown.Location = new System.Drawing.Point(spos, li.Bounds.Y);
				numericUpDown.Show();
				numericUpDown.Text = subItemText;
				numericUpDown.Focus();
			}
			else
			{
				Rectangle r = new Rectangle(spos, li.Bounds.Y, epos, li.Bounds.Bottom);
				editBox.Size  = new System.Drawing.Size(epos - spos, li.Bounds.Bottom-li.Bounds.Top);
				editBox.Location = new System.Drawing.Point(spos, li.Bounds.Y);
				editBox.Show();
				editBox.Text = subItemText;
				editBox.SelectAll();
				editBox.Focus();
			}
		}

		public void SMKMouseDown (object sender, System.Windows.Forms.MouseEventArgs e)
		{
			li = this.GetItemAt(e.X, e.Y);
			X = e.X;
			Y = e.Y;
		}
	}
}
