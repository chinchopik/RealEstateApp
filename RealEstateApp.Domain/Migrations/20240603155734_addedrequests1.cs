using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class addedrequests1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdRealEstate",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdRealEstate",
                table: "Requests");
        }
    }
}
