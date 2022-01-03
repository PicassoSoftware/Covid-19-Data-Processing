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

        public async Task AddCovidSemptom(CovidSemptom element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.CovidSemptomlari.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AddKronik(Kronik element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.Kronikler.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AddCalismaSaati(CalismaSaati element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.CalismaSaatleri.Add(element);
            await _context.SaveChangesAsync();
        }

        public async Task AddTemasli(Temasli element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.Temaslilar.Add(element);
            await _context.SaveChangesAsync();
        }
        public async Task AddHastalikSemptom(HastalikSemptom element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.HastalikSemptomlari.Add(element);
            await _context.SaveChangesAsync();
        }
        public async Task AddHobi(Hobi element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            _context.Hobiler.Add(element);
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
        public async Task UpdateKronik(int covid_id, string hastalik, Kronik element)
        {
            var db_element = await _context.Kronikler.FindAsync(new { covid_id, hastalik });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.CovidID != -1) db_element.CovidID = element.CovidID;
            if (element.Hastalik.Length != 0) db_element.Hastalik = element.Hastalik;

            await _context.SaveChangesAsync();
        }
        public async Task UpdateTemasli(string temasli_tc, int covid_id, Temasli element)
        {
            var db_element = await _context.Temaslilar.FindAsync(new { covid_id, temasli_tc });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.CovidID != -1) db_element.CovidID = element.CovidID;
            if (element.TemasliTC.Length != 0) db_element.TemasliTC = element.TemasliTC;



            await _context.SaveChangesAsync();
        }
        public async Task UpdateHastalikSemptom(string semptom, int hastalik_id, HastalikSemptom element)
        {
            var db_element = await _context.HastalikSemptomlari.FindAsync(new { semptom, hastalik_id });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.Semptom.Length != 0) db_element.Semptom = element.Semptom;
            if (element.HastalikID != -1) db_element.HastalikID = element.HastalikID;

            await _context.SaveChangesAsync();
        }
        public async Task UpdateHobi(string tc, string hobi_ismi, Hobi element)
        {
            var db_element = await _context.Hobiler.FindAsync(new { tc, hobi_ismi });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.HobiIsmi.Length != 0) db_element.HobiIsmi = element.HobiIsmi;

            await _context.SaveChangesAsync();
        }
        public async Task UpdateCovidSemptom(int covid_id, string semptom, CovidSemptom element)
        {
            var db_element = await _context.CovidSemptomlari.FindAsync(new { covid_id, semptom });

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.CovidID != -1) db_element.CovidID = element.CovidID;
            if (element.Semptom.Length != 0) db_element.Semptom = element.Semptom;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateCalismaSaati(string tc, int haftanin_gunleri, TimeSpan baslangic, CalismaSaati element)
        {
            var db_element = await _context.CalismaSaatleri.FindAsync(tc);

            if (db_element == null)
            {
                throw new ArgumentNullException();
            }

            if (element.TC.Length != 0) db_element.TC = element.TC;
            if (element.HaftaninGunleri != -1) db_element.HaftaninGunleri = element.HaftaninGunleri;
            if (element.Baslangic != new TimeSpan(1, 1, 1)) db_element.Baslangic = element.Baslangic;
            if (element.Bitis != new TimeSpan(1, 1, 1)) db_element.Bitis = element.Bitis;

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

        public async Task UpdateHastalikKaydi(int id, HastalikKaydi element)
        {
            var db_element = await _context.HastalikKayitlari.FindAsync(id);

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

        public async Task DeleteCovidSemptom(int covid_id, string semptom)
        {
            if (covid_id > 0)
            {
                _context.CovidSemptomlari.Remove(new CovidSemptom
                {
                    CovidID = covid_id,
                    Semptom = semptom
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public async Task DeleteHastalikKaydi(int id)
        {
            if (id > 0)
            {
                _context.CovidKayitlari.Remove(new CovidKaydi
                {
                    ID = id
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public async Task DeleteHobi(string tc, string hobi_ismi)
        {
            if (tc.Length != 11)
            {
                _context.Hobiler.Remove(new Hobi
                {
                    TC = tc,
                    HobiIsmi = hobi_ismi
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteTemasli(string temasli_tc, int covid_id)
        {
            if (temasli_tc.Length != 11)
            {
                _context.Temaslilar.Remove(new Temasli
                {
                    TemasliTC = temasli_tc,
                    CovidID = covid_id
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public async Task DeleteKronik(int covid_id, string hastalik_kaydi)
        {
            if (covid_id > 0)
            {
                _context.Kronikler.Remove(new Kronik
                {
                    CovidID = covid_id,
                    Hastalik = hastalik_kaydi
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteCalismaSaati(string tc, int haftanin_gunleri, TimeSpan baslangic)
        {
            if (tc.Length != 11)
            {
                _context.CalismaSaatleri.Remove(new CalismaSaati
                {
                    TC = tc,
                    HaftaninGunleri = haftanin_gunleri,
                    Baslangic = baslangic
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

        public async Task DeleteRecete(int hastalik_id, string ilac)
        {
            if (hastalik_id > 0)
            {
                _context.Receteler.Remove(new Recete
                {
                    HastalikID = hastalik_id,
                    Ilac = ilac
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public async Task DeleteHastalikSemptom(string semptom, int hastalik_id)
        {
            if (hastalik_id > 0)
            {
                _context.HastalikSemptomlari.Remove(new HastalikSemptom
                {
                    Semptom = semptom,
                    HastalikID = hastalik_id
                });

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }










































        public string AsiEtkinlikBilgisi()
        {
            List<string> biontechliler = (from asi in _context.Asilar where asi.AsiIsmi == "biontech" select asi.TC).ToList();
            List<string> sinovaclilar = (from asi in _context.Asilar where asi.AsiIsmi == "sinovac" select asi.TC).ToList();

            double bavarage = (from covidli in _context.CovidKayitlari where biontechliler.Contains(covidli.TC) select (covidli.BitisTarihi - covidli.BaslangicTarihi).TotalDays).ToList().Average();
            double savarage = (from covidli in _context.CovidKayitlari where sinovaclilar.Contains(covidli.TC) select (covidli.BitisTarihi - covidli.BaslangicTarihi).TotalDays).ToList().Average();

            if (bavarage > savarage) return string.Format("Sinovac bionteche oranla {0}% daha etkilidir.", bavarage / savarage);
            else if (savarage > bavarage) return string.Format(" Biontech sinovaca oranla {0}% daha etkilidir.", savarage / bavarage);
            else return "Biontech ve sinovac aynı etkiye sahiptir.";
        }

        public AsisizEnUzunCovid AsisizEnUzunCovidBilgisi()
        {
            List<string> asili = (from asi in _context.Asilar select asi.TC).ToList();
            List<string> asisiz = (from personel in _context.Personeller where !asili.Contains(personel.TC) select personel.TC).ToList();
            AsisizEnUzunCovid ans = new AsisizEnUzunCovid();
            Console.WriteLine(DateTime.Today.AddYears(-1));
            string aranan_tc = (from covidli in _context.CovidKayitlari where asisiz.Contains(covidli.TC) orderby covidli.BitisTarihi - covidli.BaslangicTarihi select covidli.TC).ToList().ElementAt(0);
            List<HastalikKaydi> kayitlar = (from kayit in _context.HastalikKayitlari where kayit.TC == aranan_tc && kayit.HastaOlduguTarih.CompareTo(DateTime.Today.AddYears(-1)) >= 0 select kayit).ToList();
            List<int> ids = (from kayit in kayitlar select kayit.ID).ToList();
            ans.Receteler = (from recete in _context.Receteler where ids.Contains(recete.HastalikID) select recete).ToList();

            ans.Tc = aranan_tc;
            ans.Hastaliklar = (from kayit in kayitlar select kayit.HastalikIsmi).ToList();

            return ans;
        }

        public AsiCovidOran AsiyaGoreCovidBilgisi()
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

            return new AsiCovidOran
            {
                Asili = (double)covidli_ve_asili / asi_olanlar.Count(),
                Asisiz = (double)covidli_ve_asisiz / asisiz
            };
        }

        public  List<string> BiontechVeHastalikCovidBilgisi(string hastalik)
        {
            List<string> biontechliler = (from asi in _context.Asilar where asi.AsiIsmi == "biontech" select asi.TC).ToList();
            List<string> hastalar = (from hasta in _context.HastalikKayitlari where hasta.HastalikIsmi == hastalik select hasta.TC).ToList();

            return (from covidli in _context.CovidKayitlari where biontechliler.Contains(covidli.TC) && hastalar.Contains(covidli.TC) select covidli.TC).ToList();
        }

        public  IEnumerable<string> CovidBelirtileri()
        {
            return (from semptom in _context.CovidSemptomlari.GroupBy(c => c.Semptom) orderby semptom.Count() descending select semptom.Key).ToList().Take(3);
        }



        public  EgitimCovidIstatistik EgitimCovidIstatistikBilgisi()
        {
            List<string> doktora_yapanlar = (from personel in _context.Personeller where personel.Egitim == 3 select personel.TC).ToList();
            List<string> yuksek_lisans_yapanlar = (from personel in _context.Personeller where personel.Egitim == 2 select personel.TC).ToList();
            List<string> lisans_yapanlar = (from personel in _context.Personeller where personel.Egitim == 1 select personel.TC).ToList();
            List<string> diger = (from personel in _context.Personeller where personel.Egitim == 0 select personel.TC).ToList();
            List<string> covidliler = (from covidli in _context.CovidKayitlari select covidli.TC).ToList();

            int doktora = 0, yuksek_lisans = 0, lisans = 0, geriye_kalan = 0;

            foreach (var tc in doktora_yapanlar) if (covidliler.Contains(tc)) doktora++;
            foreach (var tc in yuksek_lisans_yapanlar) if (covidliler.Contains(tc)) yuksek_lisans++;
            foreach (var tc in lisans_yapanlar) if (covidliler.Contains(tc)) lisans++;
            foreach (var tc in diger) if (covidliler.Contains(tc)) geriye_kalan++;

            return new EgitimCovidIstatistik
            {
                Lisans = (double)lisans / lisans_yapanlar.Count(),
                YuksekLisans = (double)yuksek_lisans / yuksek_lisans_yapanlar.Count(),
                Doktora = (double)doktora / doktora_yapanlar.Count(),
                Diger = (double)geriye_kalan / diger.Count()
            };


        }

        public IEnumerable<string> TemasBagimlilari()
        {
            return (from temasli in _context.Temaslilar.GroupBy(c => c.TemasliTC) orderby temasli.Count() select temasli.Key).ToList().Take(3);
        }

        public List<HastalikPersonel> EnYayginHastalikBilgisi()
        {
            IEnumerable<string> yaygin_hastalik = (from hasta in _context.HastalikKayitlari.GroupBy(c => c.HastalikIsmi) orderby hasta.Count() descending select hasta.Key).ToList().Take(3);



            List<HastalikPersonel> ans = new List<HastalikPersonel>();

            foreach (var hastalik in yaygin_hastalik)
            {
                List<string> tcs = (from kayit in _context.HastalikKayitlari where hastalik == kayit.HastalikIsmi select kayit.TC).ToList();
                ans.Add(new HastalikPersonel { hastalik = hastalik, TC = tcs });
            }

            return ans;
        }

        public string HaftasonuCovidBilgisi()
        {
            List<string> tcs = (from calisma in _context.CalismaSaatleri where calisma.HaftaninGunleri == 6 || calisma.HaftaninGunleri == 7 select calisma.TC).ToList();

            List<string> covidliler = (from covidli in _context.CovidKayitlari where tcs.Contains(covidli.TC) select covidli.TC).ToList();

            return string.Format("Haftasonu çalışan {0} kişiden {1} kişi covide yakalanmış.", tcs.Count(), covidliler.Count());
        }

        public List<CalisanCovidBilgisi> HastalananlarinCovidBilgisi()
        {
            IEnumerable<string> tcs = (from hastalik in _context.HastalikKayitlari.GroupBy(c => c.TC) orderby hastalik.Count() select hastalik.Key).ToList().Take(10);

            List<string> covidliler = (from covidli in _context.CovidKayitlari where tcs.Contains(covidli.TC) && covidli.BaslangicTarihi.CompareTo(DateTime.Today.AddMonths(-1)) >= 0 select covidli.TC).ToList();

            List<CalisanCovidBilgisi> ans = new List<CalisanCovidBilgisi>();

            foreach (var tc in tcs)
            {
                ans.Add(new CalisanCovidBilgisi { TC = tc, CovidDurumu = covidliler.Contains(tc) ? true : false });
            }

            return ans;
        }

        public List<CalisanCovidBilgisi> IlacaGoreCovid(string ilac)
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

        public IEnumerable<KanGrubuCovid> KanGrubuCovidBilgisi()
        {

            List<string> butun_a_arti = (from personel in _context.Personeller where personel.KanGrubu == "A+" select personel.TC).ToList();
            List<string> butun_a_eksi = (from personel in _context.Personeller where personel.KanGrubu == "A-" select personel.TC).ToList();
            List<string> butun_b_arti = (from personel in _context.Personeller where personel.KanGrubu == "B+" select personel.TC).ToList();
            List<string> butun_b_eksi = (from personel in _context.Personeller where personel.KanGrubu == "B-" select personel.TC).ToList();
            List<string> butun_ab_arti = (from personel in _context.Personeller where personel.KanGrubu == "AB+" select personel.TC).ToList();
            List<string> butun_ab_eksi = (from personel in _context.Personeller where personel.KanGrubu == "AB-" select personel.TC).ToList();
            List<string> butun_0_arti = (from personel in _context.Personeller where personel.KanGrubu == "0+" select personel.TC).ToList();
            List<string> butun_0_eksi = (from personel in _context.Personeller where personel.KanGrubu == "0-" select personel.TC).ToList();

            List<string> covidliler = (from covidli in _context.CovidKayitlari select covidli.TC).ToList();
            List<KanGrubuCovid> ans = new List<KanGrubuCovid>();

            int covidli_a_arti = 0, covidli_a_eksi = 0, covidli_b_arti = 0, covidli_b_eksi = 0, covidli_ab_arti = 0, covidli_ab_eksi = 0, covidli_0_arti = 0, covidli_0_eksi = 0;

            foreach (var tc in butun_a_arti) if (covidliler.Contains(tc)) covidli_a_arti++;
            foreach (var tc in butun_a_eksi) if (covidliler.Contains(tc)) covidli_a_eksi++;
            foreach (var tc in butun_b_arti) if (covidliler.Contains(tc)) covidli_b_arti++;
            foreach (var tc in butun_b_eksi) if (covidliler.Contains(tc)) covidli_b_eksi++;
            foreach (var tc in butun_ab_arti) if (covidliler.Contains(tc)) covidli_ab_arti++;
            foreach (var tc in butun_ab_eksi) if (covidliler.Contains(tc)) covidli_ab_eksi++;
            foreach (var tc in butun_0_arti) if (covidliler.Contains(tc)) covidli_0_arti++;
            foreach (var tc in butun_0_eksi) if (covidliler.Contains(tc)) covidli_0_eksi++;

            ans.Add(new KanGrubuCovid { KanGrubu = "A+", Yogunluk = (double)covidli_a_arti / butun_a_arti.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "A-", Yogunluk = (double)covidli_a_eksi / butun_a_eksi.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "B+", Yogunluk = (double)covidli_b_arti / butun_b_arti.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "B-", Yogunluk = (double)covidli_b_eksi / butun_b_eksi.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "AB+", Yogunluk = (double)covidli_ab_arti / butun_ab_arti.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "AB-", Yogunluk = (double)covidli_ab_eksi / butun_ab_eksi.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "0+", Yogunluk = (double)covidli_0_arti / butun_0_arti.Count() });
            ans.Add(new KanGrubuCovid { KanGrubu = "0-", Yogunluk = (double)covidli_0_eksi / butun_0_eksi.Count() });

            return ans;
        }

        public List<KronikCovidSure> KronikCovidSuresiBilgisi(string kronik)
        {
            List<int> feriha = (from kr in _context.Kronikler where kr.Hastalik == kronik select kr.CovidID).ToList();
            return (from covidliler in _context.CovidKayitlari where feriha.Contains(covidliler.ID) select new KronikCovidSure { TC = covidliler.TC, IyilesmeSuresi = (int)(covidliler.BitisTarihi - covidliler.BaslangicTarihi).TotalDays }).ToList();
        }

        // Toplam çalışma süresi ile COVID’e yakalanma arasındaki istatistiki bilgi sunulabilmelidir.
        public List<string> CovidIstatistikBilgisi()
        {
            List<string> tcs = (from personel in _context.Personeller select personel.TC).ToList();
            List<CalismaSaati> genel_calisma_bilgileri = (from calisma in _context.CalismaSaatleri select calisma).ToList();
            List<string> covidliler = (from covidli in _context.CovidKayitlari select covidli.TC).ToList();

            List<CalismaSaatiTC> calismaSaatleri = new List<CalismaSaatiTC>();

            foreach (var tc in tcs)
            {
                double toplamSaat = 0;

                foreach (var bilgi in genel_calisma_bilgileri)
                {
                    if (bilgi.TC == tc)
                    {
                        toplamSaat += bilgi.Bitis.Subtract(bilgi.Baslangic).TotalHours;
                    }
                }

                calismaSaatleri.Add(new CalismaSaatiTC { TC = tc, saat = toplamSaat });
            }

            Dictionary<double, List<string>> saatGruplari = new Dictionary<double, List<string>>();

            foreach (var calismaSaati in calismaSaatleri)
            {
                if (saatGruplari.ContainsKey(calismaSaati.saat))
                {
                    saatGruplari[calismaSaati.saat].Add(calismaSaati.TC);
                }
                else
                {
                    saatGruplari.Add(calismaSaati.saat, new List<string> { calismaSaati.TC });
                }
            }

            List<string> ans = new List<string>();

            foreach (var item in saatGruplari)
            {
                int covidli_calisan = 0, genel_calisan = item.Value.Count();

                foreach (var tc in item.Value)
                {
                    if (covidliler.Contains(tc)) covidli_calisan++;
                }

                ans.Add(String.Format("{0} saat çalışan {1} personelden {2} kişi covid geçirmiş. ({3:0.00}%)", item.Key, genel_calisan, covidli_calisan, ((double)covidli_calisan / genel_calisan) * 100));
            }

            return ans;

        }

        public IEnumerable<string> SehirHastalikBilgisi(string sehir)
        {
            IEnumerable<string> tcs = (from personel in _context.Personeller where personel.DogduguSehir == sehir select personel.TC).ToList();

            return (from hasta in _context.HastalikKayitlari.Where(c => tcs.Contains(c.TC)).GroupBy(c => c.HastalikIsmi) orderby hasta.Count() descending select hasta.Key).ToList().Take(3);
        }


        // En yaygın kullanılan ilk üç ilacı kullanan elemanların COVID geçirme durumu rapor edilebilmelidir.
        public List<CalisanCovidBilgisi> YayginIlacCovidBilgisi()
        {
            IEnumerable<string> en_yaygin_3_ilac = (from recete in _context.Receteler.GroupBy(c => c.Ilac) orderby recete.Count() select recete.Key).ToList().Take(3);
            IEnumerable<int> kullanan_elemanlar = (from recete in _context.Receteler where en_yaygin_3_ilac.Contains(recete.Ilac) select recete.HastalikID);
            IEnumerable<string> tcs = (from hastalik in _context.HastalikKayitlari where kullanan_elemanlar.Contains(hastalik.ID) select hastalik.TC).Distinct();

            List<string> covidliler = (from covidli in _context.CovidKayitlari select covidli.TC).ToList();

            List<CalisanCovidBilgisi> ans = new List<CalisanCovidBilgisi>();

            foreach (var tc in tcs)
            {
                ans.Add(new CalisanCovidBilgisi { TC = tc, CovidDurumu = covidliler.Contains(tc) ? true : false });
            }

            return ans;

        }
    }
}