using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOSsystem
{
    //Variables Class
    class Variables
    {
       public static List<SaleInstance> SaleHistory = new List<SaleInstance>();
        public static List<StockItem> Items = new List<StockItem>();
        public static List<int> QtyItems = new List<int>();
        public static List<StockItem> CurrentSalesList = new List<StockItem>();
        public static List<decimal> itemLineTotals = new List<decimal>();

        public static decimal SalesTotal;
        public static decimal tempDecimal = 0;
    }
}
