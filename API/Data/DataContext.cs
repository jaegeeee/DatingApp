using API.Entities;
using Microsoft.EntityFrameworkCore; //this line was added when it was derived.

namespace API.Data;

public class DataContext : DbContext //he added the derived from it. ": DBContext"
{
    public DataContext(DbContextOptions options) : base(options) //created contructor
    {
    }
    public DbSet<AppUser> Users { get; set; } //Entity framwork will map the entity name with this property. in this case, it will map it to "Users" table


}
