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
    public partial class frmPOS : Form
    {

        public frmPOS()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Open up the Add item form
            var formAdd = new FrmAddItem();
            formAdd.Owner = this;
            formAdd.Show();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //Open up the Remove item form
            var formRemove = new FrmRemoveItem();
            formRemove.Owner = this;
            formRemove.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the form loads we assign a timer to check the online time, we also create new instances of stockitems list and stock in sale list
            DateTime saleDate = new DateTime();
            decimal itemQuantity;
            decimal saleTotal = 0;
            List<int> stockItemLineQuantities = new List<int>(); ;
            List<StockItem> stockItemsInSale = new List<StockItem>();
            StockItem currentItem;
            string fileSelected = " ";
            string[] textFileContent;
            string itemNameToObject;
            decimal itemPriceToObject;
            int salesInstanceCount = new int();
            //Variables is a class, so need to refresh between form loads as data containing text files can change

            Variables.Items.Clear();
            Variables.CurrentSalesList.Clear();
            Variables.QtyItems.Clear();

            //Assigning filepath of Items textbox to fileselected 
            fileSelected = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                        + "\\Items\\ItemList.txt";
            
            //Try-Catch that tries to access the Items textfile
            try
            {
                textFileContent = File.ReadAllLines(fileSelected);
            }
            catch
            {
            //Creates file if none exists
                FileStream filestream = File.Create(fileSelected);
                filestream.Close();
            }
            textFileContent = File.ReadAllLines(fileSelected);

            //Iterates through the Items textfile and packs each item into the Items variable
            for (int i = 0; i <= textFileContent.Length - 1; i++)
            {
                for (int j = 0; j < textFileContent[i].Length - 1; j++)
                {
                    if (textFileContent[i].Substring(j, 1) == "=")
                    {
                        if (textFileContent[i].Substring(j + 1, 1) == "=")
                        {
                            itemNameToObject = textFileContent[i].Substring(0, j);
                            itemPriceToObject = Convert.ToDecimal(textFileContent[i].Substring(j + 2, textFileContent[i].Length - 1 - j - 1));
                            currentItem = new StockItem(itemNameToObject, itemPriceToObject);
                            Variables.Items.Add(currentItem);
                        }
                    }
                }
            }

            //New fileselected is assigned to the filepath of the Sales textbox
            fileSelected = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                                  + "\\Sales\\SalesList.txt";

            //Try-Catch tries to access the Sales textfile
            try
            {
                textFileContent = File.ReadAllLines(fileSelected);
            }
            catch
            {
                FileStream fs = File.Create(fileSelected);
                fs.Close();
            }
            textFileContent = File.ReadAllLines(fileSelected);

            //Iterates through sales textfile and seperates each string into its various parts, also adds items in stock to its compatible list
               salesInstanceCount = 0;
            for (int i = 0; i <= textFileContent.Length - 1; i++)
            {
                ///+++ indicates Saletotal
                if (textFileContent[i].Substring(0, 3) == "+++")
                {

                    saleTotal = Convert.ToDecimal(textFileContent[i].Substring(3, textFileContent[i].Length - 3));
                }
                //### indicates Saledate
                else if(textFileContent[i].Substring(0, 3) == "###")
                 {
                    saleDate = Convert.ToDateTime(textFileContent[i].Substring(3, textFileContent[i].Length - 3));
                    
                }
                //--- indicates end of sale
                else if (textFileContent[i] == "---")
                {
                    SetSaleHistory(stockItemsInSale, stockItemLineQuantities, saleTotal,saleDate);
                    stockItemsInSale = new List<StockItem>();
                    stockItemLineQuantities = new List<int>();
                    salesInstanceCount++;
                }
                else
                {
                   //== indicates the split between the item description and the item line quantities
                    for (int j = 0; j < textFileContent[i].Length - 1; j++)
                    {
                        if (textFileContent[i].Substring(j, 1) == "=")
                        {
                            if (textFileContent[i].Substring(j + 1, 1) == "=")
                            {
                                string sub = textFileContent[i].Substring(0, j);
                                itemNameToObject = textFileContent[i].Substring(0, j);
                                sub = textFileContent[i].Substring(j + 2, textFileContent[i].Length - j - 2);
                                itemQuantity = decimal.Parse(textFileContent[i].Substring(j + 2, textFileContent[i].Length - j - 2));

                                currentItem = new StockItem(itemNameToObject, itemQuantity);

                                stockItemsInSale.Add(currentItem);
                                stockItemLineQuantities.Add(Convert.ToInt32(itemQuantity));
                            }
                        }
                    }
                }
            }

          
            Variables.Items.Sort((x, y) => x.ItemDescription.CompareTo(y.ItemDescription));
            //Populates the select combobox with items stored
            foreach (var item in Variables.Items)
            {
                cmboSelect.Items.Add(item.ItemDescription);
            }
            cmboSelect.SelectedIndex = 0;
        }

        //Each sale gets added to the sale history variable
        static void SetSaleHistory(List<StockItem> stockinsale, List<int> amountofstock, decimal totalofsale, DateTime dateofsale)
        {
            SaleInstance CurrentSaleInstance;
            CurrentSaleInstance = new SaleInstance(stockinsale, amountofstock, totalofsale,dateofsale);
            Variables.SaleHistory.Add(CurrentSaleInstance);
        }

        //Making sure that the user wants to confirm this sale
        private bool ConfirmSale()
        {
            if (MessageBox.Show("Confirm Sale! \n Cannot be undone!", "Confirm Sale?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                return true;
            }
            else return false;
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            int LastSaleHistory;
            int counter = 0;
            string[] RichTextBoxLines;

            //Add sale to sales history
            SaleInstance currSale;
            currSale = new SaleInstance(Variables.CurrentSalesList, Variables.QtyItems, Variables.SalesTotal, DateTime.Now);
       
            Variables.SaleHistory.Add(currSale);
            LastSaleHistory = Variables.SaleHistory.Count() - 1;
            counter = Variables.itemLineTotals.Count;
            RichTextBoxLines = new string[counter + 3];
            
            // counter ensures that lines are printed consecutively
            counter = 0;

            if (ConfirmSale())
            {
                foreach (var item in Variables.CurrentSalesList)
            {
                if (counter == 0)
                {
                    RichTextBoxLines[counter] = "BC-Tuckshop\n" + DateTime.Now + "\n___________________________________\n";
                    RichTextBoxLines[counter] += item.ItemDescription + "\n R " + Convert.ToInt32(item.ItemPrice) + " x " +
                  Convert.ToInt32(Variables.itemLineTotals[counter] / item.ItemPrice) + " = R " + Variables.itemLineTotals[counter] +
                  "\n___________________________________";

                }
                else
                {
                    RichTextBoxLines[counter] = item.ItemDescription + "\n R " + Convert.ToInt32(item.ItemPrice) + " x " +
                  Convert.ToInt32(Variables.itemLineTotals[counter] / item.ItemPrice) + " = R " + Variables.itemLineTotals[counter] +
                  "\n___________________________________";
                }
                counter++;
            }

            RichTextBoxLines[counter] = "Grand Total:" + " R " + Convert.ToString(Variables.SalesTotal);
            counter++;
            RichTextBoxLines[counter] = "Paid: R " + txtBoxAmountPaid.Text;
            counter++;
            RichTextBoxLines[counter] = "Change Due: R " + Convert.ToString(Convert.ToDecimal(txtBoxAmountPaid.Text) - Variables.SalesTotal);
            richReceipt.Lines = RichTextBoxLines;

                // Global variables are linked to object currSale, so new instances of global variables are created
        Variables.CurrentSalesList = new List<StockItem>();
             Variables.QtyItems = new List<int>();
             Variables.SalesTotal = new decimal();
                // disable sale controls until new sale button is clicked, promotes data integrity and system stability
                btnConfirmEntryToSale.Enabled = false;
                btnRemoveItemFromSale.Enabled = false;
                btnConfirmSale.Enabled = false;
            }
      
            else
            {
                //do nothing as user doesn't want to finalise sale
            }
        }

        //Adds one item line to the sale in progress
        private void btnConfirmEntryToSale_Click(object sender, EventArgs e)
        {
            string comboItemDescription;
            int itemQuantity;
            StockItem currentItem;
            comboItemDescription = cmboSelect.SelectedItem.ToString();
            itemQuantity = Convert.ToInt32(listQty.Value);
            Variables.QtyItems.Add(itemQuantity);
           
            //find current Item floor price in class objects
            foreach (var item in Variables.Items)
                {
                    if (item.ItemDescription == comboItemDescription)
                    {
                        Variables.tempDecimal = item.ItemPrice;

                    }
                }
                Variables.itemLineTotals.Add(Variables.tempDecimal * itemQuantity);
                Variables.SalesTotal += Variables.tempDecimal * itemQuantity;
                currentItem = new StockItem(comboItemDescription, Variables.tempDecimal);
                Variables.CurrentSalesList.Add(currentItem);

                int currentListPos = 0;
           
                listBoxSales.Items.Clear();

            //add items in sale to listbox
                foreach (var item in Variables.CurrentSalesList)
                {
                    listBoxSales.Items.Add(item.ItemDescription + "     x" + Variables.QtyItems[currentListPos]
                                                                     + " = R" + item.ItemPrice * Variables.QtyItems[currentListPos]);
                    currentListPos++;
                }
                lblTotalOwed.Text = "Total: " + Variables.SalesTotal;
                txtPOSSearch.Text = "";
            //confirm sale button only activates when payment is made
            try
            {
                if (Variables.CurrentSalesList.Count > 0 && decimal.Parse(txtBoxAmountPaid.Text) >= Variables.SalesTotal)
                {
                    btnConfirmSale.Enabled = true;
                }
            }
            catch
            {
                btnConfirmSale.Enabled = false;
            }

        }
        //searches for items and updates the combobox with results
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchString = "";
            searchString = txtPOSSearch.Text;

            cmboSelect.Items.Clear();
            //combobox cannot select no items, try tests that items exist 
            try
            {
                foreach (var item in Variables.Items)
                {
                    if (item.ItemDescription.ToLower().Contains(searchString.ToLower()))
                    {
                        cmboSelect.Items.Add(item.ItemDescription);
                    }
                }
                cmboSelect.SelectedIndex = 0;
            }
            catch
            {
                // if no items exist, display message
                MessageBox.Show("This Item does not exist in the Stock List ", "OK!");
                searchString = searchString.Substring(0, searchString.Length - 1);
                txtPOSSearch.Text = searchString;
                txtPOSSearch.Focus();
                txtPOSSearch.SelectionStart = txtPOSSearch.Text.Length;
            }
        }

        //removes the selected combobox item from the sale in progress
        private void btnRemoveItemFromSale_Click(object sender, EventArgs e)
        {
            //ensure that the user selects an item before trying to remove
            try
            {
                int currentListPos = 0;
                int index;
                index = listBoxSales.SelectedIndex;
                Variables.SalesTotal -= Variables.itemLineTotals[index];
                Variables.itemLineTotals.RemoveAt(index);
                Variables.CurrentSalesList.RemoveAt(index);
                Variables.QtyItems.RemoveAt(index);
                listBoxSales.Items.Clear();
                foreach (var item in Variables.CurrentSalesList)
                {
                    listBoxSales.Items.Add(item.ItemDescription + "     x" + Variables.QtyItems[currentListPos]
                                                                     + " = R" + item.ItemPrice * Variables.QtyItems[currentListPos]);
                    currentListPos++;
                }
                lblTotalOwed.Text = "Total: " + Variables.SalesTotal;
            }
            catch
            {
                MessageBox.Show("Please select an item before trying to remove", "OK!");
            }
            //ensures that the payment has the correct format and amount before finalising sale
            try
            {
                if (Variables.CurrentSalesList.Count > 0 && decimal.Parse(txtBoxAmountPaid.Text) >= Variables.SalesTotal)
                {
                    btnConfirmSale.Enabled = true;
                }
            }
            catch
            {
                btnConfirmSale.Enabled = false;
            }

        }

        //Clears the form for a new sale when sale is interrupted
        private void btnNewlSale_Click(object sender, EventArgs e)
        {
            lblTotalOwed.Text = "";
            // new instances of global variables to detach current object from variables
            Variables.QtyItems =new List<int>();
            Variables.itemLineTotals= new List<decimal>();
            Variables.SalesTotal = 0;
            Variables.tempDecimal = 0;
            Variables.CurrentSalesList = new List<StockItem>();
            listBoxSales.Items.Clear();
            txtBoxAmountPaid.Text = "";
            richReceipt.Text = "";
            btnRemoveItemFromSale.Enabled = true;
            btnAddItem.Enabled = true;
            btnConfirmEntryToSale.Enabled = true;

        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // enter on search adds the item quickly
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirmEntryToSale.PerformClick();
            }
        }
        //tests if the payment amount is in correct format and the right amount 
        private void txtBoxAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Variables.CurrentSalesList.Count > 0 && decimal.Parse(txtBoxAmountPaid.Text) >= Variables.SalesTotal)
                {
                    btnConfirmSale.Enabled = true;
                }
            }
            catch
            {
                btnConfirmSale.Enabled = false;
            }

        }
        //opens sale history form with frmPOS as owner so frmPOS controls can update from sale history
        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            
            var viewSales = new frmSaleHistory();
            viewSales.Owner = this;
           viewSales.Show();

        }

        //writes updated Items and SaleHistory to the appropraite textfiles
        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Text File example for unit testing
            /*
            Simba Barbeque 250g==2
            Remington Gold 1pack==1
            +++27.00
            ---
            Dragon Energy 500ml==1
            +++10.00
            ---
            */

            string[] stringToSalesFile;
            string[] stringToItemsFile;
            int linePosition = 0;
            int itemCount;
            string stockItem;
            int itemLineQuantity;
            int writeLength = 0;
            string fileSelected;

            Variables.SalesTotal = 0;
            fileSelected = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                                                              + "\\Sales\\SalesList.txt";

            SaleInstance currentSale;
            //count lines to add to stringToSalesFile, saves resources and prevents errors
            for (int i = 0; i < Variables.SaleHistory.Count; i++)
            {
                itemCount = 0;
                currentSale = new SaleInstance(Variables.SaleHistory[i].StockItemsSoldField, Variables.SaleHistory[i].StockItemsTotalField, 
                                                                    Variables.SaleHistory[i].SaleTotalField,Variables.SaleHistory[i].SaleDateField);
                for (int j = 0; j < currentSale.StockItemsSoldField.Count; j++)
                {
                    writeLength++;
                }
                writeLength += 3;
            }
            //declare stringToSalesFile with correct length
            stringToSalesFile = new string[writeLength];

            for (int i = 0; i < Variables.SaleHistory.Count; i++)
            {
                itemCount = 0;
                currentSale = new SaleInstance(Variables.SaleHistory[i].StockItemsSoldField, Variables.SaleHistory[i].StockItemsTotalField,
                                                                    Variables.SaleHistory[i].SaleTotalField,Variables.SaleHistory[i].SaleDateField);
                for (int j = 0; j < currentSale.StockItemsSoldField.Count; j++)
                {
                    stockItem = Convert.ToString(currentSale.StockItemsSoldField[j].ItemDescription);
                    itemLineQuantity = Convert.ToInt32(currentSale.StockItemsTotalField[itemCount]);
                    stringToSalesFile[linePosition] = stockItem + "==" + itemLineQuantity;
                    linePosition++;
                    itemCount++;
                }
                stringToSalesFile[linePosition] = "###" + currentSale.SaleDateField;
                linePosition++;
                stringToSalesFile[linePosition] = "+++" + currentSale.SaleTotalField;
                linePosition++;
                stringToSalesFile[linePosition] = "---";
                linePosition++;
            }

            File.WriteAllLinesAsync(fileSelected, stringToSalesFile);

            //Text File example
            /*
                Simba Barbeque 250g==6.00
                Dragon Energy 500ml==10.00
                Remington Gold 1pack==15.00
            */

            writeLength = 0;
            foreach (var item in Variables.Items)
            {
                writeLength++;
            }
            fileSelected = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                                                                + "\\Items\\ItemList.txt";
            stringToItemsFile = new string[writeLength];
            linePosition = 0;
            foreach (var item in Variables.Items)
            {
                stringToItemsFile[linePosition] = item.ItemDescription + "==" + item.ItemPrice;
                linePosition++;
            }
            File.WriteAllLinesAsync(fileSelected, stringToItemsFile);

        }
    }
}
