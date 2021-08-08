using DataLogicLibrary.Models;
using DataLogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using DataLogicLibrary.DataAccess;

namespace DataLogicLibrary.DataProcessing
{
    public class PurchasesRepo:IPurchasesRepo
    {
        public IConfiguration Configuration { get; }
        public PurchasesRepo(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public List<Purchase> GetPurchases()
        {
            return SQLDataAccess.LoadData<Purchase>(Configuration.GetConnectionString("DataDB"), "exec SP_PurchaseInfo");
            
        }

        public List<Purchase> GetPurchasesByProject(string projectname)
        {
            throw new NotImplementedException();
        }


    }
}
