using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bilart.aidpack.Data.Migrations
{
    public partial class Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstAidKitItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstAidKitId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsUsed = table.Column<bool>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstAidKitItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirstAidKits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HintByDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstAidKits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstAidKitItems");

            migrationBuilder.DropTable(
                name: "FirstAidKits");
        }
    }
}
