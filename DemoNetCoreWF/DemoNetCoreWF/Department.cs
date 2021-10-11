using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNetCoreWF
{
    public class Department
    {
        // attributes
        public int DNumber { get; set; }
        public string DName { get; set; }

        public string MgrStartDate { get; set; }

        // relationships
        public List<Employee> Employees { get; set; }
        public Employee Manager { get; set; }
        public List<Project> Projects { get; set; }

    }
}
