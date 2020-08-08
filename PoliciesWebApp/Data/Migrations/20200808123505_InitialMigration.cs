using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliciesWebApp.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoverageType",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverageType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risk",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Desc = table.Column<string>(maxLength: 500, nullable: true),
                    Coverage = table.Column<float>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    CoverageTime = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "Money", nullable: false),
                    RiskId = table.Column<short>(nullable: false),
                    RiskTypeId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Policies_Risk_RiskTypeId",
                        column: x => x.RiskTypeId,
                        principalTable: "Risk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyClient",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<long>(nullable: false),
                    ClientId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyClient_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyClient_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyCoverageType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<long>(nullable: false),
                    CoverageTypeId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyCoverageType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyCoverageType_CoverageType_CoverageTypeId",
                        column: x => x.CoverageTypeId,
                        principalTable: "CoverageType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyCoverageType_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_RiskTypeId",
                table: "Policies",
                column: "RiskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyClient_ClientId",
                table: "PolicyClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyClient_PolicyId",
                table: "PolicyClient",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyCoverageType_CoverageTypeId",
                table: "PolicyCoverageType",
                column: "CoverageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyCoverageType_PolicyId",
                table: "PolicyCoverageType",
                column: "PolicyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyClient");

            migrationBuilder.DropTable(
                name: "PolicyCoverageType");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "CoverageType");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Risk");
        }
    }
}
