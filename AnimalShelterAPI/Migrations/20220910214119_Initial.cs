using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Coloring = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<double>(type: "double", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Personality = table.Column<int>(type: "int", nullable: false),
                    About = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Adopted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AdoptionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "About", "Adopted", "AdoptionDate", "Age", "Breed", "Coloring", "Name", "Personality", "Sex", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, "Love Cheek and Chin Scratches!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, "Domestic Medium Hair", "Black", "Domino", 3, 0, 0, 11.800000000000001 },
                    { 2, "Always PURRing and PURRfect!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.29999999999999999, "Domestic Short Hair", "Brown Tabby", "Doug", 4, 0, 0, 5.2000000000000002 },
                    { 3, "Anxious around new animals and people, but very sweet!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, "Domestic Short Hair", "Blue Tabby", "Bunny", 5, 0, 0, 7.4000000000000004 },
                    { 4, "Playful biter, loves chassing rabbits!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, "Labrador", "Yellow", "Angus", 6, 0, 1, 101.3 },
                    { 5, "A true HomeBuddy! Knows many tricks and is a quick learner!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8999999999999999, "American Pit Bull - Australian Shepherd", "White Brown", "Penny", 1, 1, 1, 52.100000000000001 },
                    { 6, "Love to Learn and Love to Cuddle!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5, "Dachsund", "Red White", "Churro", 0, 0, 1, 15.0 },
                    { 7, "Fun fun fun!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, "Cattle", "Black White", "Milo", 7, 1, 1, 50.0 },
                    { 8, "Wild heart!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, "Calico", "Black White Orange", "Mitsy", 0, 1, 0, 15.0 },
                    { 9, "I love to explore!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, "Hound", "Brown White", "Brutus", 6, 0, 1, 75.0 },
                    { 10, "Follow my leader!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, "Collie", "Black Tan", "Baron", 3, 0, 1, 55.0 },
                    { 11, "Lets play!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5, "Mix", "Golden", "Brew", 2, 1, 1, 35.0 },
                    { 12, "Shop cat!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, "Tabby", "Brown Grey", "Midge", 1, 0, 0, 22.0 },
                    { 13, "Throw the ball please!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.5, "Chow", "Grey", "Chubs", 4, 0, 1, 65.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
