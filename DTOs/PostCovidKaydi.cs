using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covid_19_Data_Processing.DTOs
{
    public class PostCovidKaydi
    {
        public string TC { get; set; }
        public DateTime BaslangicTarihi { get; set; }   
        public DateTime BitisTarihi { get; set; }
    }
}