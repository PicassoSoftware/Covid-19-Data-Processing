using System;
using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class CalismaSaati
    {
        public string TC { get; set; }
        public int HaftaninGunleri { get; set; }    
        public TimeSpan Baslangic { get; set; }
        public TimeSpan Bitis { get; set; }           
        public virtual Personel Personel { get; set; }      
    }
}