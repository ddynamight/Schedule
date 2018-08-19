using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AlejoPreschedule.Data.Migrations
{
    public partial class NewAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Schedule");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Schedule",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Schedule");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Schedule",
                nullable: true);
        }
    }
}
