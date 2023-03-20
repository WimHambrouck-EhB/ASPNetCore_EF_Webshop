using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Beschrijving", "Categorie", "Naam", "Prijs" },
                values: new object[,]
                {
                    { 1, "PlayStation 5 + Sony PlayStation 5 DualSense draadloze controller. Aan een veel te hoge prijs, wegens overal uitverkocht.", 3, "PS5", 799.99m },
                    { 2, "Xbox Series X", 3, "XBox", 499.99m },
                    { 3, "Supermegasnelle console met graphics en hardware en meer van dat lekkers", 3, "Console: The Console", 9999.99m },
                    { 4, "Forged from the fires of the KFC ovens, there has never been a tastier way to experience the latest titles in stunning 4k, 240fps.", 3, "KFConsole", 499.99m },
                    { 5, "Super leuk spelletje", 0, "Game: The Game", 999.99m },
                    { 6, "Top 10 game of 2022", 0, "Aging Wreath", 44.44m },
                    { 7, "Top 10 game of 2022", 0, "Deity of Strife Gotterdammerung", 55.55m },
                    { 8, "Top 10 game of 2022", 0, "Skyline Prohibited Occident", 33.33m },
                    { 9, "Top 10 game of 2022", 0, "Request of Assignment: Innovative Military Action", 66.66m },
                    { 10, "The perfect gift for booze-loving Blade Runner fans", 1, "Blade Runner Whiskey Glasses", 138.99m },
                    { 11, "Alarm clock in the shape of a PS4 controller. Better then using your phone's alarm anyway...", 1, "PlayStation Alarm Clock", 28.99m },
                    { 12, "Multicoloured novelty lamp featuring seven different Tetromino shapes which light up once they come into contact with each other.", 1, "Tetris Stackable Toy Light", 37.98m },
                    { 13, "Look! Is it a headphone? Is it a microphone? Nope... it's BOTH!", 2, "Gaming head set", 149.99m },
                    { 14, "The keys are made of solid tritanium. Featuring a completely useless \"calculator\" button.", 2, "HyperX Keyboard", 83.99m },
                    { 15, "Featuring over 254 detachable buttons, it will turn (you) into the ultimate gaming tool.", 2, "PDMLV55 Wireless Mouse", 255.99m },
                    { 16, "A 65K 69inch 360° 5D monitor with a resolution up to 51000p and a 840hz refresh rate.  Will make your games come to life... literally. VGA cable included.", 2, "Aceus HAL PG051651XXQ Monitor", 9999.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
