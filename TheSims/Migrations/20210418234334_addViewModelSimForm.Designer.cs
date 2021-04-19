﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheSims.Models;

namespace TheSims.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210418234334_addViewModelSimForm")]
    partial class addViewModelSimForm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheSims.Models.Action", b =>
                {
                    b.Property<int>("ActionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActionID");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("TheSims.Models.DomesticUnit", b =>
                {
                    b.Property<int>("DomesticUnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BathroomNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("DomesticUnitID");

                    b.ToTable("DomesticUnits");
                });

            modelBuilder.Entity("TheSims.Models.Neighborhood", b =>
                {
                    b.Property<int>("NeighborhoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("NeighborhoodID");

                    b.ToTable("Neighborhoods");
                });

            modelBuilder.Entity("TheSims.Models.Pet", b =>
                {
                    b.Property<int>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PetID");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("TheSims.Models.Place", b =>
                {
                    b.Property<int>("PlaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("PlaceID");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("TheSims.Models.Profession", b =>
                {
                    b.Property<int>("ProfessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BasicSalary")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessionID");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("TheSims.Models.Quest", b =>
                {
                    b.Property<int>("QuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<double>("Reward")
                        .HasColumnType("float");

                    b.HasKey("QuestID");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Exercise", b =>
                {
                    b.Property<int>("SimID")
                        .HasColumnType("int");

                    b.Property<int>("ProfessionID")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("SimID", "ProfessionID");

                    b.HasIndex("ProfessionID");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Involve", b =>
                {
                    b.Property<int>("SimID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestID")
                        .HasColumnType("int");

                    b.Property<int>("WorldID")
                        .HasColumnType("int");

                    b.HasKey("SimID", "Date", "QuestID", "WorldID");

                    b.HasIndex("QuestID");

                    b.HasIndex("SimID", "WorldID", "Date");

                    b.ToTable("Involvements");
                });

            modelBuilder.Entity("TheSims.Models.Relations.NeighborhoodDomesticUnits", b =>
                {
                    b.Property<int>("NeighborhoodID")
                        .HasColumnType("int");

                    b.Property<int>("DomesticUnitID")
                        .HasColumnType("int");

                    b.HasKey("NeighborhoodID", "DomesticUnitID");

                    b.HasIndex("DomesticUnitID");

                    b.ToTable("NeighborhoodDomesticUnitsTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.NeighborhoodPlaces", b =>
                {
                    b.Property<int>("NeighborhoodID")
                        .HasColumnType("int");

                    b.Property<int>("PlaceID")
                        .HasColumnType("int");

                    b.HasKey("NeighborhoodID", "PlaceID");

                    b.HasIndex("PlaceID");

                    b.ToTable("NeighborhoodPlacesTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Perform", b =>
                {
                    b.Property<int>("SimID")
                        .HasColumnType("int");

                    b.Property<int>("ActionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastPerform")
                        .HasColumnType("datetime2");

                    b.HasKey("SimID", "ActionID");

                    b.HasIndex("ActionID");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("TheSims.Models.Relations.PetLives", b =>
                {
                    b.Property<int>("PetID")
                        .HasColumnType("int");

                    b.Property<int>("DomesticUnitID")
                        .HasColumnType("int");

                    b.HasKey("PetID", "DomesticUnitID");

                    b.HasIndex("DomesticUnitID");

                    b.ToTable("PetLivesTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.ProfessionUpgradesSkill", b =>
                {
                    b.Property<int>("ProfessionID")
                        .HasColumnType("int");

                    b.Property<int>("SkillID")
                        .HasColumnType("int");

                    b.HasKey("ProfessionID", "SkillID");

                    b.HasIndex("SkillID");

                    b.ToTable("ProfessionUpgradesSkillsTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.SimLives", b =>
                {
                    b.Property<int>("SimID")
                        .HasColumnType("int");

                    b.Property<int>("DomesticUnitID")
                        .HasColumnType("int");

                    b.HasKey("SimID", "DomesticUnitID");

                    b.HasIndex("DomesticUnitID");

                    b.ToTable("SimLivesTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.SimSkills", b =>
                {
                    b.Property<int>("SimID")
                        .HasColumnType("int");

                    b.Property<int>("SkillID")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("SimID", "SkillID");

                    b.HasIndex("SkillID");

                    b.ToTable("SimSkillsTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.SkillActions", b =>
                {
                    b.Property<int>("SkillID")
                        .HasColumnType("int");

                    b.Property<int>("ActionID")
                        .HasColumnType("int");

                    b.HasKey("SkillID", "ActionID");

                    b.HasIndex("ActionID");

                    b.ToTable("SkillActionsTable");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Travel", b =>
                {
                    b.Property<int>("SimID")
                        .HasColumnType("int");

                    b.Property<int>("WorldID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("SimID", "WorldID", "Date");

                    b.HasIndex("WorldID");

                    b.ToTable("Travels");
                });

            modelBuilder.Entity("TheSims.Models.Sim", b =>
                {
                    b.Property<int>("SimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<string>("LifeStage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Money")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("SimID");

                    b.ToTable("Sims");
                });

            modelBuilder.Entity("TheSims.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("TheSims.Models.World", b =>
                {
                    b.Property<int>("WorldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("WorldID");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Exercise", b =>
                {
                    b.HasOne("TheSims.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Sim", "Sim")
                        .WithMany()
                        .HasForeignKey("SimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");

                    b.Navigation("Sim");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Involve", b =>
                {
                    b.HasOne("TheSims.Models.Quest", "Quest")
                        .WithMany()
                        .HasForeignKey("QuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Relations.Travel", "Travel")
                        .WithMany()
                        .HasForeignKey("SimID", "WorldID", "Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quest");

                    b.Navigation("Travel");
                });

            modelBuilder.Entity("TheSims.Models.Relations.NeighborhoodDomesticUnits", b =>
                {
                    b.HasOne("TheSims.Models.DomesticUnit", "DomesticUnit")
                        .WithMany()
                        .HasForeignKey("DomesticUnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Neighborhood", "Neighborhood")
                        .WithMany()
                        .HasForeignKey("NeighborhoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DomesticUnit");

                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("TheSims.Models.Relations.NeighborhoodPlaces", b =>
                {
                    b.HasOne("TheSims.Models.Neighborhood", "Neighborhood")
                        .WithMany()
                        .HasForeignKey("NeighborhoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighborhood");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Perform", b =>
                {
                    b.HasOne("TheSims.Models.Action", "Action")
                        .WithMany()
                        .HasForeignKey("ActionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Sim", "Sim")
                        .WithMany()
                        .HasForeignKey("SimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("Sim");
                });

            modelBuilder.Entity("TheSims.Models.Relations.PetLives", b =>
                {
                    b.HasOne("TheSims.Models.DomesticUnit", "DomesticUnit")
                        .WithMany()
                        .HasForeignKey("DomesticUnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DomesticUnit");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("TheSims.Models.Relations.ProfessionUpgradesSkill", b =>
                {
                    b.HasOne("TheSims.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("TheSims.Models.Relations.SimLives", b =>
                {
                    b.HasOne("TheSims.Models.DomesticUnit", "DomesticUnit")
                        .WithMany()
                        .HasForeignKey("DomesticUnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Sim", "Sim")
                        .WithMany()
                        .HasForeignKey("SimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DomesticUnit");

                    b.Navigation("Sim");
                });

            modelBuilder.Entity("TheSims.Models.Relations.SimSkills", b =>
                {
                    b.HasOne("TheSims.Models.Sim", "Sim")
                        .WithMany()
                        .HasForeignKey("SimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sim");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("TheSims.Models.Relations.SkillActions", b =>
                {
                    b.HasOne("TheSims.Models.Action", "Action")
                        .WithMany()
                        .HasForeignKey("ActionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("TheSims.Models.Relations.Travel", b =>
                {
                    b.HasOne("TheSims.Models.Sim", "Sim")
                        .WithMany()
                        .HasForeignKey("SimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheSims.Models.World", "World")
                        .WithMany()
                        .HasForeignKey("WorldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sim");

                    b.Navigation("World");
                });
#pragma warning restore 612, 618
        }
    }
}
