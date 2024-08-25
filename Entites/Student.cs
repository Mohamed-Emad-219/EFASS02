using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS02.Entites
{
   //Table("Students",Schema ="dbo")]// table in db we don't use dbset<>
    internal class Student 
    {
        [Key]
        public int StdId { get; set; }
        [DataType("varchar")]
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Address { get; set; }
        //  [NotMapped] in app only not database
        public ICollection<Department> Department { get; set; } = new HashSet<Department>();
    }
}
