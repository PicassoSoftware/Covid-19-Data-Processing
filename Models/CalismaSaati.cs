using System;
using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class CalismaSaati
    {
        public string TC { get; set; }
        public string HaftaninGunleri { get; set; }    
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }           
        public virtual Personel Personel { get; set; }      
    }
}