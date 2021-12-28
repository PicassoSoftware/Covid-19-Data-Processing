namespace Covid_19_Data_Processing.Models
{
    public class Kronik
    {
        public string CovidID { get; set; }
        public string Hastalik { get; set; }     
        public virtual CovidKaydi CovidKaydi { get; set; }       
    }
}