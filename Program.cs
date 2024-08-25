using EFASS02.Context;
using EFASS02.Entites;

namespace EFASS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          using ITIDBContext context = new ITIDBContext();
            #region Course crud op
            //Course c = new Course()
            //{
            //    Duration = 12,
            //    Name = "database",
            //    Descrepition = "fff"
            //};
            // context.Add(c);
            // var crs = from C in context.Course
            //           where c.Id == 1
            //           select c;

            //context.Remove(crs);
            //c.Name = "ggg"; 
            #endregion

            #region Crs_Ins
            //Crs_Ins crs_Ins = new Crs_Ins()
            //{
            //    Evalute = 5
            //};
            //  context.Add(crs_Ins);
            //  var crs = from crs in context.crs_ins
            //            where crs.Id == 1
            //            select crs;

            //context.Remove(crs);
            //crs.Name = "ggg"; 
            #endregion
        }
    }
}
