using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOSsystem
{
    //Sales class
    class SaleInstance
    {

      private List<StockItem> StockItemsSold;
        private List<int> StockItemsTotal;
       private decimal SaleTotal;
        private DateTime SaleDate;

        //Sales class Constructor
        public SaleInstance(List<StockItem> stockItemsSold, List<int> stockItemsTotal, decimal saleTotal, DateTime saleDate)
        {
            StockItemsSold = stockItemsSold;
            StockItemsTotal = stockItemsTotal;
            SaleTotal = saleTotal;
            SaleDate = saleDate;
        }

        //Get-Set methods
        public List<int> StockItemsTotalField { get => StockItemsTotal; set => StockItemsTotal = value; }
        public decimal SaleTotalField { get => SaleTotal; set => SaleTotal = value; }
        public DateTime SaleDateField { get => SaleDate; set => SaleDate = value; }
        internal List<StockItem> StockItemsSoldField { get => StockItemsSold; set => StockItemsSold = value; }
    }
}
