﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineAccountingAppServer.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class company_entity_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Companies",
                newName: "ServerUserId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Companies",
                newName: "ServerPassword");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServerUserId",
                table: "Companies",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ServerPassword",
                table: "Companies",
                newName: "Password");
        }
    }
}
