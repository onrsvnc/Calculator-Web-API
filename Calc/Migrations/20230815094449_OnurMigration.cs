using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calc.Migrations
{
    /// <inheritdoc />
    public partial class OnurMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationHistory",
                columns: table => new
                {
                    CalculationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    B = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationHistory", x => x.CalculationID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationHistory");
        }
    }
}
