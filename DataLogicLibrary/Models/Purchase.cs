using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLibrary.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public string ProjectName { get; set; }
        public string PartnerName { get; set; }
        public string Details { get; set; }
        public decimal Amount { get; set; }
    }
}
