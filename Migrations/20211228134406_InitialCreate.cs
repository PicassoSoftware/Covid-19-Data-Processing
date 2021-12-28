using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Covid_19_Data_Processing.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    TC = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    KanGrubu = table.Column<string>(nullable: true),
                    DogduguSehir = table.Column<int>(nullable: false),
                    Pozisyon = table.Column<string>(nullable: true),
                    Maas = table.Column<int>(nullable: false),
                    Egitim = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.TC);
                });

            migrationBuilder.CreateTable(
                name: "Asilar",
                columns: table => new
                {
                    TC = table.Column<string>(nullable: false),
                    AsiOlmaTarihi = table.Column<DateTime>(nullable: false),
                    AsiIsmi = table.Column<string>(nullable: false),
                    PersonelTC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asilar", x => new { x.TC, x.AsiOlmaTarihi });
                    table.ForeignKey(
                        name: "FK_Asilar_Personeller_PersonelTC",
                        column: x => x.PersonelTC,
                        principalTable: "Personeller",
                        principalColumn: "TC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalismaSaatleri",
                columns: table => new
                {
                    TC = table.Column<string>(nullable: false),
                    HaftaninGunleri = table.Column<string>(nullable: false),
                    Baslangic = table.Column<DateTime>(nullable: false),
                    Bitis = table.Column<DateTime>(nullable: false),
                    PersonelTC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSaatleri", x => new { x.TC, x.HaftaninGunleri, x.Baslangic });
                    table.ForeignKey(
                        name: "FK_CalismaSaatleri_Personeller_PersonelTC",
                        column: x => x.PersonelTC,
                        principalTable: "Personeller",
                        principalColumn: "TC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CovidKayitlari",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TC = table.Column<string>(nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    PersonellerTC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidKayitlari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CovidKayitlari_Personeller_PersonellerTC",
                        column: x => x.PersonellerTC,
                        principalTable: "Personeller",
                        principalColumn: "TC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HastalikKayitlari",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TC = table.Column<string>(nullable: false),
                    HastalikIsmi = table.Column<string>(nullable: true),
                    HastaOlduguTarih = table.Column<DateTime>(nullable: false),
                    PersonelTC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastalikKayitlari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HastalikKayitlari_Personeller_PersonelTC",
                        column: x => x.PersonelTC,
                        principalTable: "Personeller",
                        principalColumn: "TC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hobiler",
                columns: table => new
                {
                    TC = table.Column<string>(nullable: false),
                    HobiIsmi = table.Column<string>(nullable: false),
                    PersonelTC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobiler", x => new { x.TC, x.HobiIsmi });
                    table.ForeignKey(
                        name: "FK_Hobiler_Personeller_PersonelTC",
                        column: x => x.PersonelTC,
                        principalTable: "Personeller",
                        principalColumn: "TC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CovidSemptomlari",
                columns: table => new
                {
                    CovidID = table.Column<int>(nullable: false),
                    Semptom = table.Column<string>(nullable: false),
                    CovidKaydiID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidSemptomlari", x => new { x.CovidID, x.Semptom });
                    table.ForeignKey(
                        name: "FK_CovidSemptomlari_CovidKayitlari_CovidKaydiID",
                        column: x => x.CovidKaydiID,
                        principalTable: "CovidKayitlari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kronikler",
                columns: table => new
                {
                    CovidID = table.Column<string>(nullable: false),
                    Hastalik = table.Column<string>(nullable: false),
                    CovidKaydiID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kronikler", x => new { x.CovidID, x.Hastalik });
                    table.ForeignKey(
                        name: "FK_Kronikler_CovidKayitlari_CovidKaydiID",
                        column: x => x.CovidKaydiID,
                        principalTable: "CovidKayitlari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Temaslilar",
                columns: table => new
                {
                    CovidID = table.Column<int>(nullable: false),
                    TemasliTC = table.Column<string>(nullable: false),
                    CovidKaydiID = table.Column<int>(nullable: true),
                    PersonelTC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temaslilar", x => new { x.CovidID, x.TemasliTC });
                    table.ForeignKey(
                        name: "FK_Temaslilar_CovidKayitlari_CovidKaydiID",
                        column: x => x.CovidKaydiID,
                        principalTable: "CovidKayitlari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Temaslilar_Personeller_PersonelTC",
                        column: x => x.PersonelTC,
                        principalTable: "Personeller",
                        principalColumn: "TC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HastalikSemptomlari",
                columns: table => new
                {
                    HastalikID = table.Column<int>(nullable: false),
                    Semptom = table.Column<string>(nullable: false),
                    HastalikKaydiID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastalikSemptomlari", x => new { x.HastalikID, x.Semptom });
                    table.ForeignKey(
                        name: "FK_HastalikSemptomlari_HastalikKayitlari_HastalikKaydiID",
                        column: x => x.HastalikKaydiID,
                        principalTable: "HastalikKayitlari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receteler",
                columns: table => new
                {
                    HastalikID = table.Column<int>(nullable: false),
                    Ilac = table.Column<string>(nullable: false),
                    Doz = table.Column<int>(nullable: false),
                    HastalikKaydiID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receteler", x => new { x.HastalikID, x.Ilac });
                    table.ForeignKey(
                        name: "FK_Receteler_HastalikKayitlari_HastalikKaydiID",
                        column: x => x.HastalikKaydiID,
                        principalTable: "HastalikKayitlari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asilar_PersonelTC",
                table: "Asilar",
                column: "PersonelTC");

            migrationBuilder.CreateIndex(
                name: "IX_CalismaSaatleri_PersonelTC",
                table: "CalismaSaatleri",
                column: "PersonelTC");

            migrationBuilder.CreateIndex(
                name: "IX_CovidKayitlari_PersonellerTC",
                table: "CovidKayitlari",
                column: "PersonellerTC");

            migrationBuilder.CreateIndex(
                name: "IX_CovidSemptomlari_CovidKaydiID",
                table: "CovidSemptomlari",
                column: "CovidKaydiID");

            migrationBuilder.CreateIndex(
                name: "IX_HastalikKayitlari_PersonelTC",
                table: "HastalikKayitlari",
                column: "PersonelTC");

            migrationBuilder.CreateIndex(
                name: "IX_HastalikSemptomlari_HastalikKaydiID",
                table: "HastalikSemptomlari",
                column: "HastalikKaydiID");

            migrationBuilder.CreateIndex(
                name: "IX_Hobiler_PersonelTC",
                table: "Hobiler",
                column: "PersonelTC");

            migrationBuilder.CreateIndex(
                name: "IX_Kronikler_CovidKaydiID",
                table: "Kronikler",
                column: "CovidKaydiID");

            migrationBuilder.CreateIndex(
                name: "IX_Receteler_HastalikKaydiID",
                table: "Receteler",
                column: "HastalikKaydiID");

            migrationBuilder.CreateIndex(
                name: "IX_Temaslilar_CovidKaydiID",
                table: "Temaslilar",
                column: "CovidKaydiID");

            migrationBuilder.CreateIndex(
                name: "IX_Temaslilar_PersonelTC",
                table: "Temaslilar",
                column: "PersonelTC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asilar");

            migrationBuilder.DropTable(
                name: "CalismaSaatleri");

            migrationBuilder.DropTable(
                name: "CovidSemptomlari");

            migrationBuilder.DropTable(
                name: "HastalikSemptomlari");

            migrationBuilder.DropTable(
                name: "Hobiler");

            migrationBuilder.DropTable(
                name: "Kronikler");

            migrationBuilder.DropTable(
                name: "Receteler");

            migrationBuilder.DropTable(
                name: "Temaslilar");

            migrationBuilder.DropTable(
                name: "HastalikKayitlari");

            migrationBuilder.DropTable(
                name: "CovidKayitlari");

            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
