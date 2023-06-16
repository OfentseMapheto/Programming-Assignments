namespace ProjectPOSsystem
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.pctrRegister = new System.Windows.Forms.PictureBox();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnRegister.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(184, 212);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(137, 38);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnBack.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(32, 212);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 37);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegisterPassword.Location = new System.Drawing.Point(32, 170);
            this.txtRegisterPassword.MinimumSize = new System.Drawing.Size(290, 50);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PlaceholderText = "Pick a Password";
            this.txtRegisterPassword.Size = new System.Drawing.Size(290, 43);
            this.txtRegisterPassword.TabIndex = 9;
            this.txtRegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtRegisterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegisterPassword_KeyPress);
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegisterUsername.Location = new System.Drawing.Point(32, 127);
            this.txtRegisterUsername.MinimumSize = new System.Drawing.Size(290, 50);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.PlaceholderText = "Pick a Username";
            this.txtRegisterUsername.Size = new System.Drawing.Size(290, 43);
            this.txtRegisterUsername.TabIndex = 8;
            this.txtRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            this.txtRegisterUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegisterUsername_KeyPress);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRegister.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.lblRegister.Location = new System.Drawing.Point(83, 92);
            this.lblRegister.MinimumSize = new System.Drawing.Size(100, 30);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(191, 35);
            this.lblRegister.TabIndex = 14;
            this.lblRegister.Text = "REGISTER";
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.White;
            this.pnlRegister.Controls.Add(this.pctrRegister);
            this.pnlRegister.Controls.Add(this.txtRegisterUsername);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.btnBack);
            this.pnlRegister.Location = new System.Drawing.Point(9, 8);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(352, 260);
            this.pnlRegister.TabIndex = 17;
            // 
            // pctrRegister
            // 
            this.pctrRegister.Image = ((System.Drawing.Image)(resources.GetObject("pctrRegister.Image")));
            this.pctrRegister.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctrRegister.InitialImage")));
            this.pctrRegister.Location = new System.Drawing.Point(2, 2);
            this.pctrRegister.Margin = new System.Windows.Forms.Padding(2);
            this.pctrRegister.Name = "pctrRegister";
            this.pctrRegister.Size = new System.Drawing.Size(348, 89);
            this.pctrRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrRegister.TabIndex = 15;
            this.pctrRegister.TabStop = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(370, 276);
            this.Controls.Add(this.pnlRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegister";
            this.Text = "Register";
            //this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pctrRegister;
    }
}