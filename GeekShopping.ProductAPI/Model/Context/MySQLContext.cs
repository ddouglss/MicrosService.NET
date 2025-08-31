using GeekShopping.ProductAPI.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta No Internet",
                Price = 69.9m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Capacete Darth Vader Star Wars Black Series",
                Price = 999.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                Price = 189.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Gamer",
                Price = 69.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta SpaceX",
                Price = 49.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camiseta Feminina Coffee Benefits",
                Price = 69.9m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Moletom Com Capuz Cobra Kai",
                Price = 159.9m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                CategoryName = "Sweatshirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Livro Star Talk – Neil DeGrasse Tyson",
                Price = 49.9m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true",
                CategoryName = "Book"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                Price = 359.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                Price = 59.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Camiseta GNU Linux Programador Masculina",
                Price = 59.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Camiseta Goku Fases",
                Price = 59.99m,
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "T-shirt"
            });
        }
    }
}