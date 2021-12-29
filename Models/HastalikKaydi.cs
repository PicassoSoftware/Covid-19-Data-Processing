using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Covid_19_Data_Processing.Models;

namespace Covid_19_Data_Processing.Models
{
    public class HastalikKaydi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TC { get; set; }
        public string HastalikIsmi { get; set; }
        public DateTime HastaOlduguTarih { get; set; }
        public virtual IEnumerable<HastalikSemptom> HastalikSemptomlari { get; set; }   
        public virtual IEnumerable<Recete> Receteler { get; set; }   
        public virtual Personel Personel { get; set; }

    }
}