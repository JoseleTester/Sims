using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSims.Migrations
{
    public partial class addingProfessionUpSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfessionUpgradesSkillsTable",
                columns: table => new
                {
                    ProfessionID = table.Column<int>(type: "int", nullable: false),
                    SkillID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionUpgradesSkillsTable", x => new { x.ProfessionID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_ProfessionUpgradesSkillsTable_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ProfessionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionUpgradesSkillsTable_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionUpgradesSkillsTable_SkillID",
                table: "ProfessionUpgradesSkillsTable",
                column: "SkillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessionUpgradesSkillsTable");
        }
    }
}
