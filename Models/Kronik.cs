namespace Covid_19_Data_Processing.Models
{
    public class Kronik
    {
        public int CovidID { get; set; }
        public string Hastalik { get; set; }     
        public virtual CovidKaydi CovidKaydi { get; set; }       
    }
}