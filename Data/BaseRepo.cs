using System;
using Covid_19_Data_Processing.Models;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Covid_19_Data_Processing.DTOs;
using System.Collections.Generic;

namespace Covid_19_Data_Processing.Data
{
    public class BaseRepo : IBaseRepo
    {

        private readonly CovidContext _context;
        private readonly IMapper _mapper;

        public BaseRepo(CovidContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddAsi(Asi element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.Asilar.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AddCalismaSaaatleri(CalismaSaati element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.CalismaSaatleri.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AddCovidKaydi(PostCovidKaydi element)
        {
            var db_element = _mapper.Map<CovidKaydi>(element);

            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.CovidKayitlari.Add(db_element);
            await _context.SaveChangesAsync();
        }

        public async Task AddHastalikKaydi(PostHastalikKaydi element)
        {
            var db_element = _mapper.Map<HastalikKaydi>(element);

            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.HastalikKayitlari.Add(db_element);
            await _context.SaveChangesAsync();
        }

        public async Task AddPersonel(Personel element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.Personeller.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AddRecete(Recete element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.Receteler.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AsiEtkinlikBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task AsisizEnUzunCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task<AsiCovidOran> AsiyaGoreCovidBilgisi()
        {
            List<string> asi_olanlar = (from asi in _context.Asilar select asi.TC).ToList();
            List<string> personeller = (from personel in _context.Personeller select personel.TC).ToList();
            List<string> covidliler = (from covidli in _context.CovidKayitlari select covidli.TC).ToList();
            int covidli_ve_asili = 0, covidli_ve_asisiz = 0, asisiz = 0;

            foreach (var covidli in covidliler)
            {
                if (asi_olanlar.Contains(covidli)) covidli_ve_asili++;
            }

            covidli_ve_asisiz = covidliler.Count() - covidli_ve_asili;
            asisiz = personeller.Count() - asi_olanlar.Count();

            Console.WriteLine((covidli_ve_asili).ToString());
            return new AsiCovidOran
            {
                Asili = covidli_ve_asili / asi_olanlar.Count(),
                Asisiz = covidli_ve_asisiz / asisiz
            };
        }

        public async Task BiontechVeHastalikCovidBilgisi(string hastalik)
        {
            throw new NotImplementedException();
        }

        public async Task CovidBelirtileri()
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsi(string tc, DateTime asi_olma_tarihi)
        {
            if (tc.Length != 11)
            {
                _context.Asilar.Remove(new Asi
                {
                    TC = tc,
                    AsiOlmaTarihi = asi_olma_tarihi
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteCalismaSaati(string tc)
        {
            if (tc.Length != 11)
            {
                _context.CalismaSaatleri.Remove(new CalismaSaati
                {
                    TC = tc,
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteCovidKaydi(string tc, DateTime baslangic_tarihi)
        {
            if (tc.Length != 11)
            {
                _context.CovidKayitlari.Remove(new CovidKaydi
                {
                    TC = tc,
                    BaslangicTarihi = baslangic_tarihi
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteHastalikKaydi(string tc)
        {

            if (tc.Length != 11)
            {
                _context.HastalikKayitlari.Remove(new HastalikKaydi
                {
                    TC = tc,
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeletePersonel(string tc)
        {
            if (tc.Length != 11)
            {
                _context.Personeller.Remove(new Personel
                {
                    TC = tc,
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteRecete(int hastalik_id)
        {
            if (hastalik_id > 0)
            {
                _context.Receteler.Remove(new Recete
                {
                    HastalikID = hastalik_id
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task EgitimCovidIstatistikBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task TemasBagimlilari()
        {
            throw new NotImplementedException();
        }

        public async Task EnYayginHastalikBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task HaftasonuCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task HastalananlarinCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CalisanCovidBilgisi>> IlacaGoreCovid(string ilac)
        {
            List<CalisanCovidBilgisi> ans = new List<CalisanCovidBilgisi>();
            IEnumerable<int> hastalik_ids = (from recete in _context.Receteler where recete.Ilac == ilac select recete.HastalikID).ToList();

            IEnumerable<string> tcs = (from hastalik_kayidi in _context.HastalikKayitlari where hastalik_ids.Contains(hastalik_kayidi.ID) select hastalik_kayidi.TC).ToList();

            foreach (var tc in tcs)
            {
                ans.Add(new CalisanCovidBilgisi { TC = tc, CovidDurumu = (_context.CovidKayitlari.Any(c => (c.TC == tc)) ? true : false) });
            }

            return ans;
        }

        public async Task KanGrubuCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task KronikCovidSuresiBilgisi(string kronik)
        {
            throw new NotImplementedException();
        }

        public async Task CovidIstatistikBilgisi()
        {
            throw new NotImplementedException();
        }

        public async Task SehirHastalikBilgisi(string sehir)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsi(string tc, DateTime asi_olma_tarihi, Asi element)
        {
            var db_element = await _context.Asilar.FindAsync(new { tc, asi_olma_tarihi });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.AsiOlmaTarihi != new DateTime(1, 1, 1)) db_element.AsiOlmaTarihi = element.AsiOlmaTarihi;
            if (element.AsiIsmi.Length != 0) db_element.AsiIsmi = element.AsiIsmi;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateCalismaSaati(string tc, CalismaSaati element)
        {
            var db_element = await _context.CalismaSaatleri.FindAsync(tc);

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.HaftaninGunleri.Length != 0) db_element.HaftaninGunleri = element.HaftaninGunleri;
            if (element.Baslangic != new DateTime(1, 1, 1)) db_element.Baslangic = element.Baslangic;
            if (element.Bitis != new DateTime(1, 1, 1)) db_element.Bitis = element.Bitis;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateCovidKaydi(string tc, DateTime baslangic_tarihi, CovidKaydi element)
        {
            var db_element = await _context.CovidKayitlari.FindAsync(new { tc, baslangic_tarihi });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.BaslangicTarihi != new DateTime(1, 1, 1)) db_element.BaslangicTarihi = element.BaslangicTarihi;
            if (element.BitisTarihi != new DateTime(1, 1, 1)) db_element.BitisTarihi = element.BitisTarihi;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateHastalikKaydi(string tc, HastalikKaydi element)
        {
            var db_element = await _context.HastalikKayitlari.FindAsync(tc);

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.HastalikIsmi.Length != 0) db_element.HastalikIsmi = element.HastalikIsmi;
            if (element.HastaOlduguTarih != new DateTime(1, 1, 1)) db_element.HastaOlduguTarih = element.HastaOlduguTarih;

            await _context.SaveChangesAsync();
        }

        public async Task UpdatePersonel(string tc, Personel element)
        {
            var db_element = await _context.Personeller.FindAsync(tc);

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.Name.Length != 0) db_element.Name = element.Name;
            if (element.Surname.Length != 0) db_element.Surname = element.Surname;
            if (element.KanGrubu.Length != 0) db_element.KanGrubu = element.KanGrubu;
            if (element.DogduguSehir.Length != 0) db_element.DogduguSehir = element.DogduguSehir;
            if (element.Pozisyon.Length != 0) db_element.Pozisyon = element.Pozisyon;
            if (element.Maas != -1) db_element.Maas = element.Maas;
            if (element.Egitim != -1) db_element.Egitim = element.Egitim;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateRecete(int hastalik_id, string ilac, Recete element)
        {
            var db_element = await _context.Receteler.FindAsync(new { hastalik_id, ilac });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.Ilac.Length != 0) db_element.Ilac = element.Ilac;
            if (element.HastalikID != 0) db_element.HastalikID = element.HastalikID;
            if (element.Doz != 0) db_element.Doz = element.Doz;


            await _context.SaveChangesAsync();
        }

        public async Task YayginIlacCovidBilgisi()
        {
            throw new NotImplementedException();
        }

    }
}