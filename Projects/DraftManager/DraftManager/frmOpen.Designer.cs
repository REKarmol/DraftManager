namespace DraftManager
{
	partial class frmOpen
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
			this.bnExit = new System.Windows.Forms.Button();
			this.bnDelete = new System.Windows.Forms.Button();
			this.bnOpen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbDrafts = new System.Windows.Forms.ListBox();
			this.tbNewDraft = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bnExit
			// 
			this.bnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bnExit.Location = new System.Drawing.Point(272, 216);
			this.bnExit.Name = "bnExit";
			this.bnExit.Size = new System.Drawing.Size(75, 23);
			this.bnExit.TabIndex = 11;
			this.bnExit.Text = "Cancel";
			this.bnExit.UseVisualStyleBackColor = true;
			this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
			// 
			// bnDelete
			// 
			this.bnDelete.Location = new System.Drawing.Point(272, 184);
			this.bnDelete.Name = "bnDelete";
			this.bnDelete.Size = new System.Drawing.Size(75, 23);
			this.bnDelete.TabIndex = 10;
			this.bnDelete.Text = "Delete";
			this.bnDelete.UseVisualStyleBackColor = true;
			this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
			// 
			// bnOpen
			// 
			this.bnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bnOpen.Location = new System.Drawing.Point(272, 160);
			this.bnOpen.Name = "bnOpen";
			this.bnOpen.Size = new System.Drawing.Size(75, 23);
			this.bnOpen.TabIndex = 8;
			this.bnOpen.Text = "Open";
			this.bnOpen.UseVisualStyleBackColor = true;
			this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Select a Draft:";
			// 
			// lbDrafts
			// 
			this.lbDrafts.FormattingEnabled = true;
			this.lbDrafts.Location = new System.Drawing.Point(16, 32);
			this.lbDrafts.Name = "lbDrafts";
			this.lbDrafts.Size = new System.Drawing.Size(240, 160);
			this.lbDrafts.TabIndex = 6;
			this.lbDrafts.SelectedIndexChanged += new System.EventHandler(this.lbDrafts_SelectedIndexChanged);
			// 
			// tbNewDraft
			// 
			this.tbNewDraft.Location = new System.Drawing.Point(16, 216);
			this.tbNewDraft.Name = "tbNewDraft";
			this.tbNewDraft.Size = new System.Drawing.Size(240, 20);
			this.tbNewDraft.TabIndex = 12;
			this.tbNewDraft.TextChanged += new System.EventHandler(this.tbNewDraft_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "New Draft:";
			// 
			// frmOpen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 260);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNewDraft);
			this.Controls.Add(this.bnExit);
			this.Controls.Add(this.bnDelete);
			this.Controls.Add(this.bnOpen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbDrafts);
			this.Name = "frmOpen";
			this.Text = "Open Draft";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button bnExit;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDrafts;
        private System.Windows.Forms.TextBox tbNewDraft;
        private System.Windows.Forms.Label label2;

    }
}

