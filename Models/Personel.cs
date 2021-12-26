using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class Personel
    {
        public string TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string KanGrubu { get; set; }
        public int DogduguSehir { get; set; }          
        public string Pozisyon { get; set; }          
        public int Maas { get; set; }          
        public int Egitim { get; set; }     

        public List<string> Hobiler { get; set; }
     
    }
}