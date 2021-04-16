using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyManagerModel.Migrations
{
    public partial class CategoryColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 2309453);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Categories");
        }
    }
}
