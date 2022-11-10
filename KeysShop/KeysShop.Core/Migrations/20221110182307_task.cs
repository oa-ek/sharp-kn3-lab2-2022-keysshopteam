using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeysShop.Core.Migrations
{
    public partial class task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02ffe756-4ead-4589-a140-2910465f8635", "3f4b0fc9-9494-4ba1-9dc4-8b5ba991996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02ffe756-4ead-4589-a140-2910465f8635", "537e13a7-e1e8-41f1-a30c-64d65a64c5d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1545fcff-76a8-4c5f-94de-35e737d8cbf0", "537e13a7-e1e8-41f1-a30c-64d65a64c5d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02ffe756-4ead-4589-a140-2910465f8635", "67b236a7-c4af-49d4-b25f-41bae669eb82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4d875da-c84a-4596-805b-c0d5194ede54", "67b236a7-c4af-49d4-b25f-41bae669eb82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02ffe756-4ead-4589-a140-2910465f8635", "d12d710e-0014-47a3-a105-e5a3161e774f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1545fcff-76a8-4c5f-94de-35e737d8cbf0", "d12d710e-0014-47a3-a105-e5a3161e774f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2685ad31-00a1-45f4-89db-af84f6ed6691", "d12d710e-0014-47a3-a105-e5a3161e774f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4d875da-c84a-4596-805b-c0d5194ede54", "d12d710e-0014-47a3-a105-e5a3161e774f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ffe756-4ead-4589-a140-2910465f8635");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1545fcff-76a8-4c5f-94de-35e737d8cbf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2685ad31-00a1-45f4-89db-af84f6ed6691");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4d875da-c84a-4596-805b-c0d5194ede54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4b0fc9-9494-4ba1-9dc4-8b5ba991996d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "537e13a7-e1e8-41f1-a30c-64d65a64c5d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b236a7-c4af-49d4-b25f-41bae669eb82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d12d710e-0014-47a3-a105-e5a3161e774f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46121cf9-f89f-4281-818a-a71fa24025ed", "590360ac-93d1-4a5d-9a7f-306343df5d84", "Admin", "ADMIN" },
                    { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "41abcb92-eb0d-4ac7-a1a0-14104d9109d0", "Customer", "CUSTOMER" },
                    { "cd455617-7a76-4fa4-b756-e2f27665db3e", "89343623-0a99-4bf2-9e7b-de6572769ef0", "Consultant", "CONSULTANT" },
                    { "f31dd0ea-35f4-4249-ad3d-b324b4b84716", "19a0f3d1-af8f-44f0-9352-eb6449699ee3", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48f2cf34-44e0-4b57-bb08-39a5f0199183", 0, "b1818358-34ee-4c2f-b489-0981baac8adf", "manager@keysshop.com", true, null, null, false, null, "MANAGER@KEYSSHOP.COM", "MANAGER@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEC2in53DW48WJ5TrBQVvOfDlQyptfiedKJHhUakchAZryztbK/C/ZJhGiWL5knMuoQ==", null, false, "26ce5496-783f-49e6-9f1d-ac0cffeaabec", false, "manager@keysshop.com" },
                    { "52b17208-28fd-4b7c-812f-be6fb3b1f12a", 0, "c84ad469-6261-4fa5-a1ff-fa308a86f3ed", "admin@keysshop.com", true, null, null, false, null, "ADMIN@KEYSSHOP.COM", "ADMIN@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEHb1TSUlJ7oVLNEMUn6Jdbl1g8R0xNKxKsogjMlMoevanJd+mBBIzgwaLLQhwYsnig==", null, false, "1884dad4-a893-4701-91d2-103d0b2c426a", false, "admin@keysshop.com" },
                    { "8f76fb95-4b9d-4268-a38b-9ababb0d0f49", 0, "76791673-71b9-48e9-9a03-2134b83655b8", "consultant@keysshop.com", true, null, null, false, null, "CONSULTANT@KEYSSHOP.COM", "CONSULTANT@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEFpxJxSIofKY+BAteQRD5rOdd42uZ7yq2g12NZjn1nc3l6ba0Wxuj/PLcPTI4aQmMQ==", null, false, "36b0afc2-f204-4c7d-8ce2-7834c25ffc4e", false, "consultant@keysshop.com" },
                    { "af666120-c6a6-4ff3-bd71-c41cd84cd8aa", 0, "dade217a-d30b-4c19-b2bb-b0de64c5c672", "customer@keysshop.com", true, null, null, false, null, "CUSTOMER@KEYSSHOP.COM", "CUSTOMER@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEMDTqUe3vVHzyhfRriAu/2KsBjvW/DqppfQ9Kkd1JOdbpeRbWs2XG/wUagOwRe8MLw==", null, false, "e902096e-8ffd-4389-8953-ad7f01ed5745", false, "customer@keysshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "48f2cf34-44e0-4b57-bb08-39a5f0199183" },
                    { "f31dd0ea-35f4-4249-ad3d-b324b4b84716", "48f2cf34-44e0-4b57-bb08-39a5f0199183" },
                    { "46121cf9-f89f-4281-818a-a71fa24025ed", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" },
                    { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" },
                    { "cd455617-7a76-4fa4-b756-e2f27665db3e", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" },
                    { "f31dd0ea-35f4-4249-ad3d-b324b4b84716", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" },
                    { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "8f76fb95-4b9d-4268-a38b-9ababb0d0f49" },
                    { "cd455617-7a76-4fa4-b756-e2f27665db3e", "8f76fb95-4b9d-4268-a38b-9ababb0d0f49" },
                    { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "af666120-c6a6-4ff3-bd71-c41cd84cd8aa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "48f2cf34-44e0-4b57-bb08-39a5f0199183" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f31dd0ea-35f4-4249-ad3d-b324b4b84716", "48f2cf34-44e0-4b57-bb08-39a5f0199183" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46121cf9-f89f-4281-818a-a71fa24025ed", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd455617-7a76-4fa4-b756-e2f27665db3e", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f31dd0ea-35f4-4249-ad3d-b324b4b84716", "52b17208-28fd-4b7c-812f-be6fb3b1f12a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "8f76fb95-4b9d-4268-a38b-9ababb0d0f49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd455617-7a76-4fa4-b756-e2f27665db3e", "8f76fb95-4b9d-4268-a38b-9ababb0d0f49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "492fa3ab-c89c-4b84-8b95-a66a454211dd", "af666120-c6a6-4ff3-bd71-c41cd84cd8aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46121cf9-f89f-4281-818a-a71fa24025ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "492fa3ab-c89c-4b84-8b95-a66a454211dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd455617-7a76-4fa4-b756-e2f27665db3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f31dd0ea-35f4-4249-ad3d-b324b4b84716");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48f2cf34-44e0-4b57-bb08-39a5f0199183");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52b17208-28fd-4b7c-812f-be6fb3b1f12a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f76fb95-4b9d-4268-a38b-9ababb0d0f49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af666120-c6a6-4ff3-bd71-c41cd84cd8aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02ffe756-4ead-4589-a140-2910465f8635", "1c2e3b7f-9684-46b0-b155-e896547789f8", "Customer", "CUSTOMER" },
                    { "1545fcff-76a8-4c5f-94de-35e737d8cbf0", "63beeec8-65ca-4900-a1ab-06189dad6469", "Consultant", "CONSULTANT" },
                    { "2685ad31-00a1-45f4-89db-af84f6ed6691", "72c2d8c8-0086-4a16-95ad-e684bc3e82fd", "Admin", "ADMIN" },
                    { "d4d875da-c84a-4596-805b-c0d5194ede54", "381b34c9-c7b4-47df-b60e-ec5fe2671554", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4b0fc9-9494-4ba1-9dc4-8b5ba991996d", 0, "b39e2d0b-a71e-4d59-9dfa-41582465d325", "customer@keysshop.com", true, null, null, false, null, "CUSTOMER@KEYSSHOP.COM", "CUSTOMER@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEEkuHm3Lwj0es08gazzGaEaV2G7bLu4qASoB5UiFU+c7YTicXGuUp16GuRiIPsxtsQ==", null, false, "3116c5f3-3446-4c67-af51-0cd287959986", false, "customer@keysshop.com" },
                    { "537e13a7-e1e8-41f1-a30c-64d65a64c5d8", 0, "bdb2c9a9-c02d-4b47-8198-7e32a8ef3aa4", "consultant@keysshop.com", true, null, null, false, null, "CONSULTANT@KEYSSHOP.COM", "CONSULTANT@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEBSbU1YSIjPY6OXvEn40s7uZ4JvKd62EooWlfokve1NgGH0mwBF0PlZYHgFKVRbHpA==", null, false, "3304a5e0-3a65-43de-af5f-af2aed39b419", false, "consultant@keysshop.com" },
                    { "67b236a7-c4af-49d4-b25f-41bae669eb82", 0, "cffdcc20-8015-4b3f-be30-22458160f586", "manager@keysshop.com", true, null, null, false, null, "MANAGER@KEYSSHOP.COM", "MANAGER@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEEj1biBZbtDFC1DOyDa0tJE47QRgb7ly3pv+yphK36VwRpAkkHKoWF8JdeLVyXJM3A==", null, false, "8825d9d8-33e3-471b-a000-91b359bc32fd", false, "manager@keysshop.com" },
                    { "d12d710e-0014-47a3-a105-e5a3161e774f", 0, "06d866ea-f502-4488-ad3e-55a65cb73dd8", "admin@keysshop.com", true, null, null, false, null, "ADMIN@KEYSSHOP.COM", "ADMIN@KEYSSHOP.COM", "AQAAAAEAACcQAAAAEDp7fiM22WcUsgBfAPqPT/k3iria9jnerby9V7vpwbuRlJDYa8iItraiSNjkR1+ASA==", null, false, "14c04dbd-c353-448b-9c92-c67bca48144b", false, "admin@keysshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "02ffe756-4ead-4589-a140-2910465f8635", "3f4b0fc9-9494-4ba1-9dc4-8b5ba991996d" },
                    { "02ffe756-4ead-4589-a140-2910465f8635", "537e13a7-e1e8-41f1-a30c-64d65a64c5d8" },
                    { "1545fcff-76a8-4c5f-94de-35e737d8cbf0", "537e13a7-e1e8-41f1-a30c-64d65a64c5d8" },
                    { "02ffe756-4ead-4589-a140-2910465f8635", "67b236a7-c4af-49d4-b25f-41bae669eb82" },
                    { "d4d875da-c84a-4596-805b-c0d5194ede54", "67b236a7-c4af-49d4-b25f-41bae669eb82" },
                    { "02ffe756-4ead-4589-a140-2910465f8635", "d12d710e-0014-47a3-a105-e5a3161e774f" },
                    { "1545fcff-76a8-4c5f-94de-35e737d8cbf0", "d12d710e-0014-47a3-a105-e5a3161e774f" },
                    { "2685ad31-00a1-45f4-89db-af84f6ed6691", "d12d710e-0014-47a3-a105-e5a3161e774f" },
                    { "d4d875da-c84a-4596-805b-c0d5194ede54", "d12d710e-0014-47a3-a105-e5a3161e774f" }
                });
        }
    }
}
