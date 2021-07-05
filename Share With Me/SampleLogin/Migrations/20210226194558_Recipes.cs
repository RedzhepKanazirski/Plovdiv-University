using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareWithMe.Migrations
{
    public partial class Recipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    one = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    two = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    three = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    four = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    five = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    six = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
