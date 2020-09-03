using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymBoss.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(nullable: false),
                    PTrainerId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    RestingHeartRate = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    BMI = table.Column<int>(nullable: false),
                    Neck = table.Column<int>(nullable: false),
                    Bust = table.Column<int>(nullable: false),
                    Chest = table.Column<int>(nullable: false),
                    UpperArm = table.Column<int>(nullable: false),
                    Forearm = table.Column<int>(nullable: false),
                    Waist = table.Column<int>(nullable: false),
                    Hips = table.Column<int>(nullable: false),
                    Thigh = table.Column<int>(nullable: false),
                    Calves = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PTrainerId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    EmailReminder = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Certifications = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Specialties = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsManager = table.Column<int>(nullable: false),
                    IsTrainer = table.Column<int>(nullable: false),
                    IsClient = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    EmerFirstName = table.Column<string>(nullable: true),
                    EmerLastName = table.Column<string>(nullable: true),
                    EmerPhone1 = table.Column<string>(nullable: true),
                    EmerPhone2 = table.Column<string>(nullable: true),
                    Allergies = table.Column<string>(nullable: true),
                    Injuries = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
