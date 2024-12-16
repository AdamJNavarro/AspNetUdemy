using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetUdemy.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRolesConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9f639de-624f-4a4e-b8bf-2381725462f1",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "247e9649-7ed1-439d-b7ef-d5460b5d56a4", new DateOnly(1950, 12, 1), "Master", "Admin", "AQAAAAIAAYagAAAAEI/3R4gsNOyxSY10VtRV0z3HsU8m2wA+kOCAIRgUUykXJ38y4cDPD3pMPQrUIgWKSw==", "5315b02e-dfd3-4e8c-9b23-f4623ddd72ab" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9f639de-624f-4a4e-b8bf-2381725462f1",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cfa68b7-c5a9-4b68-8d1d-498d90ccbb01", "AQAAAAIAAYagAAAAEK/i6M0gp0Ch4nvh6ladC8lKmu0DjZ7rwtd1QhuVfyTDdmG01EVS6wquD8SEPwrFmg==", "4b9b2347-624e-4665-82dc-c024944ddb8c" });
        }
    }
}
