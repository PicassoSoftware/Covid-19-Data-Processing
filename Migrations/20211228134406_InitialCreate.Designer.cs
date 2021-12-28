﻿// <auto-generated />
using System;
using Covid_19_Data_Processing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Covid_19_Data_Processing.Migrations
{
    [DbContext(typeof(CovidContext))]
    [Migration("20211228134406_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Asi", b =>
                {
                    b.Property<string>("TC")
                        .HasColumnType("text");

                    b.Property<DateTime>("AsiOlmaTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("AsiIsmi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PersonelTC")
                        .HasColumnType("text");

                    b.HasKey("TC", "AsiOlmaTarihi");

                    b.HasIndex("PersonelTC");

                    b.ToTable("Asilar");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.CalismaSaati", b =>
                {
                    b.Property<string>("TC")
                        .HasColumnType("text");

                    b.Property<string>("HaftaninGunleri")
                        .HasColumnType("text");

                    b.Property<DateTime>("Baslangic")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Bitis")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PersonelTC")
                        .HasColumnType("text");

                    b.HasKey("TC", "HaftaninGunleri", "Baslangic");

                    b.HasIndex("PersonelTC");

                    b.ToTable("CalismaSaatleri");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.CovidKaydi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PersonellerTC")
                        .HasColumnType("text");

                    b.Property<string>("TC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PersonellerTC");

                    b.ToTable("CovidKayitlari");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.CovidSemptom", b =>
                {
                    b.Property<int>("CovidID")
                        .HasColumnType("integer");

                    b.Property<string>("Semptom")
                        .HasColumnType("text");

                    b.Property<int?>("CovidKaydiID")
                        .HasColumnType("integer");

                    b.HasKey("CovidID", "Semptom");

                    b.HasIndex("CovidKaydiID");

                    b.ToTable("CovidSemptomlari");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.HastalikKaydi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("HastaOlduguTarih")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("HastalikIsmi")
                        .HasColumnType("text");

                    b.Property<string>("PersonelTC")
                        .HasColumnType("text");

                    b.Property<string>("TC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("PersonelTC");

                    b.ToTable("HastalikKayitlari");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.HastalikSemptom", b =>
                {
                    b.Property<int>("HastalikID")
                        .HasColumnType("integer");

                    b.Property<string>("Semptom")
                        .HasColumnType("text");

                    b.Property<int?>("HastalikKaydiID")
                        .HasColumnType("integer");

                    b.HasKey("HastalikID", "Semptom");

                    b.HasIndex("HastalikKaydiID");

                    b.ToTable("HastalikSemptomlari");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Hobi", b =>
                {
                    b.Property<string>("TC")
                        .HasColumnType("text");

                    b.Property<string>("HobiIsmi")
                        .HasColumnType("text");

                    b.Property<string>("PersonelTC")
                        .HasColumnType("text");

                    b.HasKey("TC", "HobiIsmi");

                    b.HasIndex("PersonelTC");

                    b.ToTable("Hobiler");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Kronik", b =>
                {
                    b.Property<string>("CovidID")
                        .HasColumnType("text");

                    b.Property<string>("Hastalik")
                        .HasColumnType("text");

                    b.Property<int?>("CovidKaydiID")
                        .HasColumnType("integer");

                    b.HasKey("CovidID", "Hastalik");

                    b.HasIndex("CovidKaydiID");

                    b.ToTable("Kronikler");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Personel", b =>
                {
                    b.Property<string>("TC")
                        .HasColumnType("text");

                    b.Property<int>("DogduguSehir")
                        .HasColumnType("integer");

                    b.Property<int>("Egitim")
                        .HasColumnType("integer");

                    b.Property<string>("KanGrubu")
                        .HasColumnType("text");

                    b.Property<int>("Maas")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pozisyon")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("TC");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Recete", b =>
                {
                    b.Property<int>("HastalikID")
                        .HasColumnType("integer");

                    b.Property<string>("Ilac")
                        .HasColumnType("text");

                    b.Property<int>("Doz")
                        .HasColumnType("integer");

                    b.Property<int?>("HastalikKaydiID")
                        .HasColumnType("integer");

                    b.HasKey("HastalikID", "Ilac");

                    b.HasIndex("HastalikKaydiID");

                    b.ToTable("Receteler");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Temasli", b =>
                {
                    b.Property<int>("CovidID")
                        .HasColumnType("integer");

                    b.Property<string>("TemasliTC")
                        .HasColumnType("text");

                    b.Property<int?>("CovidKaydiID")
                        .HasColumnType("integer");

                    b.Property<string>("PersonelTC")
                        .HasColumnType("text");

                    b.HasKey("CovidID", "TemasliTC");

                    b.HasIndex("CovidKaydiID");

                    b.HasIndex("PersonelTC");

                    b.ToTable("Temaslilar");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Asi", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.Personel", "Personel")
                        .WithMany("Asilar")
                        .HasForeignKey("PersonelTC");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.CalismaSaati", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.Personel", "Personel")
                        .WithMany("CalismaSaatleri")
                        .HasForeignKey("PersonelTC");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.CovidKaydi", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.Personel", "Personeller")
                        .WithMany("CovidKayitlari")
                        .HasForeignKey("PersonellerTC");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.CovidSemptom", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.CovidKaydi", "CovidKaydi")
                        .WithMany("CovidSemptomlari")
                        .HasForeignKey("CovidKaydiID");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.HastalikKaydi", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.Personel", "Personel")
                        .WithMany("HastalikKayitlari")
                        .HasForeignKey("PersonelTC");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.HastalikSemptom", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.HastalikKaydi", "HastalikKaydi")
                        .WithMany("HastalikSemptomlari")
                        .HasForeignKey("HastalikKaydiID");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Hobi", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.Personel", "Personel")
                        .WithMany("Hobiler")
                        .HasForeignKey("PersonelTC");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Kronik", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.CovidKaydi", "CovidKaydi")
                        .WithMany("KronikHastaliklar")
                        .HasForeignKey("CovidKaydiID");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Recete", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.HastalikKaydi", "HastalikKaydi")
                        .WithMany("Receteler")
                        .HasForeignKey("HastalikKaydiID");
                });

            modelBuilder.Entity("Covid_19_Data_Processing.Models.Temasli", b =>
                {
                    b.HasOne("Covid_19_Data_Processing.Models.CovidKaydi", "CovidKaydi")
                        .WithMany("Temaslilar")
                        .HasForeignKey("CovidKaydiID");

                    b.HasOne("Covid_19_Data_Processing.Models.Personel", "Personel")
                        .WithMany("TemasEttigiCovidler")
                        .HasForeignKey("PersonelTC");
                });
#pragma warning restore 612, 618
        }
    }
}
