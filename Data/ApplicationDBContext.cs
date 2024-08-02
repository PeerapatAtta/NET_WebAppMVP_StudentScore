using Microsoft.EntityFrameworkCore;
using WebAppMVP.Models;

namespace WebAppMVP.Data
{
    //Class for connect to Database
    public class ApplicationDBContext : DbContext
    {
        //Constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options){

        }
        //Properies > Make Table from Model
        public DbSet<Student> Students { get; set; }
    }
}
