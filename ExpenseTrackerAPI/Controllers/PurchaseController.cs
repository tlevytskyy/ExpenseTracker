using DataLogicLibrary.Interfaces;
using DataLogicLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerAPI.Controllers
{
    [Route("api/purchases")]
    [ApiController]
    public class PurchaseController : Controller
    {
        public IPurchasesRepo PurchasesRepo { get; }
        public PurchaseController(IPurchasesRepo repo)
        {
            PurchasesRepo = repo;
        }
        // api/purchases
        [HttpGet]
        public ActionResult<List<Purchase>> GetPurchases()
        {
            var data = PurchasesRepo.GetPurchases();
            return Ok(data);
        }
    }
}
