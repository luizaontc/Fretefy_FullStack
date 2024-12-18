﻿// <auto-generated />
using System;
using Fretefy.Test.Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20241208143728_AtualizandoMigration")]
    partial class AtualizandoMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a6821c4-0c6b-4637-b1f1-336fa5a03737"),
                            Nome = "Rio Branco",
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("673137da-a41f-41be-9e03-fdbb32a5f3cf"),
                            Nome = "Maceió",
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("91c0a255-c46e-42a5-8e4c-0292e62ba284"),
                            Nome = "Macapá",
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("449a51d4-6b81-452f-b4a5-20252d86e419"),
                            Nome = "Manaus",
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("3dd60fa0-9d20-41ce-b887-50e87d39de0a"),
                            Nome = "Salvador",
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("7a0d39dc-a387-4c08-b902-975ca6abb3a8"),
                            Nome = "Fortaleza",
                            UF = " CE"
                        },
                        new
                        {
                            Id = new Guid("72fec6fe-dd3b-44fd-a4a1-d48887163310"),
                            Nome = "Brasília",
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("039b12a1-535a-49bf-bf08-c7b266970fef"),
                            Nome = "Vitória",
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("d155da89-ca2e-48c9-8bec-15b03c9eab9c"),
                            Nome = "Goiânia",
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("e5381809-c22e-45e7-9fb8-75c39c179935"),
                            Nome = "São Luís",
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("ac9c455a-61f6-46e5-8215-8a6b6d0fd246"),
                            Nome = "Cuiabá",
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("dd97767f-dd78-4d3d-8467-96e8de31bc7f"),
                            Nome = "Campo Grande",
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("67190b69-22d7-4363-8dfd-e12de3722633"),
                            Nome = "Belo Horizonte",
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("e62c9339-0b5b-4097-a939-0dfed2f698f2"),
                            Nome = "Belém",
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("d24502bb-f80d-4c91-b6e1-b5a0e285dc7a"),
                            Nome = "João Pessoa",
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("306e99ef-cdc3-4836-8259-ee37cf88df25"),
                            Nome = "Curitiba",
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("984acb0b-0655-4862-98fd-4cde68b8e41c"),
                            Nome = "Recife",
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("864ab54c-65b5-4875-8886-721d08423f1a"),
                            Nome = "Teresina",
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("8f7a7a1d-c878-4d1d-a0a4-86966e597168"),
                            Nome = "Rio de Janeiro",
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("ee1bf969-300a-401f-8adc-80e196c1d64b"),
                            Nome = "Natal",
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("d9665ae1-3b6a-4982-b5cb-0216d770aaee"),
                            Nome = "Porto Alegre",
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("a81fd1b0-0b5f-4990-815f-4862dd471581"),
                            Nome = "Porto Velho",
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("a8a32e50-83b3-4a9e-8c66-98f16fd3fa09"),
                            Nome = "Boa Vista",
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("031ad752-9bf2-4626-be1d-748b9c18cbc4"),
                            Nome = "Florianópolis",
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("09cee05d-a501-4e94-aa6a-ae1bd0bf46e8"),
                            Nome = "São Paulo",
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("65c9bdd1-6610-40b6-91a8-cbf14761f16e"),
                            Nome = "Aracaju",
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("54e6e2c5-c5d6-4257-a8a3-3a5eb7305e16"),
                            Nome = "Palmas",
                            UF = "TO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
