namespace DraftManager
{
	partial class frmPlayer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			this.bnPlayers = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.xlvPlayer = new DraftManager.ListViewEx();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.btnADP = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bnPlayers
			// 
			this.bnPlayers.Location = new System.Drawing.Point(20, 598);
			this.bnPlayers.Name = "bnPlayers";
			this.bnPlayers.Size = new System.Drawing.Size(99, 25);
			this.bnPlayers.TabIndex = 20;
			this.bnPlayers.Text = "Import Players";
			this.bnPlayers.UseVisualStyleBackColor = true;
			this.bnPlayers.Click += new System.EventHandler(this.bnPlayers_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(305, 598);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 25);
			this.buttonCancel.TabIndex = 23;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(224, 598);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 25);
			this.buttonOK.TabIndex = 22;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// xlvPlayer
			// 
			this.xlvPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.xlvPlayer.FullRowSelect = true;
			this.xlvPlayer.GridLines = true;
			this.xlvPlayer.Location = new System.Drawing.Point(20, 20);
			this.xlvPlayer.Name = "xlvPlayer";
			this.xlvPlayer.Size = new System.Drawing.Size(360, 572);
			this.xlvPlayer.TabIndex = 0;
			this.xlvPlayer.UseCompatibleStateImageBehavior = false;
			this.xlvPlayer.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Last";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "NFL";
			this.columnHeader3.Width = 45;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Pos";
			this.columnHeader4.Width = 45;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "ADP";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader5.Width = 45;
			// 
			// btnADP
			// 
			this.btnADP.Location = new System.Drawing.Point(126, 599);
			this.btnADP.Name = "btnADP";
			this.btnADP.Size = new System.Drawing.Size(75, 23);
			this.btnADP.TabIndex = 24;
			this.btnADP.Text = "ADP";
			this.btnADP.UseVisualStyleBackColor = true;
			this.btnADP.Click += new System.EventHandler(this.btnADP_Click);
			// 
			// frmPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 639);
			this.Controls.Add(this.btnADP);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.bnPlayers);
			this.Controls.Add(this.xlvPlayer);
			this.Name = "frmPlayer";
			this.Text = "NFL Players";
			this.ResumeLayout(false);

		}

		#endregion

        private ListViewEx xlvPlayer;
		private System.Windows.Forms.Button bnPlayers;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button btnADP;
	}
}