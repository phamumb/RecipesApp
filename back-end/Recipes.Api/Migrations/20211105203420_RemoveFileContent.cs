using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipes.Api.Migrations
{
    public partial class RemoveFileContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContent",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FileContent",
                table: "Ingredients",
                type: "longblob",
                nullable: true);
        }
    }
}
