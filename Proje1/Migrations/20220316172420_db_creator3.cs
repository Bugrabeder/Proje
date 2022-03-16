using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje1.Migrations
{
    public partial class db_creator3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    info = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    age = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    countryid = table.Column<int>(type: "int", nullable: true),
                    orderid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Customers_Countrys_countryid",
                        column: x => x.countryid,
                        principalTable: "Countrys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    countryid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sellers_Countrys_countryid",
                        column: x => x.countryid,
                        principalTable: "Countrys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    creatingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<int>(type: "int", nullable: false),
                    info = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numberofStock = table.Column<int>(type: "int", nullable: false),
                    sellerid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_sellerid",
                        column: x => x.sellerid,
                        principalTable: "Sellers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    ordersid = table.Column<int>(type: "int", nullable: false),
                    productsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.ordersid, x.productsid });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_ordersid",
                        column: x => x.ordersid,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_productsid",
                        column: x => x.productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "dateAdded", "info", "name", "numberofStock", "price", "sellerid", "type" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 16, 20, 24, 20, 6, DateTimeKind.Local).AddTicks(7665), null, "Lenovo Legion", 100, 12000, null, "elektronik" },
                    { 2, new DateTime(2022, 3, 16, 20, 24, 20, 8, DateTimeKind.Local).AddTicks(4198), null, "İphone 13 ", 2200, 10000, null, "elektronik" },
                    { 3, new DateTime(2022, 3, 16, 20, 24, 20, 8, DateTimeKind.Local).AddTicks(4294), null, "Samsung 35x Kamera", 500, 7000, null, "elektronik" },
                    { 4, new DateTime(2022, 3, 16, 20, 24, 20, 8, DateTimeKind.Local).AddTicks(4312), null, "İphone Şarj aleti", 1000, 120, null, "elektronik" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_countryid",
                table: "Customers",
                column: "countryid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_productsid",
                table: "OrderProduct",
                column: "productsid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_sellerid",
                table: "Products",
                column: "sellerid");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_countryid",
                table: "Sellers",
                column: "countryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Countrys");
        }
    }
}
