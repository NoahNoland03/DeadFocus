using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeadFocus.Migrations
{
    /// <inheritdoc />
    public partial class changeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Goals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goals",
                table: "Goals",
                column: "GoalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Goals",
                table: "Goals");

            migrationBuilder.RenameTable(
                name: "Goals",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "GoalId");
        }
    }
}
