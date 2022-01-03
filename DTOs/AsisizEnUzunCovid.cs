using System.Collections.Generic;
using Covid_19_Data_Processing.Models;

namespace Covid_19_Data_Processing.DTOs
{
    public class AsisizEnUzunCovid
    {
        public string Tc { get; set; }             
        public List<string> Hastaliklar { get; set; }    
        public List<Recete> Receteler { get; set; }    
    }
}
