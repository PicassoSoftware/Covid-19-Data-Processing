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
        Task AddHastalikSemptom (HastalikSemptom element);
        Task AddCalismaSaati (CalismaSaati element);
        Task AddAsi (Asi element);
        Task AddHobi (Hobi element);
        Task AddTemasli (Temasli element);
        Task AddKronik(Kronik element);






        Task DeletePersonel(string tc);
        Task DeleteHastalikSemptom(string semptom, int hastalik_id);
        Task DeleteHobi(string tc,string hobi_ismi);
        Task DeleteTemasli(string temasli_tc,int covid_id);
        Task DeleteKronik(int covid_id , string hastalik);
        Task DeleteCovidSemptom(int covid_id , string semptom);
        Task DeleteCalismaSaati(string tc, int haftanin_günleri, TimeSpan baslangic);
        Task DeleteHastalikKaydi(int id );
        Task DeleteRecete(int hastalik_id,string ilac);
        Task DeleteAsi(string tc, DateTime asi_olma_tarihi);
        Task DeleteCovidKaydi(string tc, DateTime baslangic_tarihi);







        Task UpdatePersonel(string tc, Personel element);
        Task UpdateKronik(int covid_id , string hastalik, Kronik elemenet);
        Task UpdateHobi(string tc,string hobi_ismi, Hobi element);
        Task UpdateTemasli(string temasli_tc,int covid_id, Temasli element);
        Task UpdateHastalikSemptom(string semptom, int hastalik_id,HastalikSemptom element);
        Task UpdateCovidSemptom(int covid_id , string semptom, CovidSemptom element);
        Task UpdateCalismaSaati(string tc, int haftanin_günleri, TimeSpan baslangic, CalismaSaati element);
        Task UpdateHastalikKaydi(int id, HastalikKaydi element);
        Task UpdateRecete(int hastalik_id, string ilac, Recete element);
        Task UpdateAsi(string tc, DateTime asi_olma_tarihi, Asi element);
        Task UpdateCovidKaydi(string tc, DateTime baslangic_tarihi, CovidKaydi element);
        





        
        // Doktora yapanların 20% si Covid geçirmiş. tip: Right Join
        // Eğitim durumu ile COVID geçirme arasındaki istatistiki bilgi çıkarılabilmelidir.
        EgitimCovidIstatistik EgitimCovidIstatistikBilgisi();  // Sema        //Test edildi,çalışıyor

        // Elemanlar arasında görülen en yaygın üç hastalık türü rapor edilebilmeli ve hastalığa sahip olan elemanların listesi çıkarılabilmelidir.
        List<HastalikPersonel>  EnYayginHastalikBilgisi(); // Hatice        //Test Edildi, Çalışıyor

        // Belirli şehirde doğan elemanlar arasında en sık görülen ilk üç hastalık rapor edilebilmelidir.
        IEnumerable<string> SehirHastalikBilgisi(string sehir); // Esra       //Test Edildi, Çalışıyor

        // En yaygın kullanılan ilk üç ilacı kullanan elemanların COVID geçirme durumu rapor edilebilmelidir.
        List<CalisanCovidBilgisi> YayginIlacCovidBilgisi(); // Esra     

        // Belirli bir ilacı kullanan çalışanların COVID geçirme durumu rapor edilebilmelidir.
        List<CalisanCovidBilgisi> IlacaGoreCovid(string ilac); // Erkin   // Test Edildi, Çalışıyor

        // Biontech aşısı olan ve belirli bir hastalığı önceden geçirmiş olan çalışanlardan COVID’e yakalananlar listelenebilmelidir.
        List<string> BiontechVeHastalikCovidBilgisi(string hastalik); // Erkin    // Test Edildi, Çalışıyor

        // Aşı vurulma durumuna göre COVID hastalığına yakalanma oranı rapor edilebilmelidir.
        AsiCovidOran AsiyaGoreCovidBilgisi(); // Sema   // Test Edildi, Çalışıyor

        // Belirli bir kronik hastalığa göre, çalışanların COVID testinin negatife dönmesi için geçen süre rapor edilebilmelidir.
        List<KronikCovidSure> KronikCovidSuresiBilgisi(string kronik); // Erkin     // Test Edildi, Çalışıyor

        // Kan grubuna göre COVID’e yakalanma sıklığı rapor edilebilmelidir.
        IEnumerable<KanGrubuCovid> KanGrubuCovidBilgisi(); //Esra   // Test Edildi, Çalışıyor

        // Toplam çalışma süresi ile COVID’e yakalanma arasındaki istatistiki bilgi sunulabilmelidir.
        List<string> CovidIstatistikBilgisi(); // Sema

        // COVID’e yakalananlar arasında görülen en sık karşılaşılan ilk 3 belirti listelenebilmelidir.
        IEnumerable<string> CovidBelirtileri(); //Esra  //Test Edildi, Çalışıyor

        // En fazla temasta bulunmuş ilk 3 çalışan listelenebilmelidir.
        IEnumerable<string> TemasBagimlilari(); // Hatice    // Test Edildi, Çalışıyor

        // Biontech ve sinovac aşılarının etkinliği, COVID geçirme süresi göz önüne alınarak kıyaslanabilmelidir.
        string AsiEtkinlikBilgisi(); // Sema          //Test Edildi, Çalışıyor

        // Haftasonu çalışan kişiler arasında COVID gözükme miktarı.
        string HaftasonuCovidBilgisi(); // Hatice         // Test Edildi, Çalışıyor

        // En sık hasta olan ilk 10 kişinin son bir ay içerisinde COVID’e yakalanma durumları listelenebilmelidir.
        List<CalisanCovidBilgisi> HastalananlarinCovidBilgisi(); // Hatice        // Test Edildi, Çalışıyor

        // Aşı vurulmayanlar arasında, en uzun süre COVID geçiren kişinin, son 1 yılda geçirmiş olduğu hastalıklar ve verilen reçeteler listelenebilmelidir.
        AsisizEnUzunCovid AsisizEnUzunCovidBilgisi(); // Erkin     // Test Edildi, Çalışıyor

    }
}