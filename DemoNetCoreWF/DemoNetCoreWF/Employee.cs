using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNetCoreWF
{
    public class Employee
    {
        //OID: Auto Generate

        // attributes
        public int Ssn { get; set; }
        public string FName { get; set; }
        public char MInit { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public float Salary { get; set; }
        public char Gender { get; set; }

        // relationships
        public List<WorksOn> WorksOn { get; set; }
        public Department WorksFor { get; set; }
        public Department Manages { get; set; }


        public Employee Supervisor { get; set; }
        public List<Employee> Supervisees { get; set; }

        public List<Dependent> Dependents { get; set; }
    }
}
