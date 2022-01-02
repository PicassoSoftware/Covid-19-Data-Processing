using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid_19_Data_Processing.DTOs;
using Covid_19_Data_Processing.Models;


namespace Covid_19_Data_Processing.Data
{
    public interface IBaseRepo 
    {
        Task AddPersonel(Personel element);
        Task AddHastalikKaydi(PostHastalikKaydi element);
        Task AddRecete (Recete element);
        Task AddCovidKaydi (PostCovidKaydi element);
        Task AddCovidSemptom (CovidSemptom element);
        Task AddCalismaSaaatleri (CalismaSaati element);
        Task AddAsi (Asi element);
        Task AddTemasli (Temasli element);
        Task AddKronik(Kronik element);






        Task DeletePersonel(string tc);
        Task DeleteCalismaSaati(string tc);
        Task DeleteHastalikKaydi(string tc);
        Task DeleteRecete(int hastalik_id);
        Task DeleteAsi(string tc, DateTime asi_olma_tarihi);
        Task DeleteCovidKaydi(string tc, DateTime baslangic_tarihi);







        Task UpdatePersonel(string tc, Personel element);
        Task UpdateCalismaSaati(string tc, CalismaSaati element);
        Task UpdateHastalikKaydi(int id, HastalikKaydi element);
        Task UpdateRecete(int hastalik_id, string ilac, Recete element);
        Task UpdateAsi(string tc, DateTime asi_olma_tarihi, Asi element);
        Task UpdateCovidKaydi(string tc, DateTime baslangic_tarihi, CovidKaydi element);
        

        
        // Doktora yapanların 20% si Covid geçirmiş. tip: Right Join
        // Eğitim durumu ile COVID geçirme arasındaki istatistiki bilgi çıkarılabilmelidir.
        Task<EgitimCovidIstatistik> EgitimCovidIstatistikBilgisi();  // Sema //Test edildi,çalışıyor

        // Elemanlar arasında görülen en yaygın üç hastalık türü rapor edilebilmeli ve hastalığa sahip olan elemanların listesi çıkarılabilmelidir.
        Task<List<HastalikPersonel>>  EnYayginHastalikBilgisi(); // Hatice

        // Belirli şehirde doğan elemanlar arasında en sık görülen ilk üç hastalık rapor edilebilmelidir.
        Task<IEnumerable<string>> SehirHastalikBilgisi(string sehir); // Esra       //Test Edildi, Çalışıyor

        // En yaygın kullanılan ilk üç ilacı kullanan elemanların COVID geçirme durumu rapor edilebilmelidir.
        Task YayginIlacCovidBilgisi(); // Esra     

        // Belirli bir ilacı kullanan çalışanların COVID geçirme durumu rapor edilebilmelidir.
        Task<List<CalisanCovidBilgisi>> IlacaGoreCovid(string ilac); // Erkin   // Test Edildi, Çalışıyor

        // Biontech aşısı olan ve belirli bir hastalığı önceden geçirmiş olan çalışanlardan COVID’e yakalananlar listelenebilmelidir.
        Task<List<string>> BiontechVeHastalikCovidBilgisi(string hastalik); // Erkin    // Test Edildi, Çalışıyor

        // Aşı vurulma durumuna göre COVID hastalığına yakalanma oranı rapor edilebilmelidir.
        Task<AsiCovidOran> AsiyaGoreCovidBilgisi(); // Sema   // Test Edildi, Çalışıyor

        // Belirli bir kronik hastalığa göre, çalışanların COVID testinin negatife dönmesi için geçen süre rapor edilebilmelidir.
        Task<List<KronikCovidSure>> KronikCovidSuresiBilgisi(string kronik); // Erkin     // Test Edildi, Çalışıyor

        // Kan grubuna göre COVID’e yakalanma sıklığı rapor edilebilmelidir.
        Task<IEnumerable<KanGrubuCovid>> KanGrubuCovidBilgisi(); //Esra   // Test Edildi, Çalışıyor

        // Toplam çalışma süresi ile COVID’e yakalanma arasındaki istatistiki bilgi sunulabilmelidir.
        Task<List<saatOran>> CovidIstatistikBilgisi(); // Sema

        // COVID’e yakalananlar arasında görülen en sık karşılaşılan ilk 3 belirti listelenebilmelidir.
        Task<IEnumerable<string>> CovidBelirtileri(); //Esra  //Test Edildi, Çalışıyor

        // En fazla temasta bulunmuş ilk 3 çalışan listelenebilmelidir.
        Task<IEnumerable<string>> TemasBagimlilari(); // Hatice    // Test Edildi, Çalışıyor

        // Biontech ve sinovac aşılarının etkinliği, COVID geçirme süresi göz önüne alınarak kıyaslanabilmelidir.
        Task<string> AsiEtkinlikBilgisi(); // Sema          //Test Edildi, Çalışıyor

        // Haftasonu çalışan kişiler arasında COVID gözükme miktarı.
        Task<string> HaftasonuCovidBilgisi(); // Hatice         // Test Edildi, Çalışıyor

        // En sık hasta olan ilk 10 kişinin son bir ay içerisinde COVID’e yakalanma durumları listelenebilmelidir.
        Task<List<CalisanCovidBilgisi>> HastalananlarinCovidBilgisi(); // Hatice        // Test Edildi, Çalışıyor

        // Aşı vurulmayanlar arasında, en uzun süre COVID geçiren kişinin, son 1 yılda geçirmiş olduğu hastalıklar ve verilen reçeteler listelenebilmelidir.
        Task<AsisizEnUzunCovid> AsisizEnUzunCovidBilgisi(); // Erkin     // Test Edildi, Çalışıyor

    }
}