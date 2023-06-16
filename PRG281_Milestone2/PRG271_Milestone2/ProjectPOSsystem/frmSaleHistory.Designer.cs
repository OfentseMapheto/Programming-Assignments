
namespace ProjectPOSsystem
{
    partial class frmSaleHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleHistory));
            this.richTextBoxSaleHistoryDisplay = new System.Windows.Forms.RichTextBox();
            this.btnCloseSaleHistory = new System.Windows.Forms.Button();
            this.pctrHistory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxSaleHistoryDisplay
            // 
            this.richTextBoxSaleHistoryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSaleHistoryDisplay.Location = new System.Drawing.Point(14, 76);
            this.richTextBoxSaleHistoryDisplay.Name = "richTextBoxSaleHistoryDisplay";
            this.richTextBoxSaleHistoryDisplay.Size = new System.Drawing.Size(505, 394);
            this.richTextBoxSaleHistoryDisplay.TabIndex = 0;
            this.richTextBoxSaleHistoryDisplay.Text = "";
            // 
            // btnCloseSaleHistory
            // 
            this.btnCloseSaleHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnCloseSaleHistory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseSaleHistory.Location = new System.Drawing.Point(172, 476);
            this.btnCloseSaleHistory.Name = "btnCloseSaleHistory";
            this.btnCloseSaleHistory.Size = new System.Drawing.Size(170, 45);
            this.btnCloseSaleHistory.TabIndex = 1;
            this.btnCloseSaleHistory.Text = "Close";
            this.btnCloseSaleHistory.UseVisualStyleBackColor = false;
            this.btnCloseSaleHistory.Click += new System.EventHandler(this.btnCloseSaleHistory_Click);
            // 
            // pctrHistory
            // 
            this.pctrHistory.Location = new System.Drawing.Point(115, 7);
            this.pctrHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctrHistory.Name = "pctrHistory";
            this.pctrHistory.Size = new System.Drawing.Size(300, 64);
            this.pctrHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHistory.TabIndex = 2;
            this.pctrHistory.TabStop = false;
            // 
            // frmSaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 533);
            this.Controls.Add(this.pctrHistory);
            this.Controls.Add(this.btnCloseSaleHistory);
            this.Controls.Add(this.richTextBoxSaleHistoryDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaleHistory";
            this.Text = "Sale History";
            this.Load += new System.EventHandler(this.frmSaleHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSaleHistoryDisplay;
        private System.Windows.Forms.Button btnCloseSaleHistory;
        private System.Windows.Forms.PictureBox pctrHistory;
    }
}