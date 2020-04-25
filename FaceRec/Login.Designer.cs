namespace MultiFaceRec
{
    partial class Login
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
            this.txbId = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPass = new System.Windows.Forms.Label();
            this.txbPw = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbId
            // 
            this.txbId.AcceptsTab = true;
            this.txbId.AllowDrop = true;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(145, 39);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(158, 26);
            this.txbId.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.AllowDrop = true;
            this.lbLogin.AutoSize = true;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(100, 45);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(30, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "ID:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(72, 146);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(48, 93);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 20);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "Password:";
            // 
            // txbPw
            // 
            this.txbPw.AcceptsTab = true;
            this.txbPw.AllowDrop = true;
            this.txbPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPw.Location = new System.Drawing.Point(145, 87);
            this.txbPw.Name = "txbPw";
            this.txbPw.PasswordChar = '*';
            this.txbPw.Size = new System.Drawing.Size(158, 26);
            this.txbPw.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(215, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 216);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbPw);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txbId);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txbPw;
        private System.Windows.Forms.Button btnCancel;
    }
}