using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Redoak.Domain.Model.Migrations
{
    public partial class AddCustomerCreateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CrateDate",
                table: "Customer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Customer",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Customer",
                type: "varchar(10)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrateDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Customer");
        }
    }
}
