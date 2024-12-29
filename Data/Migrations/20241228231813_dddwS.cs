using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wedding.Data.Migrations
{
    /// <inheritdoc />
    public partial class dddwS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "WeddingBookings",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "WeddingBookings",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "WeddingBookings",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "WeddingBookings",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WeddingBookings",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WeddingBookings",
                newName: "BookingId");
        }
    }
}
