using Microsoft.EntityFrameworkCore;

namespace ecommerce.Models
{

    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Admin> tbl_admin { get; set; }
    }
}
