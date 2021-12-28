using System;
using System.Threading.Tasks;
using Covid_19_Data_Processing.Models;


namespace Covid_19_Data_Processing.Data
{
    public class BaseRepo : IBaseRepo
    {
        public Task AddAsi(Asi element)
        {
            throw new NotImplementedException();
        }

        public Task AddCalismaSaaatleri(CalismaSaati element)
        {
            throw new NotImplementedException();
        }

        public Task AddCovidKaydi(CovidKaydi element)
        {
            throw new NotImplementedException();
        }

        public Task AddHastalikKaydi(HastalikKaydi element)
        {
            throw new NotImplementedException();
        }

        public Task AddPersonel(Personel element)
        {
            
            throw new NotImplementedException();
        }

        public Task AddRecete(Recete element)
        {
            throw new NotImplementedException();
        }

        public Task AsiEtkinlikBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task AsisizEnUzunCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task AsiyaGoreCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task BiontechVeHastalikCovidBilgisi(string hastalik)
        {
            throw new NotImplementedException();
        }

        public Task CovidBelirtileri()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsi(int tc, DateTime asi_olma_tarihi)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCalismaSaati(int tc)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCovidKaydi(int tc, DateTime baslangic_tarihi)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHastalikKaydi(int tc)
        {
            throw new NotImplementedException();
        }

        public Task DeletePersonel(int tc)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRecete(int hastalik_id)
        {
            throw new NotImplementedException();
        }

        public Task EgitimCovidIstatistikBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task TemasBagimlilari()
        {
            throw new NotImplementedException();
        }

        public Task EnYayginHastalikBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task HaftasonuCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task HastalananlarinCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task IlacaGoreCovid(string ilac)
        {
            throw new NotImplementedException();
        }

        public Task KanGrubuCovidBilgisi()
        {
            throw new NotImplementedException();
        }

        public Task KronikCovidSuresiBilgisi(string kronik)
        {
            throw new NotImplementedException();
        }

        public Task SaatCovidIstatistikBilgisi()
        {
            throw new NotImplementedException();
        }
        
        public Task SehirHastalikBilgisi(string sehir)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsi(int tc, DateTime asi_olma_tarihi, Asi element)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCalismaSaati(int tc, CalismaSaati element)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCovidKaydi(int tc, DateTime baslangic_tarihi, CovidKaydi element)
        {
            throw new NotImplementedException();
        }

        public Task UpdateHastalikKaydi(int tc, HastalikKaydi element)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePersonel(int tc, Personel element)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRecete(int hastalik_id, string ilac, Recete element)
        {
            throw new NotImplementedException();
        }

        public Task YayginIlacCovidBilgisi()
        {
            throw new NotImplementedException();
        }
    }
}