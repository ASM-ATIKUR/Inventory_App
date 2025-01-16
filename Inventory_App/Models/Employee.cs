using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_App.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePosition { get; set; }   
        public List<Project> Projects { get; set; }

    }

    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectUrl { get; set; }
    }

}