using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covid_19_Data_Processing.Models
{
    public class Personel
    {
        [Key]
        public string TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string KanGrubu { get; set; }
        public int DogduguSehir { get; set; }          
        public string Pozisyon { get; set; }          
        public int Maas { get; set; }          
        public int Egitim { get; set; }     
        public virtual IEnumerable<Asi> Asilar { get; set; }   
        public virtual IEnumerable<Hobi> Hobiler { get; set; }   
        public virtual IEnumerable<CalismaSaati> CalismaSaatleri { get; set; }   
        public virtual IEnumerable<CovidKaydi> CovidKayitlari { get; set; }   
        public virtual IEnumerable<HastalikKaydi> HastalikKayitlari { get; set; }   
        public virtual IEnumerable<Temasli> TemasEttigiCovidler { get; set; }   
        
     
    }
}