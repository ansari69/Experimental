using Microsoft.EntityFrameworkCore.Migrations;

namespace ExperimentalTask.Infrastructure.Migrations
{
    public partial class createLayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experimentals",
                columns: table => new
                {
                    ExperimentalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experimentals", x => x.ExperimentalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experimentals");
        }
    }
}
