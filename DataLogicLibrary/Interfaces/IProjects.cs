using DataLogicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLibrary.Interfaces
{
    public interface IProjects
    {
        public List<Project> GetProjects();
        public List<Project> GetProjectById(int id);
        public int CreateProject(Project project);
        public int ModifyProject(int id, Project project);
        public int DeleteProject(int id);
    }
}
