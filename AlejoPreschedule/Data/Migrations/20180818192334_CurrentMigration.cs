using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AlejoPreschedule.Data.Migrations
{
    public partial class CurrentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ApplicationUserId",
                table: "Schedule",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_AspNetUsers_ApplicationUserId",
                table: "Schedule",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_AspNetUsers_ApplicationUserId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_ApplicationUserId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Schedule");
        }
    }
}
