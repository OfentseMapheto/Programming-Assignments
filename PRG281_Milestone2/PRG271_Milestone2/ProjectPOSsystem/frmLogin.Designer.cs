namespace ProjectPOSsystem
{
    partial class frmLoginRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginRegister));
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pctrUser = new System.Windows.Forms.PictureBox();
            this.pctrPassword = new System.Windows.Forms.PictureBox();
            this.pctrTouchID = new System.Windows.Forms.PictureBox();
            this.lblTouch = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pctrLogin = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrTouchID)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtLoginPassword.Location = new System.Drawing.Point(104, 214);
            this.txtLoginPassword.MinimumSize = new System.Drawing.Size(290, 50);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.PlaceholderText = "Enter Password";
            this.txtLoginPassword.Size = new System.Drawing.Size(290, 43);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(76, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(290, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginUsername.Location = new System.Drawing.Point(104, 155);
            this.txtLoginUsername.MinimumSize = new System.Drawing.Size(290, 50);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.PlaceholderText = "Enter Username";
            this.txtLoginUsername.Size = new System.Drawing.Size(290, 43);
            this.txtLoginUsername.TabIndex = 1;
            this.txtLoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtLoginUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLoginUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginUsername_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnRegister.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(76, 335);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(290, 41);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.lblLogin.Location = new System.Drawing.Point(163, 113);
            this.lblLogin.MinimumSize = new System.Drawing.Size(100, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(124, 35);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            // 
            // pctrUser
            // 
            this.pctrUser.Image = ((System.Drawing.Image)(resources.GetObject("pctrUser.Image")));
            this.pctrUser.Location = new System.Drawing.Point(55, 155);
            this.pctrUser.Name = "pctrUser";
            this.pctrUser.Size = new System.Drawing.Size(43, 37);
            this.pctrUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrUser.TabIndex = 7;
            this.pctrUser.TabStop = false;
            // 
            // pctrPassword
            // 
            this.pctrPassword.Image = ((System.Drawing.Image)(resources.GetObject("pctrPassword.Image")));
            this.pctrPassword.Location = new System.Drawing.Point(52, 214);
            this.pctrPassword.Name = "pctrPassword";
            this.pctrPassword.Size = new System.Drawing.Size(45, 37);
            this.pctrPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrPassword.TabIndex = 9;
            this.pctrPassword.TabStop = false;
            // 
            // pctrTouchID
            // 
            this.pctrTouchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrTouchID.Image = ((System.Drawing.Image)(resources.GetObject("pctrTouchID.Image")));
            this.pctrTouchID.Location = new System.Drawing.Point(179, 382);
            this.pctrTouchID.Name = "pctrTouchID";
            this.pctrTouchID.Size = new System.Drawing.Size(85, 84);
            this.pctrTouchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrTouchID.TabIndex = 10;
            this.pctrTouchID.TabStop = false;
            this.pctrTouchID.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // lblTouch
            // 
            this.lblTouch.AutoSize = true;
            this.lblTouch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTouch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTouch.Location = new System.Drawing.Point(141, 468);
            this.lblTouch.Name = "lblTouch";
            this.lblTouch.Size = new System.Drawing.Size(149, 21);
            this.lblTouch.TabIndex = 11;
            this.lblTouch.Text = "Login With Touch ID";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.pctrLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.lblTouch);
            this.pnlLogin.Controls.Add(this.pctrTouchID);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.pctrPassword);
            this.pnlLogin.Controls.Add(this.pctrUser);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.txtLoginUsername);
            this.pnlLogin.Location = new System.Drawing.Point(26, 8);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(444, 515);
            this.pnlLogin.TabIndex = 14;
            //this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pctrLogin
            // 
            this.pctrLogin.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogin.Image")));
            this.pctrLogin.Location = new System.Drawing.Point(14, 8);
            this.pctrLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctrLogin.Name = "pctrLogin";
            this.pctrLogin.Size = new System.Drawing.Size(418, 93);
            this.pctrLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrLogin.TabIndex = 12;
            this.pctrLogin.TabStop = false;
            // 
            // frmLoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(494, 530);
            this.Controls.Add(this.pnlLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginRegister";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrTouchID)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pctrUser;
        private System.Windows.Forms.PictureBox pctrPassword;
        private System.Windows.Forms.PictureBox pctrTouchID;
        private System.Windows.Forms.Label lblTouch;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pctrLogin;
    }
}