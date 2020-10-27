using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class adham : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false),
                    OfferStatus = table.Column<int>(nullable: false),
                    OfferPersent = table.Column<int>(nullable: false),
                    OfferAmount = table.Column<double>(nullable: false),
                    IsDeleted = table.Column<int>(nullable: false),
                    ActionBy = table.Column<int>(nullable: false),
                    ActionOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    ItemDesc = table.Column<string>(nullable: true),
                    SellPrice = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<int>(nullable: false),
                    ActionBy = table.Column<int>(nullable: false),
                    ActionOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
