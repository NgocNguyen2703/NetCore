using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoNetCore.Migrations
{
    public partial class Create_Table_KetQua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KetQuas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    MaMonHocID = table.Column<string>(type: "TEXT", nullable: true),
                    Diem = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KetQuas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KetQuas_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KetQuas_StudentId",
                table: "KetQuas",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KetQuas");
        }
    }
}
