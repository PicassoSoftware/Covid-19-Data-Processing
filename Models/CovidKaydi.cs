using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Covid_19_Data_Processing.Models
{
    public class CovidKaydi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
