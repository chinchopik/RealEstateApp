using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class _14052020418331 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalFloors",
                table: "RealEstates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalFloors",
                table: "RealEstates");
        }
    }
}
