using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmSystem.Model
{
    public class Inventory
    {
        public DateTime Date { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
    }
}
