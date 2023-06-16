
namespace ProjectPOSsystem
{
    partial class frmPOS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.cmboSelect = new System.Windows.Forms.ComboBox();
            this.listQty = new System.Windows.Forms.NumericUpDown();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.lblTotalOwed = new System.Windows.Forms.Label();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.btnRemoveItemFromSale = new System.Windows.Forms.Button();
            this.btnConfirmEntryToSale = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.txtBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.listBoxSales = new System.Windows.Forms.ListBox();
            this.txtPOSSearch = new System.Windows.Forms.TextBox();
            this.richReceipt = new System.Windows.Forms.RichTextBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.pctrPOS = new System.Windows.Forms.PictureBox();
            this.btnSaleHistory = new System.Windows.Forms.Button();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listQty)).BeginInit();
            this.grpSales.SuspendLayout();
            this.pnlPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPOS)).BeginInit();
            this.grpReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboSelect
            // 
            this.cmboSelect.FormattingEnabled = true;
            this.cmboSelect.Location = new System.Drawing.Point(13, 49);
            this.cmboSelect.Name = "cmboSelect";
            this.cmboSelect.Size = new System.Drawing.Size(281, 29);
            this.cmboSelect.TabIndex = 0;
            // 
            // listQty
            // 
            this.listQty.Location = new System.Drawing.Point(301, 49);
            this.listQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listQty.Name = "listQty";
            this.listQty.Size = new System.Drawing.Size(83, 29);
            this.listQty.TabIndex = 1;
            this.listQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.Color.White;
            this.grpSales.Controls.Add(this.lblTotalOwed);
            this.grpSales.Controls.Add(this.btnNewSale);
            this.grpSales.Controls.Add(this.btnConfirmSale);
            this.grpSales.Controls.Add(this.lblAmountPaid);
            this.grpSales.Controls.Add(this.btnRemoveItemFromSale);
            this.grpSales.Controls.Add(this.btnConfirmEntryToSale);
            this.grpSales.Controls.Add(this.lblSearch);
            this.grpSales.Controls.Add(this.lblQuantity);
            this.grpSales.Controls.Add(this.lblSelectItem);
            this.grpSales.Controls.Add(this.txtBoxAmountPaid);
            this.grpSales.Controls.Add(this.listQty);
            this.grpSales.Controls.Add(this.listBoxSales);
            this.grpSales.Controls.Add(this.txtPOSSearch);
            this.grpSales.Controls.Add(this.cmboSelect);
            this.grpSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSales.Location = new System.Drawing.Point(17, 137);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(627, 486);
            this.grpSales.TabIndex = 2;
            this.grpSales.TabStop = false;
            // 
            // lblTotalOwed
            // 
            this.lblTotalOwed.AutoSize = true;
            this.lblTotalOwed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalOwed.Location = new System.Drawing.Point(13, 434);
            this.lblTotalOwed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalOwed.Name = "lblTotalOwed";
            this.lblTotalOwed.Size = new System.Drawing.Size(100, 21);
            this.lblTotalOwed.TabIndex = 15;
            this.lblTotalOwed.Text = "Total Owed:";
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnNewSale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSale.Location = new System.Drawing.Point(410, 359);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(187, 61);
            this.btnNewSale.TabIndex = 14;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewlSale_Click);
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnConfirmSale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmSale.Location = new System.Drawing.Point(411, 269);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(187, 64);
            this.btnConfirmSale.TabIndex = 7;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = false;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountPaid.Location = new System.Drawing.Point(330, 426);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(215, 21);
            this.lblAmountPaid.TabIndex = 13;
            this.lblAmountPaid.Text = "Amount Paid By Customer:";
            //this.lblAmountPaid.Click += new System.EventHandler(this.lblAmountPaid_Click);
            // 
            // btnRemoveItemFromSale
            // 
            this.btnRemoveItemFromSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnRemoveItemFromSale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItemFromSale.Location = new System.Drawing.Point(411, 177);
            this.btnRemoveItemFromSale.Name = "btnRemoveItemFromSale";
            this.btnRemoveItemFromSale.Size = new System.Drawing.Size(187, 64);
            this.btnRemoveItemFromSale.TabIndex = 6;
            this.btnRemoveItemFromSale.Text = "Remove Item \r\nFrom Sale";
            this.btnRemoveItemFromSale.UseVisualStyleBackColor = false;
            this.btnRemoveItemFromSale.Click += new System.EventHandler(this.btnRemoveItemFromSale_Click);
            // 
            // btnConfirmEntryToSale
            // 
            this.btnConfirmEntryToSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnConfirmEntryToSale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmEntryToSale.Location = new System.Drawing.Point(411, 84);
            this.btnConfirmEntryToSale.Name = "btnConfirmEntryToSale";
            this.btnConfirmEntryToSale.Size = new System.Drawing.Size(187, 67);
            this.btnConfirmEntryToSale.TabIndex = 5;
            this.btnConfirmEntryToSale.Text = "Add Item\r\nTo Sale";
            this.btnConfirmEntryToSale.UseVisualStyleBackColor = false;
            this.btnConfirmEntryToSale.Click += new System.EventHandler(this.btnConfirmEntryToSale_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(426, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(104, 21);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search Item:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(311, 17);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(41, 21);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Qty:";
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectItem.Location = new System.Drawing.Point(86, 17);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(99, 21);
            this.lblSelectItem.TabIndex = 10;
            this.lblSelectItem.Text = "Select Item:";
            // 
            // txtBoxAmountPaid
            // 
            this.txtBoxAmountPaid.Location = new System.Drawing.Point(301, 450);
            this.txtBoxAmountPaid.Name = "txtBoxAmountPaid";
            this.txtBoxAmountPaid.Size = new System.Drawing.Size(281, 29);
            this.txtBoxAmountPaid.TabIndex = 9;
            this.txtBoxAmountPaid.TextChanged += new System.EventHandler(this.txtBoxAmountPaid_TextChanged);
            // 
            // listBoxSales
            // 
            this.listBoxSales.FormattingEnabled = true;
            this.listBoxSales.ItemHeight = 21;
            this.listBoxSales.Location = new System.Drawing.Point(6, 80);
            this.listBoxSales.Name = "listBoxSales";
            this.listBoxSales.Size = new System.Drawing.Size(393, 340);
            this.listBoxSales.TabIndex = 3;
            //this.listBoxSales.SelectedIndexChanged += new System.EventHandler(this.listBoxSales_SelectedIndexChanged);
            // 
            // txtPOSSearch
            // 
            this.txtPOSSearch.Location = new System.Drawing.Point(410, 49);
            this.txtPOSSearch.Name = "txtPOSSearch";
            this.txtPOSSearch.Size = new System.Drawing.Size(188, 29);
            this.txtPOSSearch.TabIndex = 3;
            this.txtPOSSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtPOSSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown);
            // 
            // richReceipt
            // 
            this.richReceipt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richReceipt.Location = new System.Drawing.Point(0, 81);
            this.richReceipt.Name = "richReceipt";
            this.richReceipt.Size = new System.Drawing.Size(580, 405);
            this.richReceipt.TabIndex = 3;
            this.richReceipt.Text = "";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnRemoveItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.Location = new System.Drawing.Point(1020, 15);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(214, 101);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Stock\r\nItem";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnAddItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.Location = new System.Drawing.Point(800, 15);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(214, 101);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Stock\r\nItem";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pnlPOS
            // 
            this.pnlPOS.BackColor = System.Drawing.Color.White;
            this.pnlPOS.Controls.Add(this.pctrPOS);
            this.pnlPOS.Controls.Add(this.btnRemoveItem);
            this.pnlPOS.Controls.Add(this.btnSaleHistory);
            this.pnlPOS.Controls.Add(this.btnAddItem);
            this.pnlPOS.Controls.Add(this.grpReceipt);
            this.pnlPOS.Controls.Add(this.grpSales);
            this.pnlPOS.Location = new System.Drawing.Point(10, 8);
            this.pnlPOS.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(1260, 634);
            this.pnlPOS.TabIndex = 6;
            // 
            // pctrPOS
            // 
            this.pctrPOS.Image = ((System.Drawing.Image)(resources.GetObject("pctrPOS.Image")));
            this.pctrPOS.Location = new System.Drawing.Point(17, 15);
            this.pctrPOS.Name = "pctrPOS";
            this.pctrPOS.Size = new System.Drawing.Size(554, 101);
            this.pctrPOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrPOS.TabIndex = 17;
            this.pctrPOS.TabStop = false;
            // 
            // btnSaleHistory
            // 
            this.btnSaleHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnSaleHistory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaleHistory.Location = new System.Drawing.Point(577, 15);
            this.btnSaleHistory.Name = "btnSaleHistory";
            this.btnSaleHistory.Size = new System.Drawing.Size(217, 101);
            this.btnSaleHistory.TabIndex = 16;
            this.btnSaleHistory.Text = "Review\r\nSales";
            this.btnSaleHistory.UseVisualStyleBackColor = false;
            this.btnSaleHistory.Click += new System.EventHandler(this.btnSaleHistory_Click);
            // 
            // grpReceipt
            // 
            this.grpReceipt.BackColor = System.Drawing.Color.White;
            this.grpReceipt.Controls.Add(this.lblReceipt);
            this.grpReceipt.Controls.Add(this.richReceipt);
            this.grpReceipt.Location = new System.Drawing.Point(650, 137);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(580, 486);
            this.grpReceipt.TabIndex = 11;
            this.grpReceipt.TabStop = false;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReceipt.Location = new System.Drawing.Point(224, 25);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(98, 32);
            this.lblReceipt.TabIndex = 15;
            this.lblReceipt.Text = "Receipt";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1279, 649);
            this.Controls.Add(this.pnlPOS);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPOS";
            this.Text = "Total Owed:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPOS_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listQty)).EndInit();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.pnlPOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrPOS)).EndInit();
            this.grpReceipt.ResumeLayout(false);
            this.grpReceipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmboSelect;
        private System.Windows.Forms.NumericUpDown listQty;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.TextBox txtBoxAmountPaid;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Button btnRemoveItemFromSale;
        private System.Windows.Forms.ListBox listBoxSales;
        private System.Windows.Forms.Button btnConfirmEntryToSale;
        private System.Windows.Forms.TextBox txtPOSSearch;
        private System.Windows.Forms.RichTextBox richReceipt;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel pnlPOS;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.GroupBox grpReceipt;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnSaleHistory;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Label lblTotalOwed;
        private System.Windows.Forms.PictureBox pctrPOS;
    }
}

