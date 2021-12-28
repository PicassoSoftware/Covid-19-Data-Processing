using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class Hobi
    {
        public string TC { get; set; }
        public string HobiIsmi { get; set; }   
        public virtual Personel Personel { get; set; }       
    }
}