using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class AdicionandoRegiaoCidadee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("006630f4-be19-465e-b2b1-75474aaaa06d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0bf3a539-1f30-4537-9a91-f94ec75b4a40"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("211206f4-4d90-4a6d-ae20-3c7e9edd6421"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("267aa499-8e4a-434f-8a5f-92d79ae1639f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2bab59d1-28ef-4f43-b056-aa2f788c7b46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3135dd88-5793-4d4a-9e38-1d86b58782b0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("44987593-612f-4388-adf3-f3054511f9dc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("48357057-402a-4209-8fef-426cf2830cae"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5013108e-e32d-4c87-94bc-940d31833c76"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5d1c4363-ae53-40fc-9036-43041aeb8178"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("62530888-1c97-4cbe-974b-3cebb746403d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("649427a3-fee3-41f7-96fe-396815612276"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("64a56a34-3799-468f-9c10-a59252615aee"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("66a1af85-0aec-4c1f-8258-81e2df12df73"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6aac1ef7-9f0a-44ed-b960-c84502a62322"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72f9ea41-041e-4db5-aefa-0bd7d2ad1509"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("79bb3022-a15c-4bce-8c44-6dfbabd15a92"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("85fc9352-53ff-45d7-95a6-dc72af30f4b3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8821e383-58a8-4377-8de7-67de69378f63"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("888f8f37-7e0f-4b13-b731-d638eb0dccf8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9a9ff32a-061c-40fb-b882-88b0379a4830"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a44dae46-6690-45ef-82db-903bca33f5ff"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ad379298-af00-489d-b886-75b93bcf1718"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b8bf26a8-c9ea-40ab-a07f-5095553a3d62"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e717cc61-74fe-4c1c-865f-e3835ed763e1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec1fd3fa-715c-43cd-b460-cc967e117f96"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f5564f08-4951-41c8-a54f-52f7f12c2b03"));

            migrationBuilder.DeleteData(
                table: "Regiao",
                keyColumn: "Id",
                keyValue: new Guid("c8a89df5-67bb-4d1f-9348-560126abe092"));

            migrationBuilder.CreateTable(
                name: "RegiaoCidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CidadeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegiaoCidade", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("fa4b7c06-a49a-4651-b7dd-125274e5521a"), "Rio Branco", 0, null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("22b20017-45d1-4a80-a759-14f8f40b6226"), "Aracaju", 0, null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("d89553b8-495b-401d-886f-3bf1c34760ea"), "São Paulo", 0, null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("b6f82939-93f2-4ec3-80ee-7546ee7a098e"), "Florianópolis", 0, null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("9841e9bc-99b0-46e4-802e-9a194543fa1a"), "Boa Vista", 0, null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("9334a098-31f0-4fb1-9142-b18efb9dde95"), "Porto Velho", 0, null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("beb550d8-58f1-4966-b6be-b812bafdff1f"), "Porto Alegre", 0, null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("a41ca151-117b-4110-819a-fb725eb7a26f"), "Natal", 0, null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("a25f4e4e-13bc-449c-a806-fd6edafa7246"), "Rio de Janeiro", 0, null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("0a925aa8-2353-4160-a60d-18cbc34d067e"), "Teresina", 0, null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("d4c88f15-7394-4303-9894-71dd5eb179e5"), "Recife", 0, null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("0d0b0cb0-19ff-4f14-a98e-f8d87fc5305f"), "Curitiba", 0, null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("b29df295-1f28-4e90-8a4c-757ba7755885"), "João Pessoa", 0, null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("13f61d65-b080-42bf-8a35-59559ec757b6"), "Belém", 0, null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("5a784e56-6076-45f0-a167-f55cc9f51e0b"), "Belo Horizonte", 0, null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("8d014d06-22c8-4419-bc34-ef88e3825743"), "Campo Grande", 0, null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("95912187-52d6-4e24-b356-67c9a1951e6a"), "Cuiabá", 0, null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("dd436661-e68e-4584-8800-547e8cbdf822"), "São Luís", 0, null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("4b5ff531-b336-4c79-88f8-74e7ee65c810"), "Goiânia", 0, null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("80b25ea9-5a16-4cb5-9104-00a500e674d2"), "Vitória", 0, null, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("97b91af9-78a3-46f8-b491-3bd731caf53e"), "Brasília", 0, null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("10a9873d-637e-4c86-830a-94a6f8d3f6df"), "Fortaleza", 0, null, " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("9deeaeed-96b2-4be2-909a-15111df09211"), "Salvador", 0, null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("fe095108-1f8e-49bf-8cfc-0903fc6b9712"), "Manaus", 0, null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("613a7b8b-2bb3-4b56-aaa7-517dd8fdf1fd"), "Macapá", 0, null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("8dcd7296-45ae-4252-9527-876f747a7ddc"), "Maceió", 0, null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("1e417103-8cb9-4477-8205-27b0530bec53"), "Palmas", 0, null, "TO" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { new Guid("4c1b4153-640a-4cb3-8644-77e6949dd03a"), "Sul", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegiaoCidade");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a925aa8-2353-4160-a60d-18cbc34d067e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0d0b0cb0-19ff-4f14-a98e-f8d87fc5305f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("10a9873d-637e-4c86-830a-94a6f8d3f6df"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("13f61d65-b080-42bf-8a35-59559ec757b6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1e417103-8cb9-4477-8205-27b0530bec53"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("22b20017-45d1-4a80-a759-14f8f40b6226"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4b5ff531-b336-4c79-88f8-74e7ee65c810"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5a784e56-6076-45f0-a167-f55cc9f51e0b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("613a7b8b-2bb3-4b56-aaa7-517dd8fdf1fd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("80b25ea9-5a16-4cb5-9104-00a500e674d2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8d014d06-22c8-4419-bc34-ef88e3825743"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8dcd7296-45ae-4252-9527-876f747a7ddc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9334a098-31f0-4fb1-9142-b18efb9dde95"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("95912187-52d6-4e24-b356-67c9a1951e6a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("97b91af9-78a3-46f8-b491-3bd731caf53e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9841e9bc-99b0-46e4-802e-9a194543fa1a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9deeaeed-96b2-4be2-909a-15111df09211"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a25f4e4e-13bc-449c-a806-fd6edafa7246"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a41ca151-117b-4110-819a-fb725eb7a26f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b29df295-1f28-4e90-8a4c-757ba7755885"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b6f82939-93f2-4ec3-80ee-7546ee7a098e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("beb550d8-58f1-4966-b6be-b812bafdff1f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d4c88f15-7394-4303-9894-71dd5eb179e5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d89553b8-495b-401d-886f-3bf1c34760ea"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dd436661-e68e-4584-8800-547e8cbdf822"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fa4b7c06-a49a-4651-b7dd-125274e5521a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fe095108-1f8e-49bf-8cfc-0903fc6b9712"));

            migrationBuilder.DeleteData(
                table: "Regiao",
                keyColumn: "Id",
                keyValue: new Guid("4c1b4153-640a-4cb3-8644-77e6949dd03a"));

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("f5564f08-4951-41c8-a54f-52f7f12c2b03"), "Rio Branco", 0, null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("62530888-1c97-4cbe-974b-3cebb746403d"), "Aracaju", 0, null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("3135dd88-5793-4d4a-9e38-1d86b58782b0"), "São Paulo", 0, null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("267aa499-8e4a-434f-8a5f-92d79ae1639f"), "Florianópolis", 0, null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("b8bf26a8-c9ea-40ab-a07f-5095553a3d62"), "Boa Vista", 0, null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("44987593-612f-4388-adf3-f3054511f9dc"), "Porto Velho", 0, null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("888f8f37-7e0f-4b13-b731-d638eb0dccf8"), "Porto Alegre", 0, null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("48357057-402a-4209-8fef-426cf2830cae"), "Natal", 0, null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("006630f4-be19-465e-b2b1-75474aaaa06d"), "Rio de Janeiro", 0, null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("79bb3022-a15c-4bce-8c44-6dfbabd15a92"), "Teresina", 0, null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("85fc9352-53ff-45d7-95a6-dc72af30f4b3"), "Recife", 0, null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("5d1c4363-ae53-40fc-9036-43041aeb8178"), "Curitiba", 0, null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("8821e383-58a8-4377-8de7-67de69378f63"), "João Pessoa", 0, null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("ad379298-af00-489d-b886-75b93bcf1718"), "Belém", 0, null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("ec1fd3fa-715c-43cd-b460-cc967e117f96"), "Belo Horizonte", 0, null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("a44dae46-6690-45ef-82db-903bca33f5ff"), "Campo Grande", 0, null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("64a56a34-3799-468f-9c10-a59252615aee"), "Cuiabá", 0, null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("9a9ff32a-061c-40fb-b882-88b0379a4830"), "São Luís", 0, null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("211206f4-4d90-4a6d-ae20-3c7e9edd6421"), "Goiânia", 0, null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("6aac1ef7-9f0a-44ed-b960-c84502a62322"), "Vitória", 0, null, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("72f9ea41-041e-4db5-aefa-0bd7d2ad1509"), "Brasília", 0, null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("2bab59d1-28ef-4f43-b056-aa2f788c7b46"), "Fortaleza", 0, null, " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("0bf3a539-1f30-4537-9a91-f94ec75b4a40"), "Salvador", 0, null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("5013108e-e32d-4c87-94bc-940d31833c76"), "Manaus", 0, null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("66a1af85-0aec-4c1f-8258-81e2df12df73"), "Macapá", 0, null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("e717cc61-74fe-4c1c-865f-e3835ed763e1"), "Maceió", 0, null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("649427a3-fee3-41f7-96fe-396815612276"), "Palmas", 0, null, "TO" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { new Guid("c8a89df5-67bb-4d1f-9348-560126abe092"), "Sul", true });
        }
    }
}
