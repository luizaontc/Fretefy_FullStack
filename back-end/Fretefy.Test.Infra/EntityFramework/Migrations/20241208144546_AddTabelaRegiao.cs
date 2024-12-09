using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class AddTabelaRegiao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("031ad752-9bf2-4626-be1d-748b9c18cbc4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("039b12a1-535a-49bf-bf08-c7b266970fef"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("09cee05d-a501-4e94-aa6a-ae1bd0bf46e8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("306e99ef-cdc3-4836-8259-ee37cf88df25"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3dd60fa0-9d20-41ce-b887-50e87d39de0a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("449a51d4-6b81-452f-b4a5-20252d86e419"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("54e6e2c5-c5d6-4257-a8a3-3a5eb7305e16"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("65c9bdd1-6610-40b6-91a8-cbf14761f16e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("67190b69-22d7-4363-8dfd-e12de3722633"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("673137da-a41f-41be-9e03-fdbb32a5f3cf"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72fec6fe-dd3b-44fd-a4a1-d48887163310"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7a0d39dc-a387-4c08-b902-975ca6abb3a8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("864ab54c-65b5-4875-8886-721d08423f1a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8f7a7a1d-c878-4d1d-a0a4-86966e597168"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("91c0a255-c46e-42a5-8e4c-0292e62ba284"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("984acb0b-0655-4862-98fd-4cde68b8e41c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9a6821c4-0c6b-4637-b1f1-336fa5a03737"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a81fd1b0-0b5f-4990-815f-4862dd471581"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a8a32e50-83b3-4a9e-8c66-98f16fd3fa09"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ac9c455a-61f6-46e5-8215-8a6b6d0fd246"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d155da89-ca2e-48c9-8bec-15b03c9eab9c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d24502bb-f80d-4c91-b6e1-b5a0e285dc7a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d9665ae1-3b6a-4982-b5cb-0216d770aaee"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dd97767f-dd78-4d3d-8467-96e8de31bc7f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e5381809-c22e-45e7-9fb8-75c39c179935"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e62c9339-0b5b-4097-a939-0dfed2f698f2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ee1bf969-300a-401f-8adc-80e196c1d64b"));

            migrationBuilder.AddColumn<int>(
                name: "RegiaoId",
                table: "Cidade",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regiao");

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

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Cidade");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9a6821c4-0c6b-4637-b1f1-336fa5a03737"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("09cee05d-a501-4e94-aa6a-ae1bd0bf46e8"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("031ad752-9bf2-4626-be1d-748b9c18cbc4"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a8a32e50-83b3-4a9e-8c66-98f16fd3fa09"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a81fd1b0-0b5f-4990-815f-4862dd471581"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d9665ae1-3b6a-4982-b5cb-0216d770aaee"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ee1bf969-300a-401f-8adc-80e196c1d64b"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("8f7a7a1d-c878-4d1d-a0a4-86966e597168"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("864ab54c-65b5-4875-8886-721d08423f1a"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("984acb0b-0655-4862-98fd-4cde68b8e41c"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("306e99ef-cdc3-4836-8259-ee37cf88df25"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d24502bb-f80d-4c91-b6e1-b5a0e285dc7a"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("65c9bdd1-6610-40b6-91a8-cbf14761f16e"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e62c9339-0b5b-4097-a939-0dfed2f698f2"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("dd97767f-dd78-4d3d-8467-96e8de31bc7f"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ac9c455a-61f6-46e5-8215-8a6b6d0fd246"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e5381809-c22e-45e7-9fb8-75c39c179935"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d155da89-ca2e-48c9-8bec-15b03c9eab9c"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("039b12a1-535a-49bf-bf08-c7b266970fef"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("72fec6fe-dd3b-44fd-a4a1-d48887163310"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7a0d39dc-a387-4c08-b902-975ca6abb3a8"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3dd60fa0-9d20-41ce-b887-50e87d39de0a"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("449a51d4-6b81-452f-b4a5-20252d86e419"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("91c0a255-c46e-42a5-8e4c-0292e62ba284"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("673137da-a41f-41be-9e03-fdbb32a5f3cf"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("67190b69-22d7-4363-8dfd-e12de3722633"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("54e6e2c5-c5d6-4257-a8a3-3a5eb7305e16"), "Palmas", "TO" });
        }
    }
}
