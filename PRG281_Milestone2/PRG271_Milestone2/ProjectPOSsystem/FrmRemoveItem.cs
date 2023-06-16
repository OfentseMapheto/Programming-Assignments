using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectPOSsystem
{
    
    public partial class FrmRemoveItem : Form
    {
        //public variable to test for  listbox selection, try catch fails to stop null exeption
        public class testInput
        {
            public static int listRemovePosition =-1;
        }
        public FrmRemoveItem()
        {
            InitializeComponent();
        }

        private void FrmRemoveItem_Load(object sender, EventArgs e)
        {
            //Importing image to picturebox

            //Displays list of current items
            foreach (var item in Variables.Items)
            {
                listRemoveItems.Items.Add(item.ItemDescription);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Depending on what item the user picks the item is removed from all the lists it is stored in 
            string currentItem ="";
     
            bool itemFound = false;

            if (testInput.listRemovePosition ==0)
            {
                currentItem = listRemoveItems.SelectedItem.ToString();

                foreach (var item in Variables.Items)
                {

                    if (item.ItemDescription == currentItem)
                    {
                        itemFound = true;
                        break;
                    }
                    testInput.listRemovePosition++;
                }
                if (itemFound)
                {
                    Variables.Items.RemoveAt(testInput.listRemovePosition);
                    listRemoveItems.Items.Clear();

                    Variables.Items.Sort((x, y) => x.ItemDescription.CompareTo(y.ItemDescription));
                    foreach (var item in Variables.Items)
                    {
                        listRemoveItems.Items.Add(item.ItemDescription);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Please Select an Item before trying to remove", "OK");
            }
            testInput.listRemovePosition = -1;
        
        }

        //Closes form
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Repopulates variables and item select
        private void FrmRemoveItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as frmPOS).cmboSelect.Items.Clear();
            foreach (var item in Variables.Items)
            {
                (this.Owner as frmPOS).cmboSelect.Items.Add(item.ItemDescription);
            }
             (this.Owner as frmPOS).cmboSelect.SelectedIndex = 0;
        }

        private void listRemoveItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            testInput.listRemovePosition = 0;
        }
    }
}
