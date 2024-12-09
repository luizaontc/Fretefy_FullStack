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
    [Migration("20241208170438_AdicionandoRegiaoIdCIDADE")]
    partial class AdicionandoRegiaoIdCIDADE
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

                    b.Property<int>("RegiaoId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("RegiaoId1")
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RegiaoId1");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1367d490-47f0-47cc-82cb-70062cbbe612"),
                            Nome = "Rio Branco",
                            RegiaoId = 0,
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("0ef60bac-5cab-4df3-b5c2-0e4f98a537d6"),
                            Nome = "Maceió",
                            RegiaoId = 0,
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("86bcc36f-995d-4d88-acbb-dfb72a5de376"),
                            Nome = "Macapá",
                            RegiaoId = 0,
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("07236cb6-25d6-414f-9dc1-fdd0e4a23016"),
                            Nome = "Manaus",
                            RegiaoId = 0,
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("2b64ef76-71b4-4bc7-8d5f-86222f3437be"),
                            Nome = "Salvador",
                            RegiaoId = 0,
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("a84a4ff9-2bf5-4208-89e1-a9c1356ff96d"),
                            Nome = "Fortaleza",
                            RegiaoId = 0,
                            UF = " CE"
                        },
                        new
                        {
                            Id = new Guid("03cb4ccd-7d32-4c9b-b37c-41fbfde1cafc"),
                            Nome = "Brasília",
                            RegiaoId = 0,
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("e68fbf5c-9ccd-4237-afbd-aeec370bad1f"),
                            Nome = "Vitória",
                            RegiaoId = 0,
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("2fad40f3-7f32-46d1-aec8-cc478d452576"),
                            Nome = "Goiânia",
                            RegiaoId = 0,
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("10255e76-b112-4160-b4d9-f4447a825722"),
                            Nome = "São Luís",
                            RegiaoId = 0,
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("f858c956-f64e-4176-967c-6bde6bd0641f"),
                            Nome = "Cuiabá",
                            RegiaoId = 0,
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("ad2f8666-1e08-4dee-8b95-7a1358d85172"),
                            Nome = "Campo Grande",
                            RegiaoId = 0,
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("6a896eb7-86a2-4fa8-b9de-4759860dc8a0"),
                            Nome = "Belo Horizonte",
                            RegiaoId = 0,
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("8eeab87a-4266-47b5-a724-15d0b7b4f28b"),
                            Nome = "Belém",
                            RegiaoId = 0,
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("00288cb2-1cfb-4452-b16d-ac9c940d2c88"),
                            Nome = "João Pessoa",
                            RegiaoId = 0,
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("7bc84c44-82d4-474b-8a17-cd91ebb7ba23"),
                            Nome = "Curitiba",
                            RegiaoId = 0,
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("4ce32d6b-4fc8-46ed-88f3-20e506add8a9"),
                            Nome = "Recife",
                            RegiaoId = 0,
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("5774cd90-50f4-43f5-8983-c8f4f375a4db"),
                            Nome = "Teresina",
                            RegiaoId = 0,
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("589a8488-7e41-4c7b-b922-bef5895efa3c"),
                            Nome = "Rio de Janeiro",
                            RegiaoId = 0,
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("cdaf2ed9-f949-4117-a6ac-bed65e98a731"),
                            Nome = "Natal",
                            RegiaoId = 0,
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("7ee9c6a8-65b5-43d6-aef2-8b1b38902498"),
                            Nome = "Porto Alegre",
                            RegiaoId = 0,
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("16311b64-443c-4692-b4dd-866e0e756c54"),
                            Nome = "Porto Velho",
                            RegiaoId = 0,
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("95c8065b-bde0-4859-afe9-4e05f1624148"),
                            Nome = "Boa Vista",
                            RegiaoId = 0,
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("3acd9ce0-2e50-400c-a87a-6d1814e03fdb"),
                            Nome = "Florianópolis",
                            RegiaoId = 0,
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("164b1e93-be5f-410c-a49d-7ade519f1c89"),
                            Nome = "São Paulo",
                            RegiaoId = 0,
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("87b512fd-167a-4b37-aed7-e4f016d8c6a0"),
                            Nome = "Aracaju",
                            RegiaoId = 0,
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("38a2230d-f24d-4376-bcee-1b113db76601"),
                            Nome = "Palmas",
                            RegiaoId = 0,
                            UF = "TO"
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Regiao");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c432fe82-c393-4352-91af-83b05e7c1d3a"),
                            Nome = "Sul",
                            Status = true
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.HasOne("Fretefy.Test.Domain.Entities.Regiao", null)
                        .WithMany("cidades")
                        .HasForeignKey("RegiaoId1");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Navigation("cidades");
                });
#pragma warning restore 612, 618
        }
    }
}