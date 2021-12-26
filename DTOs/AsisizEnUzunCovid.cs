using System;
using System.Collections.Generic;

namespace Covid_19_Data_Processing.Models
{
    public class AsisizEnUzunCovid
    {
        public string Tc { get; set; }             
        public List<string> Hastaliklar { get; set; }    
        public List<Recete> Receteler { get; set; }    
    }
}
