using DataLogicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLibrary.Interfaces
{
    public interface IPurchasesRepo
    {
        public List<Purchase> GetPurchases();
        public List<Purchase> GetPurchasesByProject(string projectname);
    }
}
