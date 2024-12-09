using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class AdicionandoRegiaoIdCIDADE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("12636f32-e885-44f4-810a-a6b78492f711"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("159a7f60-1b6c-4d1f-a05a-f81e21554787"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("19b7fee3-7e31-4ef2-98ba-a1129f608b07"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("22fffb53-9538-4bb0-8645-1c454b0569f5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("255ae234-0acd-4648-9259-7a35893c09f9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2d2ffcaa-916d-47dc-8ae7-dc2c491569a3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("387a860f-85b2-4a89-90b3-6ed0649ae3bc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("402b47f1-540a-4b55-b115-dcdf5d120f6f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("658c3182-8799-4c1b-b02c-9505613565d0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6b021c1c-2515-4a6f-b684-f08e60525daa"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6e453e0c-931e-407a-9923-5215fa6b610d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("89b37b6d-3a08-45ef-960c-d96d6a2c1dec"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8ad6950d-2afa-490c-ad47-cc5079ef535f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8d720be7-bfce-4939-ad9f-7f28c0bc1950"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8df8617a-f054-4c7e-a11f-3af201d023b8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9339a322-5e6c-4a20-8bf4-6c2e79bdc2c0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a4843cd2-27e9-4288-9503-6bec12c762ec"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b220cd96-aa07-4d5a-a722-d78719694ac6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b3dda8bd-fad3-48af-9a28-d782a5649f8e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d255038a-547a-4b09-8fcd-779c6b674d05"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d29a1ed1-54d2-447c-ac46-3bb364bc751a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d63f9bf4-b2cc-4d9f-b865-40660cc3c944"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eec30f9d-3168-423b-92a3-c09e01a4f91e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("efcacda6-5b1a-4497-b494-66407f4b7282"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f2fae82b-6a00-4458-83a9-a175ed70ca73"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f3e5b01a-25e8-4825-9f1c-41165e581dc1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f4c3b766-5345-4952-95fe-5c2c4788f9e4"));

            migrationBuilder.DeleteData(
                table: "Regiao",
                keyColumn: "Id",
                keyValue: new Guid("522819e5-5dee-42b7-b767-8b375be3ef69"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegiaoId1",
                table: "Cidade",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_RegiaoId1",
                table: "Cidade",
                column: "RegiaoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId1",
                table: "Cidade",
                column: "RegiaoId1",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId1",
                table: "Cidade");

            migrationBuilder.DropIndex(
                name: "IX_Cidade_RegiaoId1",
                table: "Cidade");

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

            migrationBuilder.DropColumn(
                name: "RegiaoId1",
                table: "Cidade");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d63f9bf4-b2cc-4d9f-b865-40660cc3c944"), "Rio Branco", 0, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f2fae82b-6a00-4458-83a9-a175ed70ca73"), "Aracaju", 0, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("159a7f60-1b6c-4d1f-a05a-f81e21554787"), "São Paulo", 0, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f4c3b766-5345-4952-95fe-5c2c4788f9e4"), "Florianópolis", 0, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("12636f32-e885-44f4-810a-a6b78492f711"), "Boa Vista", 0, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a4843cd2-27e9-4288-9503-6bec12c762ec"), "Porto Velho", 0, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("6b021c1c-2515-4a6f-b684-f08e60525daa"), "Porto Alegre", 0, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("22fffb53-9538-4bb0-8645-1c454b0569f5"), "Natal", 0, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("2d2ffcaa-916d-47dc-8ae7-dc2c491569a3"), "Rio de Janeiro", 0, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8ad6950d-2afa-490c-ad47-cc5079ef535f"), "Teresina", 0, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d255038a-547a-4b09-8fcd-779c6b674d05"), "Recife", 0, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("387a860f-85b2-4a89-90b3-6ed0649ae3bc"), "Curitiba", 0, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("6e453e0c-931e-407a-9923-5215fa6b610d"), "João Pessoa", 0, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("eec30f9d-3168-423b-92a3-c09e01a4f91e"), "Belém", 0, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("89b37b6d-3a08-45ef-960c-d96d6a2c1dec"), "Belo Horizonte", 0, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("b220cd96-aa07-4d5a-a722-d78719694ac6"), "Campo Grande", 0, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8d720be7-bfce-4939-ad9f-7f28c0bc1950"), "Cuiabá", 0, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("402b47f1-540a-4b55-b115-dcdf5d120f6f"), "São Luís", 0, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d29a1ed1-54d2-447c-ac46-3bb364bc751a"), "Goiânia", 0, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("19b7fee3-7e31-4ef2-98ba-a1129f608b07"), "Vitória", 0, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8df8617a-f054-4c7e-a11f-3af201d023b8"), "Brasília", 0, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("255ae234-0acd-4648-9259-7a35893c09f9"), "Fortaleza", 0, " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("9339a322-5e6c-4a20-8bf4-6c2e79bdc2c0"), "Salvador", 0, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("efcacda6-5b1a-4497-b494-66407f4b7282"), "Manaus", 0, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f3e5b01a-25e8-4825-9f1c-41165e581dc1"), "Macapá", 0, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("658c3182-8799-4c1b-b02c-9505613565d0"), "Maceió", 0, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("b3dda8bd-fad3-48af-9a28-d782a5649f8e"), "Palmas", 0, "TO" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[] { new Guid("522819e5-5dee-42b7-b767-8b375be3ef69"), "Sul", true });
        }
    }
}
