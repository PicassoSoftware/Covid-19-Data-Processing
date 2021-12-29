using System;
using Covid_19_Data_Processing.Models;

using System.Threading.Tasks;
using AutoMapper;
using Covid_19_Data_Processing.DTOs;

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

        public async Task AsiyaGoreCovidBilgisi()
        {
            throw new NotImplementedException();
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

        public async Task IlacaGoreCovid(string ilac)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public async Task UpdateCalismaSaati(string tc, CalismaSaati element)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCovidKaydi(string tc, DateTime baslangic_tarihi, CovidKaydi element)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateHastalikKaydi(string tc, HastalikKaydi element)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePersonel(string tc, Personel element)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateRecete(int hastalik_id, string ilac, Recete element)
        {
            throw new NotImplementedException();
        }

        public async Task YayginIlacCovidBilgisi()
        {
            throw new NotImplementedException();
        }

    }
}