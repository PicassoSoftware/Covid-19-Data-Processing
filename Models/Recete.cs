using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class Recete
    {
        public int HastalikID { get; set; }
        public string Ilac { get; set; }    
        public int Doz { get; set; }       
        public virtual HastalikKaydi HastalikKaydi { get; set; }
    }
}