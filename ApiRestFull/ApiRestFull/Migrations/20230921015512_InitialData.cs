using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiRestFull.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("c1d2c053-49b6-410c-bc78-2d54a9991833"), "cll 85 B 48 A", "USA", "S.A SOLUTION" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991855"), "cra 100 sur 28", "USA", "MAPRE" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("c9d4c013-49b6-410c-bc78-2d54a9991877"), 30, new Guid("c9d4c053-14b6-410c-bc78-2d54a9991866"), "Andres Gutierrez", "Desarrollador" },
                    { new Guid("c9d4c053-49b1-510c-bc78-2d54a9991888"), 20, new Guid("c9d4c053-49b6-416c-bc78-2d54a9991899"), "Sebastian Murcia", "Desarrollador" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c1d2c053-49b6-410c-bc78-2d54a9991833"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991855"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("c9d4c013-49b6-410c-bc78-2d54a9991877"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("c9d4c053-49b1-510c-bc78-2d54a9991888"));
        }
    }
}
