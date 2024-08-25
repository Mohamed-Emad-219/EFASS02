using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS02.Entites
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string HourRate { get; set; }
        public int Dept_Id { get; set; }
    }
}
