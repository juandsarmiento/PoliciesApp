using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliciesWebApp.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Company 1" },
                    { 2L, "Company 2" }
                });

            migrationBuilder.InsertData(
                table: "CoverageType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (short)0, "EarthQuake" },
                    { (short)1, "Fire" },
                    { (short)3, "Lost" },
                    { (short)2, "Thefth" },
                    { (short)4, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "Id", "Coverage", "CoverageTime", "Desc", "Name", "Price", "RiskId", "RiskTypeId", "StartDate" },
                values: new object[,]
                {
                    { 66L, 67f, 8, "DescriptionTest #65", "PolicyTest #65", 0.87087096966378m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9088) },
                    { 67L, 25f, 9, "DescriptionTest #66", "PolicyTest #66", 0.618668034495166m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9094) },
                    { 68L, 61f, 9, "DescriptionTest #67", "PolicyTest #67", 0.63764993363882m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9099) },
                    { 69L, 76f, 2, "DescriptionTest #68", "PolicyTest #68", 0.846248985662241m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9143) },
                    { 73L, 1f, 10, "DescriptionTest #72", "PolicyTest #72", 0.856443683084307m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9164) },
                    { 71L, 73f, 2, "DescriptionTest #70", "PolicyTest #70", 0.0937793329794795m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9154) },
                    { 72L, 37f, 7, "DescriptionTest #71", "PolicyTest #71", 0.40722021898591m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9159) },
                    { 65L, 14f, 5, "DescriptionTest #64", "PolicyTest #64", 0.654385751883679m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9082) },
                    { 74L, 51f, 4, "DescriptionTest #73", "PolicyTest #73", 0.288218947261674m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9170) },
                    { 70L, 40f, 8, "DescriptionTest #69", "PolicyTest #69", 0.677898424061899m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9149) },
                    { 64L, 26f, 1, "DescriptionTest #63", "PolicyTest #63", 0.0952002727869899m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9077) },
                    { 61L, 22f, 3, "DescriptionTest #60", "PolicyTest #60", 0.482431494855523m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9061) },
                    { 62L, 58f, 1, "DescriptionTest #61", "PolicyTest #61", 0.622006203337575m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9066) },
                    { 75L, 35f, 6, "DescriptionTest #74", "PolicyTest #74", 0.226418048714482m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9175) },
                    { 60L, 98f, 2, "DescriptionTest #59", "PolicyTest #59", 0.735608146868464m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9055) },
                    { 59L, 96f, 2, "DescriptionTest #58", "PolicyTest #58", 0.100168895023022m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9050) },
                    { 58L, 13f, 2, "DescriptionTest #57", "PolicyTest #57", 0.670670611630506m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9045) },
                    { 57L, 75f, 4, "DescriptionTest #56", "PolicyTest #56", 0.757952312826157m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9039) },
                    { 56L, 47f, 10, "DescriptionTest #55", "PolicyTest #55", 0.144694816854175m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9034) },
                    { 55L, 10f, 6, "DescriptionTest #54", "PolicyTest #54", 0.108013841373852m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9029) },
                    { 54L, 95f, 8, "DescriptionTest #53", "PolicyTest #53", 0.743310587826795m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9023) },
                    { 53L, 7f, 11, "DescriptionTest #52", "PolicyTest #52", 0.417921897218526m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9018) },
                    { 63L, 56f, 8, "DescriptionTest #62", "PolicyTest #62", 0.724380025046123m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9071) },
                    { 76L, 43f, 9, "DescriptionTest #75", "PolicyTest #75", 0.984217454671961m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9180) },
                    { 79L, 74f, 11, "DescriptionTest #78", "PolicyTest #78", 0.654473960704391m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9196) },
                    { 78L, 22f, 10, "DescriptionTest #77", "PolicyTest #77", 0.853432628723529m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9191) },
                    { 100L, 1f, 8, "DescriptionTest #99", "PolicyTest #99", 0.235458286588759m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9341) },
                    { 99L, 32f, 4, "DescriptionTest #98", "PolicyTest #98", 0.230919522806499m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9302) },
                    { 98L, 32f, 7, "DescriptionTest #97", "PolicyTest #97", 0.988283399487046m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9297) },
                    { 97L, 26f, 1, "DescriptionTest #96", "PolicyTest #96", 0.0155329541375548m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9291) },
                    { 96L, 25f, 10, "DescriptionTest #95", "PolicyTest #95", 0.726322093385422m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9286) },
                    { 95L, 6f, 8, "DescriptionTest #94", "PolicyTest #94", 0.779692861614606m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9281) },
                    { 94L, 14f, 1, "DescriptionTest #93", "PolicyTest #93", 0.506495276236206m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9275) },
                    { 93L, 68f, 8, "DescriptionTest #92", "PolicyTest #92", 0.352370905853981m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9270) },
                    { 92L, 94f, 11, "DescriptionTest #91", "PolicyTest #91", 0.046894021819762m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9265) },
                    { 91L, 35f, 11, "DescriptionTest #90", "PolicyTest #90", 0.27104770730764m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9259) },
                    { 77L, 8f, 9, "DescriptionTest #76", "PolicyTest #76", 0.356078571340106m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9185) },
                    { 90L, 96f, 3, "DescriptionTest #89", "PolicyTest #89", 0.941291238153955m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9254) },
                    { 88L, 69f, 9, "DescriptionTest #87", "PolicyTest #87", 0.0137905264337503m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9243) },
                    { 87L, 99f, 5, "DescriptionTest #86", "PolicyTest #86", 0.818610254125022m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9238) },
                    { 86L, 19f, 4, "DescriptionTest #85", "PolicyTest #85", 0.664286235656722m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9233) },
                    { 85L, 17f, 3, "DescriptionTest #84", "PolicyTest #84", 0.321653638184841m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9228) },
                    { 84L, 43f, 10, "DescriptionTest #83", "PolicyTest #83", 0.268577329473839m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9222) },
                    { 83L, 85f, 4, "DescriptionTest #82", "PolicyTest #82", 0.900438666297327m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9217) },
                    { 82L, 88f, 1, "DescriptionTest #81", "PolicyTest #81", 0.427096480236899m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9212) },
                    { 81L, 33f, 8, "DescriptionTest #80", "PolicyTest #80", 0.820776243610669m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9206) },
                    { 80L, 55f, 6, "DescriptionTest #79", "PolicyTest #79", 0.612735504104167m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9201) },
                    { 52L, 74f, 5, "DescriptionTest #51", "PolicyTest #51", 0.306840346337687m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9013) },
                    { 89L, 88f, 6, "DescriptionTest #88", "PolicyTest #88", 0.508744416063998m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9249) },
                    { 51L, 13f, 4, "DescriptionTest #50", "PolicyTest #50", 0.688342979498367m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9007) },
                    { 49L, 32f, 4, "DescriptionTest #48", "PolicyTest #48", 0.349911832879256m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8996) },
                    { 23L, 14f, 8, "DescriptionTest #22", "PolicyTest #22", 0.593873855003097m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8833) },
                    { 22L, 58f, 7, "DescriptionTest #21", "PolicyTest #21", 0.742070127158458m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8827) },
                    { 21L, 91f, 9, "DescriptionTest #20", "PolicyTest #20", 0.0517863314839948m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8822) },
                    { 20L, 33f, 1, "DescriptionTest #19", "PolicyTest #19", 0.717404696027471m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8816) },
                    { 19L, 89f, 11, "DescriptionTest #18", "PolicyTest #18", 0.791905572075353m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8811) },
                    { 18L, 66f, 5, "DescriptionTest #17", "PolicyTest #17", 0.153713990074449m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8804) },
                    { 17L, 1f, 7, "DescriptionTest #16", "PolicyTest #16", 0.245576643499349m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8608) },
                    { 16L, 95f, 5, "DescriptionTest #15", "PolicyTest #15", 0.836030121350675m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8603) },
                    { 15L, 3f, 10, "DescriptionTest #14", "PolicyTest #14", 0.622693754091251m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8598) },
                    { 14L, 12f, 3, "DescriptionTest #13", "PolicyTest #13", 0.766524667742906m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8592) },
                    { 13L, 18f, 4, "DescriptionTest #12", "PolicyTest #12", 0.271398267835098m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8586) },
                    { 12L, 72f, 8, "DescriptionTest #11", "PolicyTest #11", 0.580997907827142m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8581) },
                    { 11L, 28f, 5, "DescriptionTest #10", "PolicyTest #10", 0.342530852808864m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8575) },
                    { 10L, 89f, 4, "DescriptionTest #9", "PolicyTest #9", 0.175782639149475m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8537) },
                    { 9L, 52f, 11, "DescriptionTest #8", "PolicyTest #8", 0.447948585938638m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8530) },
                    { 8L, 86f, 10, "DescriptionTest #7", "PolicyTest #7", 0.514349154436192m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8525) },
                    { 7L, 53f, 6, "DescriptionTest #6", "PolicyTest #6", 0.0790711865197267m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8519) },
                    { 6L, 77f, 8, "DescriptionTest #5", "PolicyTest #5", 0.483368984648664m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8514) },
                    { 5L, 65f, 1, "DescriptionTest #4", "PolicyTest #4", 0.744664585098934m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8506) },
                    { 4L, 92f, 2, "DescriptionTest #3", "PolicyTest #3", 0.0391919436115734m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8500) },
                    { 3L, 58f, 6, "DescriptionTest #2", "PolicyTest #2", 0.491863757135283m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8492) },
                    { 2L, 14f, 1, "DescriptionTest #1", "PolicyTest #1", 0.647102135534912m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8411) },
                    { 50L, 61f, 5, "DescriptionTest #49", "PolicyTest #49", 0.146493685499995m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(9002) },
                    { 24L, 70f, 6, "DescriptionTest #23", "PolicyTest #23", 0.816538562447084m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8839) },
                    { 25L, 57f, 7, "DescriptionTest #24", "PolicyTest #24", 0.451863529371034m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8844) },
                    { 26L, 40f, 7, "DescriptionTest #25", "PolicyTest #25", 0.602814185248136m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8850) },
                    { 48L, 40f, 1, "DescriptionTest #47", "PolicyTest #47", 0.638989553618706m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8991) },
                    { 47L, 40f, 6, "DescriptionTest #46", "PolicyTest #46", 0.227426427988068m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8986) },
                    { 46L, 29f, 8, "DescriptionTest #45", "PolicyTest #45", 0.573358417755626m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8980) },
                    { 45L, 5f, 2, "DescriptionTest #44", "PolicyTest #44", 0.686253014805844m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8975) },
                    { 44L, 95f, 6, "DescriptionTest #43", "PolicyTest #43", 0.928632414400872m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8969) },
                    { 43L, 26f, 5, "DescriptionTest #42", "PolicyTest #42", 0.929955998403m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8964) },
                    { 42L, 60f, 8, "DescriptionTest #41", "PolicyTest #41", 0.444167950397436m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8958) },
                    { 41L, 30f, 8, "DescriptionTest #40", "PolicyTest #40", 0.98181296278807m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8953) },
                    { 40L, 70f, 8, "DescriptionTest #39", "PolicyTest #39", 0.955934679115161m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8947) },
                    { 39L, 48f, 1, "DescriptionTest #38", "PolicyTest #38", 0.212628726946483m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8923) },
                    { 1L, 42f, 6, "DescriptionTest #0", "PolicyTest #0", 0.331126274229552m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 130, DateTimeKind.Local).AddTicks(7866) },
                    { 38L, 79f, 8, "DescriptionTest #37", "PolicyTest #37", 0.515914142837708m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8917) },
                    { 36L, 51f, 7, "DescriptionTest #35", "PolicyTest #35", 0.884617491105859m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8907) },
                    { 35L, 20f, 4, "DescriptionTest #34", "PolicyTest #34", 0.346341040146696m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8901) },
                    { 34L, 56f, 7, "DescriptionTest #33", "PolicyTest #33", 0.474005408340136m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8896) },
                    { 33L, 16f, 11, "DescriptionTest #32", "PolicyTest #32", 0.796903833652336m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8888) },
                    { 32L, 81f, 2, "DescriptionTest #31", "PolicyTest #31", 0.634107221213219m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8883) },
                    { 31L, 88f, 11, "DescriptionTest #30", "PolicyTest #30", 0.864603352669907m, (short)1, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8877) },
                    { 30L, 35f, 4, "DescriptionTest #29", "PolicyTest #29", 0.134344081922594m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8872) },
                    { 29L, 16f, 9, "DescriptionTest #28", "PolicyTest #28", 0.733693160458325m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8866) },
                    { 28L, 42f, 5, "DescriptionTest #27", "PolicyTest #27", 0.418314271801298m, (short)0, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8861) },
                    { 27L, 18f, 11, "DescriptionTest #26", "PolicyTest #26", 0.0507482011107487m, (short)3, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8855) },
                    { 37L, 28f, 7, "DescriptionTest #36", "PolicyTest #36", 0.843507803438002m, (short)2, null, new DateTime(2020, 8, 8, 8, 14, 47, 131, DateTimeKind.Local).AddTicks(8912) }
                });

            migrationBuilder.InsertData(
                table: "Risk",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (short)1, "Medium" },
                    { (short)2, "MediumHigh" },
                    { (short)0, "Low" },
                    { (short)3, "High" }
                });

            migrationBuilder.InsertData(
                table: "PolicyClient",
                columns: new[] { "Id", "ClientId", "PolicyId" },
                values: new object[,]
                {
                    { 6L, 2L, 51L },
                    { 17L, 2L, 100L },
                    { 19L, 2L, 50L },
                    { 13L, 1L, 40L },
                    { 7L, 1L, 71L },
                    { 5L, 1L, 37L },
                    { 8L, 2L, 74L },
                    { 15L, 1L, 77L },
                    { 3L, 2L, 29L },
                    { 20L, 1L, 83L },
                    { 12L, 1L, 84L },
                    { 14L, 2L, 17L },
                    { 10L, 1L, 15L },
                    { 9L, 1L, 78L },
                    { 18L, 1L, 55L },
                    { 11L, 1L, 11L },
                    { 16L, 2L, 5L },
                    { 1L, 2L, 95L },
                    { 4L, 1L, 9L },
                    { 2L, 2L, 92L }
                });

            migrationBuilder.InsertData(
                table: "PolicyCoverageType",
                columns: new[] { "Id", "CoverageTypeId", "PolicyId" },
                values: new object[,]
                {
                    { 96L, (short)4, 96L },
                    { 71L, (short)1, 71L },
                    { 70L, (short)4, 70L },
                    { 97L, (short)3, 97L },
                    { 69L, (short)1, 69L },
                    { 68L, (short)4, 68L },
                    { 67L, (short)0, 67L },
                    { 66L, (short)3, 66L },
                    { 64L, (short)2, 64L },
                    { 63L, (short)4, 63L },
                    { 62L, (short)1, 62L },
                    { 61L, (short)0, 61L },
                    { 60L, (short)2, 60L },
                    { 98L, (short)1, 98L },
                    { 59L, (short)2, 59L },
                    { 99L, (short)3, 99L },
                    { 58L, (short)0, 58L },
                    { 57L, (short)0, 57L },
                    { 56L, (short)2, 56L },
                    { 65L, (short)1, 65L },
                    { 72L, (short)2, 72L },
                    { 95L, (short)1, 95L },
                    { 74L, (short)4, 74L },
                    { 90L, (short)3, 90L },
                    { 89L, (short)2, 89L },
                    { 88L, (short)3, 88L },
                    { 87L, (short)3, 87L },
                    { 92L, (short)1, 92L },
                    { 86L, (short)1, 86L },
                    { 85L, (short)0, 85L },
                    { 84L, (short)2, 84L },
                    { 93L, (short)2, 93L },
                    { 73L, (short)0, 73L },
                    { 83L, (short)3, 83L },
                    { 81L, (short)1, 81L },
                    { 80L, (short)0, 80L },
                    { 79L, (short)4, 79L },
                    { 78L, (short)0, 78L },
                    { 55L, (short)3, 55L },
                    { 94L, (short)3, 94L },
                    { 77L, (short)4, 77L },
                    { 76L, (short)3, 76L },
                    { 75L, (short)3, 75L },
                    { 82L, (short)2, 82L },
                    { 91L, (short)3, 91L },
                    { 1L, (short)3, 1L },
                    { 53L, (short)3, 53L },
                    { 24L, (short)0, 24L },
                    { 23L, (short)4, 23L },
                    { 22L, (short)4, 22L },
                    { 21L, (short)0, 21L },
                    { 20L, (short)2, 20L },
                    { 19L, (short)1, 19L },
                    { 18L, (short)1, 18L },
                    { 17L, (short)4, 17L },
                    { 16L, (short)2, 16L },
                    { 15L, (short)3, 15L },
                    { 14L, (short)3, 14L },
                    { 13L, (short)0, 13L },
                    { 12L, (short)1, 12L },
                    { 11L, (short)3, 11L },
                    { 10L, (short)4, 10L },
                    { 9L, (short)0, 9L },
                    { 8L, (short)0, 8L },
                    { 7L, (short)3, 7L },
                    { 6L, (short)0, 6L },
                    { 5L, (short)0, 5L },
                    { 4L, (short)4, 4L },
                    { 3L, (short)1, 3L },
                    { 2L, (short)0, 2L },
                    { 25L, (short)1, 25L },
                    { 26L, (short)3, 26L },
                    { 27L, (short)0, 27L },
                    { 28L, (short)0, 28L },
                    { 52L, (short)0, 52L },
                    { 51L, (short)1, 51L },
                    { 50L, (short)1, 50L },
                    { 49L, (short)3, 49L },
                    { 48L, (short)1, 48L },
                    { 47L, (short)1, 47L },
                    { 46L, (short)0, 46L },
                    { 45L, (short)1, 45L },
                    { 44L, (short)4, 44L },
                    { 43L, (short)4, 43L },
                    { 42L, (short)3, 42L },
                    { 54L, (short)2, 54L },
                    { 41L, (short)0, 41L },
                    { 39L, (short)0, 39L },
                    { 38L, (short)1, 38L },
                    { 37L, (short)3, 37L },
                    { 36L, (short)2, 36L },
                    { 35L, (short)0, 35L },
                    { 34L, (short)0, 34L },
                    { 33L, (short)1, 33L },
                    { 32L, (short)4, 32L },
                    { 31L, (short)3, 31L },
                    { 30L, (short)1, 30L },
                    { 29L, (short)0, 29L },
                    { 40L, (short)1, 40L },
                    { 100L, (short)4, 100L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "PolicyClient",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageType",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Risk",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CoverageType",
                keyColumn: "Id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "CoverageType",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "CoverageType",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "CoverageType",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "CoverageType",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Policies",
                keyColumn: "Id",
                keyValue: 100L);
        }
    }
}
