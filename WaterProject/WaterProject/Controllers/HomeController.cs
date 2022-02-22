using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterProject.Models;
using WaterProject.Models.ViewModels;

namespace WaterProject.Controllers
{
    public class HomeController : Controller
    {
        private IWaterProjectRepository repo;

        public HomeController (IWaterProjectRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string projectType, int pageNum = 1) //set the default page to 1 & DO NOT USE page as this variable name
        {
            int pageSize = 5;

            var x = new ProjectsViewModel
            {
                Projects = repo.Projects//.ToList() //we changed the data that is passed in; it is no longer a list
                    .Where(p => p.ProjectType == projectType || projectType == null)
                    .OrderBy(p => p.ProjectName)
                    .Skip(pageSize * (pageNum - 1)) // skip certain number of records
                    .Take(pageSize), // take a certain number of records

                PageInfo = new PageInfo
                {
                    TotalNumProjects = (projectType == null 
                            ? repo.Projects.Count() 
                            : repo.Projects.Where(x=> x.ProjectType == projectType).Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
