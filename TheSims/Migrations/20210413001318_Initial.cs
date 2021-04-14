using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSims.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sims",
                columns: table => new
                {
                    SimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sims", x => x.SimID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sims");
        }
    }
}
