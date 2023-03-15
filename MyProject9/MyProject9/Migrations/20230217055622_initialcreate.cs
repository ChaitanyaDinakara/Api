using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject9.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    cusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.cusId);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    cusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.cusId);
                });

            migrationBuilder.CreateTable(
                name: "Lineitems",
                columns: table => new
                {
                    Orderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderLine = table.Column<int>(type: "int", nullable: false),
                    proid = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lineitems", x => x.Orderid);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    proid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.proid);
                });

            migrationBuilder.CreateTable(
                name: "customerids",
                columns: table => new
                {
                    cusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    drivinglicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomercusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerids", x => x.cusId);
                    table.ForeignKey(
                        name: "FK_customerids_customers_CustomercusId",
                        column: x => x.CustomercusId,
                        principalTable: "customers",
                        principalColumn: "cusId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_customerids_CustomercusId",
                table: "customerids",
                column: "CustomercusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "customerids");

            migrationBuilder.DropTable(
                name: "Lineitems");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
