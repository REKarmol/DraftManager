namespace DraftManager
{
	partial class frmFTP
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textUsername = new System.Windows.Forms.TextBox();
			this.textURI = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textPassword);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textUsername);
			this.groupBox1.Controls.Add(this.textURI);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 106);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FTP Information";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "URI:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Username:";
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(80, 74);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(160, 20);
			this.textPassword.TabIndex = 41;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Password:";
			// 
			// textUsername
			// 
			this.textUsername.Location = new System.Drawing.Point(80, 48);
			this.textUsername.Name = "textUsername";
			this.textUsername.Size = new System.Drawing.Size(160, 20);
			this.textUsername.TabIndex = 38;
			// 
			// textURI
			// 
			this.textURI.Location = new System.Drawing.Point(80, 24);
			this.textURI.Name = "textURI";
			this.textURI.Size = new System.Drawing.Size(160, 20);
			this.textURI.TabIndex = 37;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(175, 124);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(83, 25);
			this.buttonCancel.TabIndex = 47;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(86, 124);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 25);
			this.buttonOK.TabIndex = 46;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// frmFTP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 170);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmFTP";
			this.Text = "Draft Board FTP Information";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textUsername;
		private System.Windows.Forms.TextBox textURI;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}