using System;
using Covid_19_Data_Processing.Models;

namespace Covid_19_Data_Processing.DTOs
{
    public class PostCalismaSaati
    {
        public string TC { get; set; }
        public int HaftaninGunleri { get; set; }    
        public string Baslangic { get; set; }
        public string Bitis { get; set; }           
        public virtual Personel Personel { get; set; }   
    }
}