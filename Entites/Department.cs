using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS02.Entites
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ins_Id { get; set; }
        public DateTime HireDate { get; set; }
        public Student Student { get; set; }
    }
}
