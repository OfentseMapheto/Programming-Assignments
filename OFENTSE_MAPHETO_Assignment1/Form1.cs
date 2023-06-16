using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFENTSE_MAPHETO_Assignment1
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private DataView dv;
        private List<Items> items;
        public Form1()
        {
            InitializeComponent();
            listView.View = View.Details;
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listView.Columns.Add("Name", 100);
            listView.Columns.Add("Price", 60);
            listView.Columns.Add("Quantity", 60);
            listView.Columns.Add("Category", 80);
            listView.Columns.Add("Date", 80);

            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Category");
            dt.Columns.Add("Date");

            fillDataTable(generateData());
            dv = new DataView(dt);

            populateListView(dv);


        }
        private List<Items> generateData()
        {
            items = new List<Items>()
            {
                new Items("Rolls" ,14.99  ,4, "Baked Goods", "2022-02-19"),
                new Items("Ice-Tea" ,24.99 ,14, "Fizzy Drinks", "2022-11-22"),
                new Items("Apples",15.99 ,10, " Fruits", "2022-01-01"),
                new Items("Wings" ,70.99 ,13, "Meat", "2022-01-12"),
                new Items("Cheese",65.99 ,12, "  Dairy Products", "2022-16-09"),
                new Items("Beans",09.99 ,25, "Vegetables", "2022-11-05"),
                new Items("Banana",19.99 ,20, "Fruits", "2022-08-15"),
                new Items("Grabs",12.99 ,34, "Fruits", "2022-18-21"),
               

            };
            return items;
        }
        private void fillDataTable(List<Items>items)
        {
            foreach(var item in items)
            {
                dt.Rows.Add(item.Name, item.Price, item.Quantity, item.Category, item.Date);
            }
        }
        private void populateListView(DataView dv)
        {
            listView.Items.Clear();
            foreach(DataRow row in dv.ToTable().Rows)
            {
                listView.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() }));
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);

            if (listView.Items.Count < 0)
                MessageBox.Show("No Items", "Empty Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAddd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || (string.IsNullOrEmpty(txtPrice.Text) || (string.IsNullOrEmpty(txtQty.Text) || (string.IsNullOrEmpty(txtCat.Text) || (string.IsNullOrEmpty(txtDate.Text))))))
                return;
            ListViewItem Item = new ListViewItem(txtName.Text);
            Item.SubItems.Add(txtPrice.Text);
            Item.SubItems.Add(txtQty.Text);
            Item.SubItems.Add(txtCat.Text);
            Item.SubItems.Add(txtDate.Text);
            listView.Items.Add(Item);
            txtName.Clear();
            txtQty.Clear();
            txtCat.Clear();
            txtDate.Clear();
            txtName.Focus();

        }
        private void filtertxt_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", textBox1.Text);
            populateListView(dv);
        }

       
    }
}

class Items
{
    private string name;
    private double price;
    private int quantity;
    private string category;
    private string date;

    public Items(string name, double price, int quantity, string category, string date)
    {
     
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
        this.Category = category;
        this.Date = date;
    }

    public string Name { get => name; set => name = value; }
    public double Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }
    public string Category { get => category; set => category = value; }
    public string Date { get => date; set => date = value; }
}