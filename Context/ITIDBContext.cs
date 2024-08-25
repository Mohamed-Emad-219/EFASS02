using EFASS02.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS02.Context
{
    internal class ITIDBContext :DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ITIWithRelation;Trusted_Connection=True;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crs_Ins>()
                        .HasKey(c => new { c.Crs_Id, c.Ins_Id });


            modelBuilder.Entity<Student_Course>()
                        .HasKey(sc => new { sc.Crs_Id, sc.Id });
        }
        DbSet<Student> Students { get; set; }
        DbSet<Student_Course> Student_Courses { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Crs_Ins>  Crs_Ins{ get; set; }

    }
}
