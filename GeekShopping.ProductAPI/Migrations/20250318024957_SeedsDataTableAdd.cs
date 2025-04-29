using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedsDataTableAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Action Figure", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 189.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "image_url", "name", "price" },
                values: new object[] { "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Sweatshirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Book", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Action Figure", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars", 59.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "image_url", "name" },
                values: new object[] { "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases" });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/2_no_internet.jpg", "Camiseta No Internet", 69.9m },
                    { 3L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/2_no_internet.jpg", "Name", 69.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Action Figure", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Action Figure", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 189.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "image_url", "name", "price" },
                values: new object[] { "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "T-shirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Sweatshirt", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Book", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "category_name", "image_url", "name", "price" },
                values: new object[] { "Action Figure", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "image_url", "name" },
                values: new object[] { "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars" });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 14L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m },
                    { 15L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m }
                });
        }
    }
}
