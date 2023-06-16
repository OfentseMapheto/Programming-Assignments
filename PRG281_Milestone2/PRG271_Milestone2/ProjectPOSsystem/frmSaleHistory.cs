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
    public partial class frmSaleHistory : Form
    {
        public frmSaleHistory()
        {
            InitializeComponent();
        }

        private void frmSaleHistory_Load(object sender, EventArgs e)
        {
            string[] stringToRichTextBox;

            int lineposition = 0;
            int itemcount;
            string stockitem;
            int stockitemtotal;
            int writelength = 0;
            decimal totalrevenue =0;

            //import image to picture box
            pctrHistory.Image = Image.FromFile(Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                      + "\\Images\\BCPOSLogo.png");

            SaleInstance currentsale;
            for (int i = 0; i < Variables.SaleHistory.Count; i++)
            {
                itemcount = 0;
                currentsale = new SaleInstance(Variables.SaleHistory[i].StockItemsSoldField, Variables.SaleHistory[i].StockItemsTotalField,
                                                                   Variables.SaleHistory[i].SaleTotalField,Variables.SaleHistory[i].SaleDateField);
                for (int j = 0; j < currentsale.StockItemsSoldField.Count; j++)
                {
                    writelength++;
                }
                writelength += 3;
            }
            //one position for total revenue
            writelength += 1;
            stringToRichTextBox = new string[writelength];


            richTextBoxSaleHistoryDisplay.Clear();

            for (int i = 0; i < Variables.SaleHistory.Count; i++)
            {
                itemcount = 0;
                currentsale = new SaleInstance(Variables.SaleHistory[i].StockItemsSoldField, Variables.SaleHistory[i].StockItemsTotalField,
                                                                    Variables.SaleHistory[i].SaleTotalField,Variables.SaleHistory[i].SaleDateField);

                //Iterates through each string in StockItemsSold and assigns it to a variable
                stringToRichTextBox[lineposition] = Convert.ToString(currentsale.SaleDateField);
                lineposition++;
                //Populates list box 
                for (int j = 0; j < currentsale.StockItemsSoldField.Count; j++)
                {
                    stockitem = Convert.ToString(currentsale.StockItemsSoldField[j].ItemDescription);
                    stockitemtotal = Convert.ToInt32(currentsale.StockItemsTotalField[itemcount]);
                    stringToRichTextBox[lineposition] = stockitem + "       x" + stockitemtotal;
                    lineposition++;
                    itemcount++;
                }

                stringToRichTextBox[lineposition] = "Sale Total =   R" + currentsale.SaleTotalField;
                totalrevenue += currentsale.SaleTotalField;
                lineposition++;
                stringToRichTextBox[lineposition] = "------------------------------------------------------ ";
                lineposition++;
            }
            stringToRichTextBox[lineposition] = "Total Revenue: R" + totalrevenue;
            lineposition = 0;

            //Creates new line positions for each sale
            foreach (var item in stringToRichTextBox)
            {
                richTextBoxSaleHistoryDisplay.Text += (stringToRichTextBox[lineposition] + "\n");
                lineposition++;
            }
        }

        private void btnCloseSaleHistory_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
