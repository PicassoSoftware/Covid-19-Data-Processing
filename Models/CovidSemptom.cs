namespace Covid_19_Data_Processing.Models
{
    public class CovidSemptom{
        public int CovidID { get; set; }
        public string Semptom { get; set; }     
        public virtual CovidKaydi CovidKaydi { get; set; }    
    }
}