namespace E_Storage
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.databaseTb = new System.Windows.Forms.TextBox();
            this.serverTb = new System.Windows.Forms.TextBox();
            this.databaseLbl = new System.Windows.Forms.Label();
            this.serverLbl = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.userIDTb = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userIDLbl = new System.Windows.Forms.Label();
            this.isCb = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.isCb);
            this.leftPanel.Controls.Add(this.passwordTb);
            this.leftPanel.Controls.Add(this.userIDTb);
            this.leftPanel.Controls.Add(this.passwordLbl);
            this.leftPanel.Controls.Add(this.userIDLbl);
            this.leftPanel.Controls.Add(this.databaseTb);
            this.leftPanel.Controls.Add(this.serverTb);
            this.leftPanel.Controls.Add(this.databaseLbl);
            this.leftPanel.Controls.Add(this.serverLbl);
            this.leftPanel.Size = new System.Drawing.Size(309, 805);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIDLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIDTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCb, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Size = new System.Drawing.Size(892, 805);
            this.rightPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // databaseTb
            // 
            this.databaseTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseTb.Location = new System.Drawing.Point(21, 363);
            this.databaseTb.MaxLength = 50;
            this.databaseTb.Name = "databaseTb";
            this.databaseTb.Size = new System.Drawing.Size(262, 38);
            this.databaseTb.TabIndex = 10;
            // 
            // serverTb
            // 
            this.serverTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverTb.Location = new System.Drawing.Point(22, 262);
            this.serverTb.MaxLength = 50;
            this.serverTb.Name = "serverTb";
            this.serverTb.Size = new System.Drawing.Size(261, 38);
            this.serverTb.TabIndex = 9;
            // 
            // databaseLbl
            // 
            this.databaseLbl.AutoSize = true;
            this.databaseLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseLbl.ForeColor = System.Drawing.Color.White;
            this.databaseLbl.Location = new System.Drawing.Point(16, 328);
            this.databaseLbl.Name = "databaseLbl";
            this.databaseLbl.Size = new System.Drawing.Size(113, 32);
            this.databaseLbl.TabIndex = 8;
            this.databaseLbl.Text = "Database";
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverLbl.ForeColor = System.Drawing.Color.White;
            this.serverLbl.Location = new System.Drawing.Point(15, 227);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(82, 32);
            this.serverLbl.TabIndex = 7;
            this.serverLbl.Text = "Server";
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTb.Location = new System.Drawing.Point(21, 563);
            this.passwordTb.MaxLength = 30;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(262, 38);
            this.passwordTb.TabIndex = 14;
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // userIDTb
            // 
            this.userIDTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userIDTb.Location = new System.Drawing.Point(22, 463);
            this.userIDTb.MaxLength = 30;
            this.userIDTb.Name = "userIDTb";
            this.userIDTb.Size = new System.Drawing.Size(261, 38);
            this.userIDTb.TabIndex = 13;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(16, 528);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(112, 32);
            this.passwordLbl.TabIndex = 12;
            this.passwordLbl.Text = "Password";
            // 
            // userIDLbl
            // 
            this.userIDLbl.AutoSize = true;
            this.userIDLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userIDLbl.ForeColor = System.Drawing.Color.White;
            this.userIDLbl.Location = new System.Drawing.Point(15, 428);
            this.userIDLbl.Name = "userIDLbl";
            this.userIDLbl.Size = new System.Drawing.Size(92, 32);
            this.userIDLbl.TabIndex = 11;
            this.userIDLbl.Text = "User ID";
            // 
            // isCb
            // 
            this.isCb.AutoSize = true;
            this.isCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isCb.ForeColor = System.Drawing.Color.White;
            this.isCb.Location = new System.Drawing.Point(21, 619);
            this.isCb.Name = "isCb";
            this.isCb.Size = new System.Drawing.Size(239, 36);
            this.isCb.TabIndex = 15;
            this.isCb.Text = "Integrated Security";
            this.isCb.UseVisualStyleBackColor = true;
            this.isCb.CheckedChanged += new System.EventHandler(this.isCb_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(22, 671);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(261, 62);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1205, 843);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(45, 50);
            this.backBtn.TabIndex = 5;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 805);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.CheckBox isCb;
        protected System.Windows.Forms.TextBox passwordTb;
        protected System.Windows.Forms.TextBox userIDTb;
        protected System.Windows.Forms.Label passwordLbl;
        protected System.Windows.Forms.Label userIDLbl;
        protected System.Windows.Forms.TextBox databaseTb;
        protected System.Windows.Forms.TextBox serverTb;
        protected System.Windows.Forms.Label databaseLbl;
        protected System.Windows.Forms.Label serverLbl;
        protected System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Button backBtn;
    }
}