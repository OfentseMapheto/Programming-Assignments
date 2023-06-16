
namespace ProjectPOSsystem
{
    partial class FrmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddItem));
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pctrAddItem = new System.Windows.Forms.PictureBox();
            this.lblAddItems = new System.Windows.Forms.Label();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemDescription.Location = new System.Drawing.Point(115, 142);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemDescription.MinimumSize = new System.Drawing.Size(290, 50);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.PlaceholderText = "Enter Item Description";
            this.txtItemDescription.Size = new System.Drawing.Size(290, 43);
            this.txtItemDescription.TabIndex = 2;
            this.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxItemDescription_KeyPress);
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRetailPrice.Location = new System.Drawing.Point(115, 181);
            this.txtRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetailPrice.MinimumSize = new System.Drawing.Size(290, 50);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.PlaceholderText = "Enter Item Retail Price";
            this.txtRetailPrice.Size = new System.Drawing.Size(290, 43);
            this.txtRetailPrice.TabIndex = 3;
            this.txtRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnAccept.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(258, 221);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(160, 49);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.btnCancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(94, 221);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.White;
            this.pnlAdd.Controls.Add(this.pctrAddItem);
            this.pnlAdd.Controls.Add(this.lblAddItems);
            this.pnlAdd.Controls.Add(this.btnCancel);
            this.pnlAdd.Controls.Add(this.btnAccept);
            this.pnlAdd.Controls.Add(this.txtRetailPrice);
            this.pnlAdd.Controls.Add(this.txtItemDescription);
            this.pnlAdd.Location = new System.Drawing.Point(9, 8);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(512, 279);
            this.pnlAdd.TabIndex = 6;
            this.pnlAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pctrAddItem
            // 
            this.pctrAddItem.Image = ((System.Drawing.Image)(resources.GetObject("pctrAddItem.Image")));
            this.pctrAddItem.Location = new System.Drawing.Point(2, 2);
            this.pctrAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.pctrAddItem.Name = "pctrAddItem";
            this.pctrAddItem.Size = new System.Drawing.Size(508, 104);
            this.pctrAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrAddItem.TabIndex = 20;
            this.pctrAddItem.TabStop = false;
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAddItems.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.lblAddItems.Location = new System.Drawing.Point(167, 107);
            this.lblAddItems.MinimumSize = new System.Drawing.Size(100, 30);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(180, 35);
            this.lblAddItems.TabIndex = 19;
            this.lblAddItems.Text = "ADD ITEM";
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(528, 294);
            this.Controls.Add(this.pnlAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAddItem";
            this.Text = "Add Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddItem_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddItem_Load);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.PictureBox pctrAddItem;
    }
}