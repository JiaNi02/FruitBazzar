using Microsoft.EntityFrameworkCore;
using FruitBazzar1.Api.Models;

namespace FruitBazzar1.Api.Data
{
    public class FruitBazzarApidbcontext : DbContext
    {
        public FruitBazzarApidbcontext(DbContextOptions<FruitBazzarApidbcontext> options): base(options)
        {
        }

        public DbSet<Users> User { get; set; } = default!;
    }
}
