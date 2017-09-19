namespace DraftManager
{
	partial class frmTrade
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnTrade = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbTeamB = new System.Windows.Forms.ComboBox();
			this.cbTeamA = new System.Windows.Forms.ComboBox();
			this.lvTeamB = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.lvTeamA = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(445, 430);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(79, 25);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnTrade
			// 
			this.btnTrade.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnTrade.Location = new System.Drawing.Point(355, 430);
			this.btnTrade.Name = "btnTrade";
			this.btnTrade.Size = new System.Drawing.Size(79, 25);
			this.btnTrade.TabIndex = 14;
			this.btnTrade.Text = "Trade";
			this.btnTrade.UseVisualStyleBackColor = true;
			this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(273, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Team B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Team A";
			// 
			// cbTeamB
			// 
			this.cbTeamB.DropDownHeight = 212;
			this.cbTeamB.FormattingEnabled = true;
			this.cbTeamB.IntegralHeight = false;
			this.cbTeamB.Location = new System.Drawing.Point(276, 29);
			this.cbTeamB.Name = "cbTeamB";
			this.cbTeamB.Size = new System.Drawing.Size(248, 21);
			this.cbTeamB.TabIndex = 11;
			this.cbTeamB.SelectedIndexChanged += new System.EventHandler(this.cbTeamB_SelectedIndexChanged);
			// 
			// cbTeamA
			// 
			this.cbTeamA.DropDownHeight = 212;
			this.cbTeamA.FormattingEnabled = true;
			this.cbTeamA.IntegralHeight = false;
			this.cbTeamA.Location = new System.Drawing.Point(22, 29);
			this.cbTeamA.Name = "cbTeamA";
			this.cbTeamA.Size = new System.Drawing.Size(248, 21);
			this.cbTeamA.TabIndex = 10;
			this.cbTeamA.SelectedIndexChanged += new System.EventHandler(this.cbTeamA_SelectedIndexChanged);
			// 
			// lvTeamB
			// 
			this.lvTeamB.CheckBoxes = true;
			this.lvTeamB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvTeamB.GridLines = true;
			this.lvTeamB.Location = new System.Drawing.Point(276, 50);
			this.lvTeamB.Name = "lvTeamB";
			this.lvTeamB.Size = new System.Drawing.Size(248, 374);
			this.lvTeamB.TabIndex = 18;
			this.lvTeamB.UseCompatibleStateImageBehavior = false;
			this.lvTeamB.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Pick";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Rnd";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 50;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Player";
			this.columnHeader6.Width = 133;
			// 
			// lvTeamA
			// 
			this.lvTeamA.CheckBoxes = true;
			this.lvTeamA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvTeamA.GridLines = true;
			this.lvTeamA.Location = new System.Drawing.Point(22, 50);
			this.lvTeamA.Name = "lvTeamA";
			this.lvTeamA.Size = new System.Drawing.Size(248, 374);
			this.lvTeamA.TabIndex = 19;
			this.lvTeamA.UseCompatibleStateImageBehavior = false;
			this.lvTeamA.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Pick";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Rnd";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Player";
			this.columnHeader3.Width = 133;
			// 
			// frmTrade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 480);
			this.Controls.Add(this.lvTeamA);
			this.Controls.Add(this.lvTeamB);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnTrade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbTeamB);
			this.Controls.Add(this.cbTeamA);
			this.Name = "frmTrade";
			this.Text = "Trade Players/Picks";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnTrade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTeamB;
		private System.Windows.Forms.ComboBox cbTeamA;
		private System.Windows.Forms.ListView lvTeamB;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ListView lvTeamA;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}