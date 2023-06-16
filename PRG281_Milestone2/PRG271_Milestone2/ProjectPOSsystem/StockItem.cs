using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOSsystem
{
    //StockItem class
    class StockItem
    {
        private string Description;
        private decimal Price;

        //StockItem class constructor
        public StockItem(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        //Get-Set methods
        public string ItemDescription { get => Description; set => Description = value; }
        public decimal ItemPrice { get => Price; set => Price = value; }

        
    }
}
