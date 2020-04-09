using System;
using System.Collections.Generic;

namespace StoreInventoryManagement.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Department { get; set; }
        public decimal Price { get; set; }
        public int BalanceOnHand { get; set; }
        public int Minimum { get; set; }
        public int Allocation { get; set; }
        public int AmountOrdered { get; set; }
        public DateTime? NextExpirationDate { get; set; }
        public int DaySales { get; set; }
        public int WeekSales { get; set; }
        public int MonthSales { get; set; }
    }
}
