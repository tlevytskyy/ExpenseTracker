using DataLogicLibrary.DataAccess;
using DataLogicLibrary.Interfaces;
using DataLogicLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLibrary.DataProcessing
{
    public class ProjectsRepo : IProjects
    {
        public IConfiguration Configuration { get; }
        public ProjectsRepo(IConfiguration config)
        {
            Configuration = config;
        }


        public int CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public int DeleteProject(int id)
        {
            throw new NotImplementedException();
        }
        public List<Project> GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects()
        {
            return SQLDataAccess.LoadData<Project>(Configuration.GetConnectionString("DataDB"), "exec SP_Projects_GetProjects");
        }

        public int ModifyProject(int id, Project project)
        {
            throw new NotImplementedException();
        }
    }
}
