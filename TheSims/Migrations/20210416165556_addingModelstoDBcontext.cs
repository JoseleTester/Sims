using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSims.Migrations
{
    public partial class addingModelstoDBcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    ActionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.ActionID);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodID);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceID);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ProfessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicSalary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ProfessionID);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    QuestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Reward = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.QuestID);
                });

            migrationBuilder.CreateTable(
                name: "SimLivesTable",
                columns: table => new
                {
                    SimID = table.Column<int>(type: "int", nullable: false),
                    DomesticUnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimLivesTable", x => new { x.SimID, x.DomesticUnitID });
                    table.ForeignKey(
                        name: "FK_SimLivesTable_DomesticUnits_DomesticUnitID",
                        column: x => x.DomesticUnitID,
                        principalTable: "DomesticUnits",
                        principalColumn: "DomesticUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SimLivesTable_Sims_SimID",
                        column: x => x.SimID,
                        principalTable: "Sims",
                        principalColumn: "SimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                });

            migrationBuilder.CreateTable(
                name: "Worlds",
                columns: table => new
                {
                    WorldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worlds", x => x.WorldID);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    SimID = table.Column<int>(type: "int", nullable: false),
                    ActionID = table.Column<int>(type: "int", nullable: false),
                    LastPerform = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => new { x.SimID, x.ActionID });
                    table.ForeignKey(
                        name: "FK_Performances_Actions_ActionID",
                        column: x => x.ActionID,
                        principalTable: "Actions",
                        principalColumn: "ActionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_Sims_SimID",
                        column: x => x.SimID,
                        principalTable: "Sims",
                        principalColumn: "SimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NeighborhoodDomesticUnitsTable",
                columns: table => new
                {
                    NeighborhoodID = table.Column<int>(type: "int", nullable: false),
                    DomesticUnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeighborhoodDomesticUnitsTable", x => new { x.NeighborhoodID, x.DomesticUnitID });
                    table.ForeignKey(
                        name: "FK_NeighborhoodDomesticUnitsTable_DomesticUnits_DomesticUnitID",
                        column: x => x.DomesticUnitID,
                        principalTable: "DomesticUnits",
                        principalColumn: "DomesticUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NeighborhoodDomesticUnitsTable_Neighborhoods_NeighborhoodID",
                        column: x => x.NeighborhoodID,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetLivesTable",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false),
                    DomesticUnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetLivesTable", x => new { x.PetID, x.DomesticUnitID });
                    table.ForeignKey(
                        name: "FK_PetLivesTable_DomesticUnits_DomesticUnitID",
                        column: x => x.DomesticUnitID,
                        principalTable: "DomesticUnits",
                        principalColumn: "DomesticUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetLivesTable_Pets_PetID",
                        column: x => x.PetID,
                        principalTable: "Pets",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NeighborhoodPlacesTable",
                columns: table => new
                {
                    NeighborhoodID = table.Column<int>(type: "int", nullable: false),
                    PlaceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeighborhoodPlacesTable", x => new { x.NeighborhoodID, x.PlaceID });
                    table.ForeignKey(
                        name: "FK_NeighborhoodPlacesTable_Neighborhoods_NeighborhoodID",
                        column: x => x.NeighborhoodID,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NeighborhoodPlacesTable_Places_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Places",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    SimID = table.Column<int>(type: "int", nullable: false),
                    ProfessionID = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => new { x.SimID, x.ProfessionID });
                    table.ForeignKey(
                        name: "FK_Exercises_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ProfessionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercises_Sims_SimID",
                        column: x => x.SimID,
                        principalTable: "Sims",
                        principalColumn: "SimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Travels",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SimID = table.Column<int>(type: "int", nullable: false),
                    WorldID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travels", x => new { x.SimID, x.WorldID, x.Date });
                    table.ForeignKey(
                        name: "FK_Travels_Sims_SimID",
                        column: x => x.SimID,
                        principalTable: "Sims",
                        principalColumn: "SimID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Travels_Worlds_WorldID",
                        column: x => x.WorldID,
                        principalTable: "Worlds",
                        principalColumn: "WorldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Involvements",
                columns: table => new
                {
                    QuestID = table.Column<int>(type: "int", nullable: false),
                    SimID = table.Column<int>(type: "int", nullable: false),
                    WorldID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Involvements", x => new { x.SimID, x.Date, x.QuestID, x.WorldID });
                    table.ForeignKey(
                        name: "FK_Involvements_Quests_QuestID",
                        column: x => x.QuestID,
                        principalTable: "Quests",
                        principalColumn: "QuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Involvements_Travels_SimID_WorldID_Date",
                        columns: x => new { x.SimID, x.WorldID, x.Date },
                        principalTable: "Travels",
                        principalColumns: new[] { "SimID", "WorldID", "Date" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ProfessionID",
                table: "Exercises",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Involvements_QuestID",
                table: "Involvements",
                column: "QuestID");

            migrationBuilder.CreateIndex(
                name: "IX_Involvements_SimID_WorldID_Date",
                table: "Involvements",
                columns: new[] { "SimID", "WorldID", "Date" });

            migrationBuilder.CreateIndex(
                name: "IX_NeighborhoodDomesticUnitsTable_DomesticUnitID",
                table: "NeighborhoodDomesticUnitsTable",
                column: "DomesticUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_NeighborhoodPlacesTable_PlaceID",
                table: "NeighborhoodPlacesTable",
                column: "PlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_ActionID",
                table: "Performances",
                column: "ActionID");

            migrationBuilder.CreateIndex(
                name: "IX_PetLivesTable_DomesticUnitID",
                table: "PetLivesTable",
                column: "DomesticUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_SimLivesTable_DomesticUnitID",
                table: "SimLivesTable",
                column: "DomesticUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Travels_WorldID",
                table: "Travels",
                column: "WorldID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Involvements");

            migrationBuilder.DropTable(
                name: "NeighborhoodDomesticUnitsTable");

            migrationBuilder.DropTable(
                name: "NeighborhoodPlacesTable");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "PetLivesTable");

            migrationBuilder.DropTable(
                name: "SimLivesTable");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "Travels");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Worlds");
        }
    }
}
