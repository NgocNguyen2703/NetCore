using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoNetCore.Migrations
{
    public partial class Create_Table_Student_School : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "Students",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School",
                table: "Students");
        }
    }
}
