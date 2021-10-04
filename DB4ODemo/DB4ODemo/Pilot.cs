using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB4ODemo
{
    public class Pilot
    {
        public string Name { get; set; }
        public int Point { get; set; }
        public int Id { get; set; }

        public Pilot(int id = 0, string name = "", int point = 0)
        {
            Id = id;
            Name = name;
            Point = point;
        }

        public override string ToString()
        {
            return $"{Id} : {Name} : {Point}";
        }
    }
}
