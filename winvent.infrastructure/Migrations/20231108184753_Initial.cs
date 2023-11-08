using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winvent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    AdminId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AdminFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    AdminLastName = table.Column<string>(type: "TEXT", nullable: true),
                    AdminUserName = table.Column<string>(type: "TEXT", nullable: true),
                    AdminPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdminEmail = table.Column<string>(type: "TEXT", nullable: true),
                    AdminPassword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.AdminId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProperty");
        }
    }
}
