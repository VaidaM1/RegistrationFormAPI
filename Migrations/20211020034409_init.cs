using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationFormAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DropDownOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDownOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DropDownOption_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedValue",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    DropDownOptionId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedValue", x => new { x.QuestionId, x.DropDownOptionId });
                    table.ForeignKey(
                        name: "FK_SelectedValue_DropDownOption_DropDownOptionId",
                        column: x => x.DropDownOptionId,
                        principalTable: "DropDownOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedValue_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DropDownOption_QuestionId",
                table: "DropDownOption",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedValue_DropDownOptionId",
                table: "SelectedValue",
                column: "DropDownOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedValue");

            migrationBuilder.DropTable(
                name: "DropDownOption");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
