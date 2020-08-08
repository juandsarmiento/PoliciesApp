using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliciesWebApp.Data.Migrations
{
    public partial class AddColCanceledOnPolicyClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Canceled",
                table: "PolicyClient",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 87f, 3, 0.0805421136694691m, new DateTime(2020, 8, 8, 8, 25, 51, 891, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 51f, 9, 0.863624923333351m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 34f, 1, 0.608640760932416m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 18f, 0.318144405874491m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 64f, 3, 0.375107803556653m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 70f, 3, 0.0136997774307149m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 96f, 4, 0.997171293477142m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 80f, 5, 0.0104999211665708m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 86f, 1, 0.567323980651481m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 70f, 0.00474075181630475m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 37f, 2, 0.185372481674595m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 98f, 1, 0.368724255528638m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 75f, 2, 0.730454900642138m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 45f, 4, 0.809911303133662m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 19f, 1, 0.0437258235382502m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 75f, 4, 0.752412487171782m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 5f, 11, 0.094317883762679m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 57f, 7, 0.18290612063506m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 22f, 0.175758576568104m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 2f, 9, 0.0789329554321864m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 90f, 1, 0.759227239880351m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 70f, 11, 0.187399578368012m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 26f, 10, 0.507307893367162m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 23f, 9, 0.618221623179606m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 34f, 3, 0.15368518333588m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 91f, 3, 0.392907869719392m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 93f, 5, 0.820542042525738m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 10f, 3, 0.651292948355569m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 93f, 1, 0.332112669168093m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 58f, 1, 0.210820523654493m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 77f, 6, 0.847110329124662m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 10f, 6, 0.126196021272892m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 38f, 2, 0.25934875023521m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 64f, 1, 0.0518684359508885m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 63f, 7, 0.752317278064935m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 13f, 9, 0.47845567598867m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 24f, 2, 0.747212664572156m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 43f, 10, 0.43677924733459m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 6f, 0.23606572544019m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 40f, 0.0375908417802261m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 24f, 4, 0.0733306543311712m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 94f, 10, 0.75031700718697m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 2f, 8, 0.0884730737137017m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 31f, 10, 0.959743138849616m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 3f, 9, 0.432710633814666m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 74f, 11, 0.0355338887476986m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 71f, 11, 0.688157802768125m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 82f, 8, 0.242775154878746m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 57f, 0.0965141170176278m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 65f, 6, 0.118891537710508m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 35f, 10, 0.126865405648418m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 80f, 6, 0.971674059970152m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 9f, 3, 0.366788439157786m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 28f, 1, 0.691576494691696m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 31f, 7, 0.242471789122779m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 21f, 2, 0.0495421644530921m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 43f, 2, 0.394589754005237m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 77f, 0.387482132943106m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 66f, 1, 0.635861663443903m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 84f, 4, 0.68625958854624m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 0f, 6, 0.497903279260687m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 28f, 7, 0.639668133873338m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 62f, 10, 0.467286859390925m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 28f, 2, 0.127647269110962m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 82f, 9, 0.314730055776765m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 6f, 11, 0.408922599818987m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 80f, 10, 0.958717264215796m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 40f, 0.427533190896517m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 89f, 11, 0.963547144068194m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 65f, 5, 0.0913732820615979m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 52f, 10, 0.379083699723279m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 70f, 4, 0.228659510718966m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 96f, 5, 0.0570740658124322m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 96f, 1, 0.180230253459993m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 9f, 7, 0.836303665226467m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 65f, 5, 0.130270192460283m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 39f, 5, 0.178123064422106m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 18f, 5, 0.54210328429104m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 65f, 6, 0.110954962256809m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 59f, 0.213752457971569m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 62f, 5, 0.229202069914528m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 75f, 4, 0.0650914442097263m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 81f, 11, 0.619992819903415m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 57f, 8, 0.159555040374191m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 72f, 7, 0.552965031728598m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 13f, 11, 0.326964406448866m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 89f, 8, 0.434692523644628m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 93f, 11, 0.439243415109461m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 36f, 4, 0.799561911634897m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 21f, 2, 0.0506172664699225m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 36f, 4, 0.474439272412304m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 79f, 6, 0.834169204269614m, (short)1, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 33f, 1, 0.483098952790303m, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 90f, 11, 0.356123733965738m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 11f, 0.0804474773260054m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 89f, 7, 0.91053409078649m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 49f, 11, 0.718921946696435m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 86f, 11, 0.860557408938444m, (short)0, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 52f, 6, 0.906048533928603m, (short)2, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 46f, 1, 0.753184597358659m, (short)3, new DateTime(2020, 8, 8, 8, 25, 51, 893, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 70L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 22L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 3L,
                column: "PolicyId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 95L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 30L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 6L,
                column: "PolicyId",
                value: 99L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 62L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 70L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 9L,
                column: "PolicyId",
                value: 35L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 10L,
                column: "PolicyId",
                value: 67L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 11L,
                column: "PolicyId",
                value: 44L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 56L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 13L,
                column: "PolicyId",
                value: 99L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 51L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 15L,
                column: "PolicyId",
                value: 67L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 59L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 17L,
                column: "PolicyId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 49L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 9L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 20L,
                column: "PolicyId",
                value: 91L);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CoverageTypeId",
                value: (short)3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Canceled",
                table: "PolicyClient");

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 42f, 6, 0.331126274229552m, new DateTime(2020, 8, 8, 8, 14, 47, 130, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 14f, 1, 0.647102135534912m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 58f, 6, 0.491863757135283m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 92f, 0.0391919436115734m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 65f, 1, 0.744664585098934m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 77f, 8, 0.483368984648664m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 53f, 6, 0.0790711865197267m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 86f, 10, 0.514349154436192m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 52f, 11, 0.447948585938638m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 89f, 0.175782639149475m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 28f, 5, 0.342530852808864m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 72f, 8, 0.580997907827142m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 18f, 4, 0.271398267835098m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 12f, 3, 0.766524667742906m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 3f, 10, 0.622693754091251m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 95f, 5, 0.836030121350675m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 1f, 7, 0.245576643499349m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 66f, 5, 0.153713990074449m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 89f, 0.791905572075353m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 33f, 1, 0.717404696027471m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 91f, 9, 0.0517863314839948m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 58f, 7, 0.742070127158458m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 14f, 8, 0.593873855003097m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 70f, 6, 0.816538562447084m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 57f, 7, 0.451863529371034m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 40f, 7, 0.602814185248136m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 18f, 11, 0.0507482011107487m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 42f, 5, 0.418314271801298m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 16f, 9, 0.733693160458325m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 35f, 4, 0.134344081922594m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 88f, 11, 0.864603352669907m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 81f, 2, 0.634107221213219m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 16f, 11, 0.796903833652336m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 56f, 7, 0.474005408340136m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 20f, 4, 0.346341040146696m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 51f, 7, 0.884617491105859m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 28f, 7, 0.843507803438002m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 79f, 8, 0.515914142837708m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 48f, 0.212628726946483m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Coverage", "Price", "StartDate" },
                values: new object[] { 70f, 0.955934679115161m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 30f, 8, 0.98181296278807m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 60f, 8, 0.444167950397436m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 26f, 5, 0.929955998403m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 95f, 6, 0.928632414400872m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 5f, 2, 0.686253014805844m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 29f, 8, 0.573358417755626m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 40f, 6, 0.227426427988068m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 40f, 1, 0.638989553618706m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 32f, 0.349911832879256m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 61f, 5, 0.146493685499995m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 13f, 4, 0.688342979498367m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 74f, 5, 0.306840346337687m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 7f, 11, 0.417921897218526m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 95f, 8, 0.743310587826795m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 10f, 6, 0.108013841373852m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 47f, 10, 0.144694816854175m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 75f, 4, 0.757952312826157m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 13f, 0.670670611630506m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 96f, 2, 0.100168895023022m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 98f, 2, 0.735608146868464m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 22f, 3, 0.482431494855523m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 58f, 1, 0.622006203337575m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 56f, 8, 0.724380025046123m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 26f, 1, 0.0952002727869899m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 14f, 5, 0.654385751883679m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 67f, 8, 0.87087096966378m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 25f, 9, 0.618668034495166m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 61f, 0.63764993363882m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 76f, 2, 0.846248985662241m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 40f, 8, 0.677898424061899m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 73f, 2, 0.0937793329794795m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 37f, 7, 0.40722021898591m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 1f, 10, 0.856443683084307m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 51f, 4, 0.288218947261674m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 35f, 6, 0.226418048714482m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 43f, 9, 0.984217454671961m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 8f, 9, 0.356078571340106m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 22f, 10, 0.853432628723529m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 74f, 11, 0.654473960704391m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 55f, 0.612735504104167m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 33f, 8, 0.820776243610669m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 88f, 1, 0.427096480236899m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 85f, 4, 0.900438666297327m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 43f, 10, 0.268577329473839m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 17f, 3, 0.321653638184841m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 19f, 4, 0.664286235656722m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 99f, 5, 0.818610254125022m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 69f, 9, 0.0137905264337503m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 88f, 6, 0.508744416063998m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 96f, 3, 0.941291238153955m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 35f, 11, 0.27104770730764m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 94f, 11, 0.046894021819762m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "StartDate" },
                values: new object[] { 68f, 8, 0.352370905853981m, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 14f, 1, 0.506495276236206m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "Coverage", "Price", "RiskId", "StartDate" },
                values: new object[] { 6f, 0.779692861614606m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 25f, 10, 0.726322093385422m, (short)2, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 26f, 1, 0.0155329541375548m, (short)0, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 32f, 7, 0.988283399487046m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 32f, 4, 0.230919522806499m, (short)3, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Coverage", "CoverageTime", "Price", "RiskId", "StartDate" },
                values: new object[] { 1f, 8, 0.235458286588759m, (short)1, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 95L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 92L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 3L,
                column: "PolicyId",
                value: 29L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 9L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 37L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 6L,
                column: "PolicyId",
                value: 51L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 71L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 74L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 9L,
                column: "PolicyId",
                value: 78L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 10L,
                column: "PolicyId",
                value: 15L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 11L,
                column: "PolicyId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 84L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 13L,
                column: "PolicyId",
                value: 40L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 17L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 15L,
                column: "PolicyId",
                value: 77L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 5L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 17L,
                column: "PolicyId",
                value: 100L);

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 1L, 55L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ClientId", "PolicyId" },
                values: new object[] { 2L, 50L });

            migrationBuilder.UpdateData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 20L,
                column: "PolicyId",
                value: 83L);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CoverageTypeId",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CoverageTypeId",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CoverageTypeId",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CoverageTypeId",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CoverageTypeId",
                value: (short)3);

            migrationBuilder.UpdateData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CoverageTypeId",
                value: (short)4);
        }
    }
}
