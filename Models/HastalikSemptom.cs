namespace Covid_19_Data_Processing.Models
{
    public class HastalikSemptom
    {
        public int HastalikID { get; set; }
        public string Semptom { get; set; }       
        public virtual HastalikKaydi HastalikKaydi { get; set; }
    }
}