using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covid_19_Data_Processing.Models
{
    public class CovidKaydi
    {
        [Key]
        public int ID { get; set; }
        public string TC { get; set; }
        public DateTime BaslangicTarihi { get; set; }   
        public DateTime BitisTarihi { get; set; }
        public virtual IEnumerable<CovidSemptom> CovidSemptomlari { get; set; }   
        public virtual IEnumerable<Kronik> KronikHastaliklar { get; set; }   
        public virtual IEnumerable<Temasli> Temaslilar { get; set; }   
        public virtual Personel Personeller { get; set; }    
    }
}
