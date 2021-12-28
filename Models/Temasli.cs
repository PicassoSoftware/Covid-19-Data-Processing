namespace Covid_19_Data_Processing.Models
{
    public class Temasli
    {
        public int CovidID { get; set; }
        public string TemasliTC { get; set; }   
        public virtual CovidKaydi CovidKaydi { get; set; }
        public virtual Personel Personel { get; set; }
    }
}