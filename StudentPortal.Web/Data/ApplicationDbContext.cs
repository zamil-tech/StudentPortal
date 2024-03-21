using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entity;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        //this file works as bridge between entity frame work and database

        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Students> Students { get; set; }//getting dataset with type of student and name is students table


    }
}
