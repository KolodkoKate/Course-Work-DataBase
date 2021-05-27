namespace E_Storage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.passwordLb = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameErrLbl = new System.Windows.Forms.Label();
            this.passwordErrLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.passwordErrLbl);
            this.leftPanel.Controls.Add(this.usernameErrLbl);
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.passwordTb);
            this.leftPanel.Controls.Add(this.usernameTb);
            this.leftPanel.Controls.Add(this.passwordLb);
            this.leftPanel.Controls.Add(this.usernameLbl);
            this.leftPanel.Size = new System.Drawing.Size(309, 738);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordLb, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordErrLbl, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Size = new System.Drawing.Size(892, 738);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLb.ForeColor = System.Drawing.Color.White;
            this.passwordLb.Location = new System.Drawing.Point(17, 456);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(112, 32);
            this.passwordLb.TabIndex = 4;
            this.passwordLb.Text = "Password";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(16, 337);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(122, 32);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username";
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTb.Location = new System.Drawing.Point(23, 372);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(261, 38);
            this.usernameTb.TabIndex = 5;
            this.usernameTb.TextChanged += new System.EventHandler(this.usernameTb_TextChanged);
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTb.Location = new System.Drawing.Point(22, 491);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(262, 38);
            this.passwordTb.TabIndex = 6;
            this.passwordTb.UseSystemPasswordChar = true;
            this.passwordTb.TextChanged += new System.EventHandler(this.passwordTb_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(23, 607);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(261, 62);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1205, 812);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // usernameErrLbl
            // 
            this.usernameErrLbl.AutoSize = true;
            this.usernameErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.usernameErrLbl.Location = new System.Drawing.Point(131, 337);
            this.usernameErrLbl.Name = "usernameErrLbl";
            this.usernameErrLbl.Size = new System.Drawing.Size(25, 32);
            this.usernameErrLbl.TabIndex = 40;
            this.usernameErrLbl.Text = "*";
            this.usernameErrLbl.Visible = false;
            // 
            // passwordErrLbl
            // 
            this.passwordErrLbl.AutoSize = true;
            this.passwordErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.passwordErrLbl.Location = new System.Drawing.Point(122, 456);
            this.passwordErrLbl.Name = "passwordErrLbl";
            this.passwordErrLbl.Size = new System.Drawing.Size(25, 32);
            this.passwordErrLbl.TabIndex = 41;
            this.passwordErrLbl.Text = "*";
            this.passwordErrLbl.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "Login";
            this.Text = "Login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label passwordErrLbl;
        protected System.Windows.Forms.Label usernameErrLbl;
    }
}