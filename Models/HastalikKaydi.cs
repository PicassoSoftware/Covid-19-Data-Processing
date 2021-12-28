using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Covid_19_Data_Processing.Models;

namespace Covid_19_Data_Processing.Models
{
    public class HastalikKaydi
    {
        [Key]
        public int ID { get; set; }
        public string TC { get; set; }
        public string HastalikIsmi { get; set; }
        public DateTime HastaOlduguTarih { get; set; }
        public virtual IEnumerable<HastalikSemptom> HastalikSemptomlari { get; set; }   
        public virtual IEnumerable<Recete> Receteler { get; set; }   
        public virtual Personel Personel { get; set; }

    }
}