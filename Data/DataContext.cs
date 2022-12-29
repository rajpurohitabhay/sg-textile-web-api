namespace sg_textile_web_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<State> States => Set<State>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<User> Users => Set<User>();
    }
}