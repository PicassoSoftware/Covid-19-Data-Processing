using System;
using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class CovidKaydi
    {
        public string TC { get; set; }
        public DateTime BaslangicTarihi { get; set; }    
        
        public DateTime BitisTarihi { get; set; }

        public bool  KronikHastalik { get; set; }    

        public List<string> TemasliPersonel {get; set;}
        public List<string> CovidSemptom {get; set;}

              
    }
}
