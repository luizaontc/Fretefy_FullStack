using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class AdicionandoRegiaoCidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("00288cb2-1cfb-4452-b16d-ac9c940d2c88"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("03cb4ccd-7d32-4c9b-b37c-41fbfde1cafc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("07236cb6-25d6-414f-9dc1-fdd0e4a23016"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0ef60bac-5cab-4df3-b5c2-0e4f98a537d6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("10255e76-b112-4160-b4d9-f4447a825722"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1367d490-47f0-47cc-82cb-70062cbbe612"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("16311b64-443c-4692-b4dd-866e0e756c54"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("164b1e93-be5f-410c-a49d-7ade519f1c89"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2b64ef76-71b4-4bc7-8d5f-86222f3437be"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2fad40f3-7f32-46d1-aec8-cc478d452576"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("38a2230d-f24d-4376-bcee-1b113db76601"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3acd9ce0-2e50-400c-a87a-6d1814e03fdb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4ce32d6b-4fc8-46ed-88f3-20e506add8a9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5774cd90-50f4-43f5-8983-c8f4f375a4db"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("589a8488-7e41-4c7b-b922-bef5895efa3c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6a896eb7-86a2-4fa8-b9de-4759860dc8a0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7bc84c44-82d4-474b-8a17-cd91ebb7ba23"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7ee9c6a8-65b5-43d6-aef2-8b1b38902498"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("86bcc36f-995d-4d88-acbb-dfb72a5de376"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("87b512fd-167a-4b37-aed7-e4f016d8c6a0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8eeab87a-4266-47b5-a724-15d0b7b4f28b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("95c8065b-bde0-4859-afe9-4e05f1624148"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a84a4ff9-2bf5-4208-89e1-a9c1356ff96d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ad2f8666-1e08-4dee-8b95-7a1358d85172"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cdaf2ed9-f949-4117-a6ac-bed65e98a731"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e68fbf5c-9ccd-4237-afbd-aeec370bad1f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f858c956-f64e-4176-967c-6bde6bd0641f"));

            migrationBuilder.DeleteData(
                table: "Regiao",
                keyColumn: "Id",
                keyValue: new Guid("c432fe82-c393-4352-91af-83b05e7c1d3a"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("1367d490-47f0-47cc-82cb-70062cbbe612"), "Rio Branco", 0, null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("87b512fd-167a-4b37-aed7-e4f016d8c6a0"), "Aracaju", 0, null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("164b1e93-be5f-410c-a49d-7ade519f1c89"), "São Paulo", 0, null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("3acd9ce0-2e50-400c-a87a-6d1814e03fdb"), "Florianópolis", 0, null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("95c8065b-bde0-4859-afe9-4e05f1624148"), "Boa Vista", 0, null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("16311b64-443c-4692-b4dd-866e0e756c54"), "Porto Velho", 0, null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("7ee9c6a8-65b5-43d6-aef2-8b1b38902498"), "Porto Alegre", 0, null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("cdaf2ed9-f949-4117-a6ac-bed65e98a731"), "Natal", 0, null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("589a8488-7e41-4c7b-b922-bef5895efa3c"), "Rio de Janeiro", 0, null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("5774cd90-50f4-43f5-8983-c8f4f375a4db"), "Teresina", 0, null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("4ce32d6b-4fc8-46ed-88f3-20e506add8a9"), "Recife", 0, null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("7bc84c44-82d4-474b-8a17-cd91ebb7ba23"), "Curitiba", 0, null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("00288cb2-1cfb-4452-b16d-ac9c940d2c88"), "João Pessoa", 0, null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("8eeab87a-4266-47b5-a724-15d0b7b4f28b"), "Belém", 0, null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("6a896eb7-86a2-4fa8-b9de-4759860dc8a0"), "Belo Horizonte", 0, null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("ad2f8666-1e08-4dee-8b95-7a1358d85172"), "Campo Grande", 0, null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("f858c956-f64e-4176-967c-6bde6bd0641f"), "Cuiabá", 0, null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("10255e76-b112-4160-b4d9-f4447a825722"), "São Luís", 0, null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("2fad40f3-7f32-46d1-aec8-cc478d452576"), "Goiânia", 0, null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("e68fbf5c-9ccd-4237-afbd-aeec370bad1f"), "Vitória", 0, null, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("03cb4ccd-7d32-4c9b-b37c-41fbfde1cafc"), "Brasília", 0, null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("a84a4ff9-2bf5-4208-89e1-a9c1356ff96d"), "Fortaleza", 0, null, " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("2b64ef76-71b4-4bc7-8d5f-86222f3437be"), "Salvador", 0, null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("07236cb6-25d6-414f-9dc1-fdd0e4a23016"), "Manaus", 0, null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("86bcc36f-995d-4d88-acbb-dfb72a5de376"), "Macapá", 0, null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("0ef60bac-5cab-4df3-b5c2-0e4f98a537d6"), "Maceió", 0, null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "RegiaoId1", "UF" },
                values: new object[] { new Guid("38a2230d-f24d-4376-bcee-1b113db76601"), "Palmas", 0, null, "TO" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { new Guid("c432fe82-c393-4352-91af-83b05e7c1d3a"), "Sul", true });
        }
    }
}
