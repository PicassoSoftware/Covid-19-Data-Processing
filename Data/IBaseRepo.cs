using System;
using System.Threading.Tasks;
using Covid_19_Data_Processing.Models;


namespace Covid_19_Data_Processing.Data
{
    public interface IBaseRepo 
    {
        Task AddPersonel(Personel element);
        Task AddHastalikKaydi(HastalikKaydi element);
        Task AddRecete(Recete element);
        Task AddCovidKaydi (CovidKaydi element);
        Task AddCalismaSaaatleri (CalismaSaati element);
        Task AddAsi (Asi element);






        Task DeletePersonel(int tc);
        Task DeleteCalismaSaati(int tc);
        Task DeleteHastalikKaydi(int tc);
        Task DeleteRecete(int hastalik_id);
        Task DeleteAsi(int tc, DateTime asi_olma_tarihi);
        Task DeleteCovidKaydi(int tc, DateTime baslangic_tarihi);







        Task UpdatePersonel(int tc, Personel element);
        Task UpdateCalismaSaati(int tc, CalismaSaati element);
        Task UpdateHastalikKaydi(int tc, HastalikKaydi element);
        Task UpdateRecete(int hastalik_id, string ilac, Recete element);
        Task UpdateAsi(int tc, DateTime asi_olma_tarihi, Asi element);
        Task UpdateCovidKaydi(int tc, DateTime baslangic_tarihi, CovidKaydi element);
        

        
        // Doktora yapanların 20% si Covid geçirmiş. tip: Right Join
        // Eğitim durumu ile COVID geçirme arasındaki istatistiki bilgi çıkarılabilmelidir.
        Task EgitimCovidIstatistikBilgisi();

        // Elemanlar arasında görülen en yaygın üç hastalık türü rapor edilebilmeli ve hastalığa sahip olan elemanların listesi çıkarılabilmelidir.
        Task EnYayginHastalikBilgisi();

        // Belirli şehirde doğan elemanlar arasında en sık görülen ilk üç hastalık rapor edilebilmelidir.
        Task SehirHastalikBilgisi(string sehir);

        // En yaygın kullanılan ilk üç ilacı kullanan elemanların COVID geçirme durumu rapor edilebilmelidir.
        Task YayginIlacCovidBilgisi();

        // Belirli bir ilacı kullanan çalışanların COVID geçirme durumu rapor edilebilmelidir.
        Task IlacaGoreCovid(string ilac);

        // Biontech aşısı olan ve belirli bir hastalığı önceden geçirmiş olan çalışanlardan COVID’e yakalananlar listelenebilmelidir.
        Task BiontechVeHastalikCovidBilgisi(string hastalik);

        // Aşı vurulma durumuna göre COVID hastalığına yakalanma oranı rapor edilebilmelidir.
        Task AsiyaGoreCovidBilgisi();

        // Belirli bir kronik hastalığa göre, çalışanların COVID testinin negatife dönmesi için geçen süre rapor edilebilmelidir.
        Task KronikCovidSuresiBilgisi(string kronik);

        // Kan grubuna göre COVID’e yakalanma sıklığı rapor edilebilmelidir.
        Task KanGrubuCovidBilgisi();

        // Toplam çalışma süresi ile COVID’e yakalanma arasındaki istatistiki bilgi sunulabilmelidir.
        Task SaatCovidIstatistikBilgisi();

        // COVID’e yakalananlar arasında görülen en sık karşılaşılan ilk 3 belirti listelenebilmelidir.
        Task CovidBelirtileri();

        // En fazla temasta bulunmuş ilk 3 çalışan listelenebilmelidir.
        Task TemasBagimlilari();

        // Biontech ve sinovac aşılarının etkinliği, COVID geçirme süresi göz önüne alınarak kıyaslanabilmelidir.
        Task AsiEtkinlikBilgisi();

        // Haftasonu çalışan kişiler arasında COVID gözükme miktarı.
        Task HaftasonuCovidBilgisi();

        // En sık hasta olan ilk 10 kişinin son bir ay içerisinde COVID’e yakalanma durumları listelenebilmelidir.
        Task HastalananlarinCovidBilgisi();

        // Aşı vurulmayanlar arasında, en uzun süre COVID geçiren kişinin, son 1 yılda geçirmiş olduğu hastalıklar ve verilen reçeteler listelenebilmelidir.
        Task AsisizEnUzunCovidBilgisi();

    }
}