using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNetCoreWF
{
    public class Project
    {
        // attributes
        public int PNumber { get; set; }
        public string PName { get; set; }
        public string Location { get; set; }

        // relationships
        public Department ControlledBy { get; set; }
        public List<WorksOn> WorksOn { get; set; }
    }

    public class WorksOn
    {
        // attribute
        public float Hours { get; set; }
        //owner attributes
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }

}
