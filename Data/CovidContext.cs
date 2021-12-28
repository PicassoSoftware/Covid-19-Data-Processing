using Covid_19_Data_Processing.Models;
using Microsoft.EntityFrameworkCore;

namespace Covid_19_Data_Processing.Data
{
    public class CovidContext : DbContext
    {
        public CovidContext(DbContextOptions<CovidContext> opt) : base(opt)
        {

        }


        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Asi> Asilar { get; set; }
        public DbSet<CalismaSaati> CalismaSaatleri { get; set; }
        public DbSet<CovidKaydi> CovidKayitlari { get; set; }
        public DbSet<CovidSemptom> CovidSemptomlari { get; set; }
        public DbSet<HastalikKaydi> HastalikKayitlari { get; set; }
        public DbSet<HastalikSemptom> HastalikSemptomlari { get; set; }
        public DbSet<Hobi> Hobiler { get; set; }
        public DbSet<Recete> Receteler { get; set; }
        public DbSet<Temasli> Temaslilar { get; set; }
        public DbSet<Kronik> Kronikler { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Asi>()
                .HasKey(c => new { c.TC, c.AsiOlmaTarihi });

            builder.Entity<CalismaSaati>()
                .HasKey(c => new { c.TC, c.HaftaninGunleri, c.Baslangic });

            builder.Entity<CovidSemptom>()
                .HasKey(c => new { c.CovidID, c.Semptom });

            builder.Entity<HastalikSemptom>()
                .HasKey(c => new { c.HastalikID, c.Semptom });

            builder.Entity<Hobi>()
                .HasKey(c => new { c.TC, c.HobiIsmi });

            builder.Entity<Kronik>()
                .HasKey(c => new { c.CovidID, c.Hastalik });

            builder.Entity<Recete>()
                .HasKey(c => new { c.HastalikID, c.Ilac });

            builder.Entity<Temasli>()
                .HasKey(c => new { c.CovidID, c.TemasliTC });






                
            builder.Entity<Asi>()
                    .Property(t => t.AsiIsmi)
                    .IsRequired();

            builder.Entity<CalismaSaati>()
                    .Property(t => t.Bitis)
                    .IsRequired();

            builder.Entity<CovidKaydi>()
                    .Property(t => t.TC)
                    .IsRequired();

            builder.Entity<HastalikKaydi>()
                    .Property(t => t.TC)
                    .IsRequired();

            builder.Entity<Personel>()
                    .Property(t => t.Name)
                    .IsRequired();
            
             builder.Entity<Recete>()
                    .Property(t => t.Doz)
                    .IsRequired();

        }
    }
}