using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSims.Migrations
{
    public partial class addingOtherSkillTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SimSkillsTable",
                columns: table => new
                {
                    SimID = table.Column<int>(type: "int", nullable: false),
                    SkillID = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimSkillsTable", x => new { x.SimID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_SimSkillsTable_Sims_SimID",
                        column: x => x.SimID,
                        principalTable: "Sims",
                        principalColumn: "SimID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SimSkillsTable_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillActionsTable",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "int", nullable: false),
                    ActionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillActionsTable", x => new { x.SkillID, x.ActionID });
                    table.ForeignKey(
                        name: "FK_SkillActionsTable_Actions_ActionID",
                        column: x => x.ActionID,
                        principalTable: "Actions",
                        principalColumn: "ActionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillActionsTable_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SimSkillsTable_SkillID",
                table: "SimSkillsTable",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillActionsTable_ActionID",
                table: "SkillActionsTable",
                column: "ActionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimSkillsTable");

            migrationBuilder.DropTable(
                name: "SkillActionsTable");
        }
    }
}
