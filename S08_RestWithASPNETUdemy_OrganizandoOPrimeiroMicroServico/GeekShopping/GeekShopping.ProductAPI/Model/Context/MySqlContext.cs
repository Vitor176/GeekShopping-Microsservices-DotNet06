using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Name",
                Price = new decimal(69.0),
                Description = "is simply dummy text of the printing and typesetting industry. n printer",
                ImageUrl = "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg",
                CategoryName = "Camiseta"
            });
        }
    }
}
