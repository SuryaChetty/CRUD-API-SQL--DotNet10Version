using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations.Models
{
    public class UserContext : DbContext 
    {
        public UserContext(DbContextOptions<UserContext> options ) : base(options)
        {

        }
        public DbSet<UserInfo> Users { get; set; }

    }
}
