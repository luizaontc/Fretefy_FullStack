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
    [Migration("20241208144546_AddTabelaRegiao")]
    partial class AddTabelaRegiao
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

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d63f9bf4-b2cc-4d9f-b865-40660cc3c944"),
                            Nome = "Rio Branco",
                            RegiaoId = 0,
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("658c3182-8799-4c1b-b02c-9505613565d0"),
                            Nome = "Maceió",
                            RegiaoId = 0,
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("f3e5b01a-25e8-4825-9f1c-41165e581dc1"),
                            Nome = "Macapá",
                            RegiaoId = 0,
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("efcacda6-5b1a-4497-b494-66407f4b7282"),
                            Nome = "Manaus",
                            RegiaoId = 0,
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("9339a322-5e6c-4a20-8bf4-6c2e79bdc2c0"),
                            Nome = "Salvador",
                            RegiaoId = 0,
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("255ae234-0acd-4648-9259-7a35893c09f9"),
                            Nome = "Fortaleza",
                            RegiaoId = 0,
                            UF = " CE"
                        },
                        new
                        {
                            Id = new Guid("8df8617a-f054-4c7e-a11f-3af201d023b8"),
                            Nome = "Brasília",
                            RegiaoId = 0,
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("19b7fee3-7e31-4ef2-98ba-a1129f608b07"),
                            Nome = "Vitória",
                            RegiaoId = 0,
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("d29a1ed1-54d2-447c-ac46-3bb364bc751a"),
                            Nome = "Goiânia",
                            RegiaoId = 0,
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("402b47f1-540a-4b55-b115-dcdf5d120f6f"),
                            Nome = "São Luís",
                            RegiaoId = 0,
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("8d720be7-bfce-4939-ad9f-7f28c0bc1950"),
                            Nome = "Cuiabá",
                            RegiaoId = 0,
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("b220cd96-aa07-4d5a-a722-d78719694ac6"),
                            Nome = "Campo Grande",
                            RegiaoId = 0,
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("89b37b6d-3a08-45ef-960c-d96d6a2c1dec"),
                            Nome = "Belo Horizonte",
                            RegiaoId = 0,
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("eec30f9d-3168-423b-92a3-c09e01a4f91e"),
                            Nome = "Belém",
                            RegiaoId = 0,
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("6e453e0c-931e-407a-9923-5215fa6b610d"),
                            Nome = "João Pessoa",
                            RegiaoId = 0,
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("387a860f-85b2-4a89-90b3-6ed0649ae3bc"),
                            Nome = "Curitiba",
                            RegiaoId = 0,
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("d255038a-547a-4b09-8fcd-779c6b674d05"),
                            Nome = "Recife",
                            RegiaoId = 0,
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("8ad6950d-2afa-490c-ad47-cc5079ef535f"),
                            Nome = "Teresina",
                            RegiaoId = 0,
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("2d2ffcaa-916d-47dc-8ae7-dc2c491569a3"),
                            Nome = "Rio de Janeiro",
                            RegiaoId = 0,
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("22fffb53-9538-4bb0-8645-1c454b0569f5"),
                            Nome = "Natal",
                            RegiaoId = 0,
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("6b021c1c-2515-4a6f-b684-f08e60525daa"),
                            Nome = "Porto Alegre",
                            RegiaoId = 0,
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("a4843cd2-27e9-4288-9503-6bec12c762ec"),
                            Nome = "Porto Velho",
                            RegiaoId = 0,
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("12636f32-e885-44f4-810a-a6b78492f711"),
                            Nome = "Boa Vista",
                            RegiaoId = 0,
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("f4c3b766-5345-4952-95fe-5c2c4788f9e4"),
                            Nome = "Florianópolis",
                            RegiaoId = 0,
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("159a7f60-1b6c-4d1f-a05a-f81e21554787"),
                            Nome = "São Paulo",
                            RegiaoId = 0,
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("f2fae82b-6a00-4458-83a9-a175ed70ca73"),
                            Nome = "Aracaju",
                            RegiaoId = 0,
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("b3dda8bd-fad3-48af-9a28-d782a5649f8e"),
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
                            Id = new Guid("522819e5-5dee-42b7-b767-8b375be3ef69"),
                            Nome = "Sul",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
