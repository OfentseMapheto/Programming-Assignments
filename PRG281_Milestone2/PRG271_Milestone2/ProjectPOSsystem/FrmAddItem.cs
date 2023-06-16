using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPOSsystem
{
    public partial class FrmAddItem : Form
    {
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            decimal price;
            
            try
            {
                name = txtItemDescription.Text;
                price = Math.Round(decimal.Parse(txtRetailPrice.Text), 2);
                StockItem addItem = new StockItem(name, price);
                Variables.Items.Add(addItem);
                Variables.Items.Sort((x, y) => x.ItemDescription.CompareTo(y.ItemDescription));
            }
            catch 
            {
                MessageBox.Show("Price needs to be in decimal format eg. 19.99");

            }
         
        
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmPOS).cmboSelect.Items.Clear();
            foreach (var item in Variables.Items)
            {
                (this.Owner as frmPOS).cmboSelect.Items.Add(item.ItemDescription);
            }
             (this.Owner as frmPOS).cmboSelect.SelectedIndex = 0;
        }

        private void FrmAddItem_Load(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxItemDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ensuring that special characters arent typed
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
