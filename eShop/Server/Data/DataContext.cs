namespace eShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Where the Crawdads Sing",
                        Description = "The reclusive Kya Clark is suspected in the death of Chase Andrews",
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51-uh7zesTL._SL300.jpg",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "The Summer I Turned Pretty",
                        Description = "Youth: Belly has an unforgettable summer with old friends and new experiences",
                        ImageUrl = "https://booklist.usatoday.com/covers/isbn/9781416968290.jpg",
                        Price = 19.99m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "It Ends With Us",
                        Description = "Ryle Kincaid's relationship with Lily becomes complicated when a man from her past shows up",
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51KZalxuryL._SL300.jpg",
                        Price = 3.99m
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
