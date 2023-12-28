namespace FruitBazzar1.Api
{
    public class FruitBazzarDbContext : DbContext
    {


        public FruitBazzarDbContext(DbContextOptions<FruitBazzarDbContext> options)
            : base(options)
        {
        }
    }   
}   
