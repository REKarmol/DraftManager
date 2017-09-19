namespace DraftManager
{
	partial class frmPick
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.xlvPicks = new DraftManager.ListViewEx();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// xlvPicks
			// 
			this.xlvPicks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
			this.xlvPicks.FullRowSelect = true;
			this.xlvPicks.GridLines = true;
			this.xlvPicks.Location = new System.Drawing.Point(13, 13);
			this.xlvPicks.Name = "xlvPicks";
			this.xlvPicks.Size = new System.Drawing.Size(383, 547);
			this.xlvPicks.TabIndex = 0;
			this.xlvPicks.UseCompatibleStateImageBehavior = false;
			this.xlvPicks.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Pick";
			this.columnHeader1.Width = 35;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Round";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Ffl Team";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Player";
			this.columnHeader3.Width = 139;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(313, 566);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(83, 30);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(224, 566);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 30);
			this.buttonOK.TabIndex = 15;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// frmPick
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 610);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.xlvPicks);
			this.Name = "frmPick";
			this.Text = "Picks";
			this.ResumeLayout(false);

		}

		#endregion

		private ListViewEx xlvPicks;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}