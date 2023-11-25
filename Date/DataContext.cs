using Microsoft.EntityFrameworkCore;

namespace ASP_SPD_111.Date
{
    public class DataContext : DbContext
    {
        public DbSet<Entities.User> Users {get; set; }
        public DataContext(DbContextOptions options) : base(options)
        { }
    }
}

//Забезпечити пыдключення
