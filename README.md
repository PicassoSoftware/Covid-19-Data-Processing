# Covid-19-Data-Processing
COVID 19 Pandemisinde bir şirket bünyesinde çalıştırdığı elemanları ile ilgili sağlık durumu bilgilerini depolamak istemektedir.

- Şirkette çalışan elemanlara ait (tcno, isim, soyad, kan grubu, doğduğu şehir, pozisyon, maaş, hobileri, lisans, yüksek lisans, doktora) bilgileri depolanacaktır.
- Her elemanla ilgili olarak da hastalık bilgileri tutulmak istenmektedir. (Hastalığın ismi, hasta olduğu tarih, reçetedeki ilaçlar ve dozları, semptomları) tutulmak istenen bilgiler arasındadır.
- Çalışanın COVID geçirmesi durumunda: COVID’e yakalandığı tarih, COVID negatife döndüğü tarih, COVID öncesi belirtileri (Sağlık bakanlığının bildirdiği semptom listesindeki bilgilerden seçilebilir), temaslı olduğu diğer çalışan bilgileri, aşı vurulup vurulmadığı bilgisi, vuruldu ise önceden vurulduğu aşılar, kronik bir hastalığının olup olmadığı tutulmak istenen bilgiler arasındadır. 
- Çalışanlarla ilgili ayrıca haftanın hangi günleri hangi saatler arasında çalıştıkları da tutulacaktır.

Tüm bu bilgiler doğrultusunda oluşturacak olduğunuz veritabanına ilişkin yapılması beklenen özellikler aşağıdaki şekildedir. (Veritabanı için raporunuzda ER diagramı ve indirgenmiş tablo tasarımları mevcut olmalıdır. Rapor ayrıca kullanıcı arabiriminin kullanımına yönelik de bilgiler sunmalıdır)

- Çalışanlara ilişkin olarak, tabloda yer alan tüm özelliklerine ilişkin sorgulamalar gerçekleştirebilecek yetenekte olması. Yeni bir çalışan ekleyebilme, var olanı silebilme ve güncelleyebilme.
- Her elemanla ilgili yeni bir hastalık ve reçete bilgisi girilebilmeli, güncellenebilmeli gerekirse silinebilmelidir.
- Her elemanla ilgili COVID bilgisi girilebilmeli, güncellenebilmeli gerekirse silinebilmelidir.
- Her elemanla ilgili çalışma saati bilgisi girilebilmeli, güncellenebilmeli gerekirse silinebilmelidir.
- Eğitim durumu ile COVID geçirme arasındaki istatistiki bilgi çıkarılabilmelidir.
- Elemanlar arasında görülen en yaygın üç hastalık türü rapor edilebilmeli ve hastalığa sahip olan elemanların listesi çıkarılabilmelidir.
- Belirli şehirde doğan elemanlar arasında en sık görülen ilk üç hastalık rapor edilebilmelidir.
- En yaygın kullanılan ilk üç ilacı kullanan elemanların COVID geçirme durumu rapor edilebilmelidir.
- Belirli bir ilacı kullanan çalışanların COVID geçirme durumu rapor edilebilmelidir.
- Biontech aşısı olan ve belirli bir hastalığı önceden geçirmiş olan çalışanlardan COVID’e yakalananlar listelenebilmelidir.
- Aşı vurulma durumuna göre COVID hastalığına yakalanma oranı rapor edilebilmelidir.
- Belirli bir kronik hastalığa göre, çalışanların COVID testinin negatife dönmesi için geçen süre rapor edilebilmelidir.
- Kan grubuna göre COVID’e yakalanma sıklığı rapor edilebilmelidir.
- Toplam çalışma süresi ile COVID’e yakalanma arasındaki istatistiki bilgi sunulabilmelidir.
- COVID’e yakalananlar arasında görülen en sık karşılaşılan ilk 3 belirti listelenebilmelidir.
- En fazla temasta bulunmuş ilk 3 çalışan listelenebilmelidir.
- Biontech ve sinovac aşılarının etkinliği, COVID geçirme süresi göz önüne alınarak kıyaslanabilmelidir.
- Haftasona çalışan kişiler arasında COVID gözükme miktarı.
- En sık hasta olan ilk 10 kişinin son bir ay içerisinde COVID’e yakalanma durumları listelenebilmelidir.
- Aşı vurulmayanlar arasında, en uzun süre COVID geçiren kişinin, son 1 yılda geçirmiş olduğu hastalıklar ve verilen reçeteler listelenebilmelidir..
