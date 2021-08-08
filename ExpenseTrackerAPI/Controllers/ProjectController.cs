using DataLogicLibrary.Models;
using DataLogicLibrary.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerAPI.Controllers
{
    [Route("api/project")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IProjects _ProjectsRepo; //ProjectsRepo Injection

        public ProjectController(IProjects repo)
        {
            _ProjectsRepo = repo;
        }
        //api/projects
        [HttpGet]
        public ActionResult<Project> GetProjects()
        {
            var data = _ProjectsRepo.GetProjects();
            return Ok(data);
        }
    }
}
