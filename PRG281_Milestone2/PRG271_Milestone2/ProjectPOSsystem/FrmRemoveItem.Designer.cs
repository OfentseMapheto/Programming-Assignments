
namespace ProjectPOSsystem
{
    partial class FrmRemoveItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemoveItem));
            this.listRemoveItems = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pctrRemoveItem = new System.Windows.Forms.PictureBox();
            this.lblRemoveItem = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRemoveItem)).BeginInit();
            this.SuspendLayout();
            // 
            // listRemoveItems
            // 
            this.listRemoveItems.FormattingEnabled = true;
            this.listRemoveItems.ItemHeight = 15;
            this.listRemoveItems.Location = new System.Drawing.Point(15, 157);
            this.listRemoveItems.Margin = new System.Windows.Forms.Padding(2);
            this.listRemoveItems.Name = "listRemoveItems";
            this.listRemoveItems.Size = new System.Drawing.Size(258, 229);
            this.listRemoveItems.TabIndex = 0;
            this.listRemoveItems.SelectedIndexChanged += new System.EventHandler(this.listRemoveItems_SelectedIndexChanged);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnRemoveItem.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.Location = new System.Drawing.Point(288, 157);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(166, 100);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnCancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(288, 286);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 100);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.Controls.Add(this.pctrRemoveItem);
            this.pnlMain.Controls.Add(this.lblRemoveItem);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnRemoveItem);
            this.pnlMain.Controls.Add(this.listRemoveItems);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(469, 408);
            this.pnlMain.TabIndex = 3;
            //this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pctrRemoveItem
            // 
            this.pctrRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("pctrRemoveItem.Image")));
            this.pctrRemoveItem.Location = new System.Drawing.Point(15, 8);
            this.pctrRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.pctrRemoveItem.Name = "pctrRemoveItem";
            this.pctrRemoveItem.Size = new System.Drawing.Size(439, 107);
            this.pctrRemoveItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrRemoveItem.TabIndex = 17;
            this.pctrRemoveItem.TabStop = false;
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.AutoSize = true;
            this.lblRemoveItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRemoveItem.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.lblRemoveItem.Location = new System.Drawing.Point(87, 117);
            this.lblRemoveItem.MinimumSize = new System.Drawing.Size(100, 30);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(273, 35);
            this.lblRemoveItem.TabIndex = 16;
            this.lblRemoveItem.Text = "REMOVE ITEMS";
            // 
            // FrmRemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(493, 433);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRemoveItem";
            this.Text = "Remove Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRemoveItem_FormClosing);
            this.Load += new System.EventHandler(this.FrmRemoveItem_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRemoveItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRemoveItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRemoveItem;
        private System.Windows.Forms.PictureBox pctrRemoveItem;
    }
}