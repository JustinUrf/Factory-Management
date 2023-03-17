using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class AllInitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineerlicenses_Engineers_EngineerId",
                table: "Engineerlicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Engineerlicenses_licenses_licenseId",
                table: "Engineerlicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_licenses",
                table: "licenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineerlicenses",
                table: "Engineerlicenses");

            migrationBuilder.RenameTable(
                name: "licenses",
                newName: "Licenses");

            migrationBuilder.RenameTable(
                name: "Engineerlicenses",
                newName: "EngineerLicenses");

            migrationBuilder.RenameColumn(
                name: "licenseDetail",
                table: "Licenses",
                newName: "LicenseDetail");

            migrationBuilder.RenameColumn(
                name: "licenseId",
                table: "Licenses",
                newName: "LicenseId");

            migrationBuilder.RenameColumn(
                name: "licenseId",
                table: "EngineerLicenses",
                newName: "LicenseId");

            migrationBuilder.RenameColumn(
                name: "EngineerlicenseId",
                table: "EngineerLicenses",
                newName: "EngineerLicenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Engineerlicenses_licenseId",
                table: "EngineerLicenses",
                newName: "IX_EngineerLicenses_LicenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Engineerlicenses_EngineerId",
                table: "EngineerLicenses",
                newName: "IX_EngineerLicenses_EngineerId");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licenses",
                table: "Licenses",
                column: "LicenseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineerLicenses",
                table: "EngineerLicenses",
                column: "EngineerLicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerLicenses_Engineers_EngineerId",
                table: "EngineerLicenses",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerLicenses_Licenses_LicenseId",
                table: "EngineerLicenses",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "LicenseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerLicenses_Engineers_EngineerId",
                table: "EngineerLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerLicenses_Licenses_LicenseId",
                table: "EngineerLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Licenses",
                table: "Licenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineerLicenses",
                table: "EngineerLicenses");

            migrationBuilder.RenameTable(
                name: "Licenses",
                newName: "licenses");

            migrationBuilder.RenameTable(
                name: "EngineerLicenses",
                newName: "Engineerlicenses");

            migrationBuilder.RenameColumn(
                name: "LicenseDetail",
                table: "licenses",
                newName: "licenseDetail");

            migrationBuilder.RenameColumn(
                name: "LicenseId",
                table: "licenses",
                newName: "licenseId");

            migrationBuilder.RenameColumn(
                name: "LicenseId",
                table: "Engineerlicenses",
                newName: "licenseId");

            migrationBuilder.RenameColumn(
                name: "EngineerLicenseId",
                table: "Engineerlicenses",
                newName: "EngineerlicenseId");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerLicenses_LicenseId",
                table: "Engineerlicenses",
                newName: "IX_Engineerlicenses_licenseId");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerLicenses_EngineerId",
                table: "Engineerlicenses",
                newName: "IX_Engineerlicenses_EngineerId");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_licenses",
                table: "licenses",
                column: "licenseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineerlicenses",
                table: "Engineerlicenses",
                column: "EngineerlicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineerlicenses_Engineers_EngineerId",
                table: "Engineerlicenses",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engineerlicenses_licenses_licenseId",
                table: "Engineerlicenses",
                column: "licenseId",
                principalTable: "licenses",
                principalColumn: "licenseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");
        }
    }
}
