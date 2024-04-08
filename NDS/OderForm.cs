using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDS
{
    public class Order
    {
        public string FormID { get; set; }
        public DateTime Date { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string NewspaperID { get; set; }
        public string NewspaperName { get; set; }
        public string PeriodicalPublication { get; set; }
        public string Amount { get; set; }
        public DateTime OrderFrom { get; set; }
        public DateTime OrderTo { get; set; }
        public override string ToString()
        {
            return $"{NewspaperID} {NewspaperName}";
        }
    }
}
