﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS02.Entites
{
    public class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public string Name { get; set; }
        public string Descrepition { get; set; }
        [InverseProperty("Course")]
        public Topic Topic { get; set; }
    }
}
