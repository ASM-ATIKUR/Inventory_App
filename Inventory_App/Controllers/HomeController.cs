using Inventory_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Inventory_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Employee()
        {
            // Sample data , We can import data from database
            var employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    EmployeeName = "John Doe",
                    EmployeeAddress = "123 Main St",
                    EmployeePhone = "555-1234",
                    EmployeeEmail = "john.doe@example.com",
                    EmployeePosition = "Developer",
                    Projects = new List<Project>
                    {
                        new Project { ProjectId = 1, ProjectName = "Project A", ProjectDescription = "Description A", ProjectUrl = "http://example.com/a" },
                        new Project { ProjectId = 2, ProjectName = "Project B", ProjectDescription = "Description B", ProjectUrl = "http://example.com/b" }
                    }
                },
                new Employee
                {
                    EmployeeId = 2,
                    EmployeeName = "Jane Smith",
                    EmployeeAddress = "456 Elm St",
                    EmployeePhone = "555-5678",
                    EmployeeEmail = "jane.smith@example.com",
                    EmployeePosition = "Manager",
                    Projects = new List<Project>
                    {
                        new Project { ProjectId = 3, ProjectName = "Project C", ProjectDescription = "Description C", ProjectUrl = "http://example.com/c" }
                    }
                }
            };

            ViewBag.Employees = employees;

            return View("EmployeeView");
        }
    }

}
