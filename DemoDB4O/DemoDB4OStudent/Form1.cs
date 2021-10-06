using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDB4OStudent
{
    public partial class Form1 : Form
    {
        IObjectContainer db = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = Db4oFactory.OpenFile("Student.db");

            //GenerateDefaultData();

            var result = from Course sv in db
                         select sv;

            MessageBox.Show(result.Count().ToString());
        }

        private void GenerateDefaultData()
        {
            // Add 2 courses
            var adb = new Course
            {
                CourseCode = "COMP1041",
                CourseName = "Advanced Database"
            };
            var web = new Course
            {
                CourseCode = "COMP1031",
                CourseName = "Web Technology"
            };
            //db.Store(adb);
            //db.Store(web);


            // Add Student who learns 2 courses above
            var student = new Student
            {
                StudentId = "4501104004",
                FirstName = "David",
                LastName = "Teo",
                DOB = new DateTime(2002, 2, 2),
                RegisterYear = 2019,
                Courses = new List<Course>()
            };
            student.Courses.Add(adb);
            student.Courses.Add(web);

            db.Store(student);

            var result = from Student sv in db
                         select sv;

            MessageBox.Show(result.Count().ToString());

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }
    }
}
