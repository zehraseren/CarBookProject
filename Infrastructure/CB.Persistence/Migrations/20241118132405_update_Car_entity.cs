using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_Car_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lagguage",
                table: "Cars",
                newName: "Luggage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Luggage",
                table: "Cars",
                newName: "Lagguage");
        }
    }
}
