using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaturaUygulama.Services;

namespace FaturaUygulama.Models
{
   public abstract class AnaFatura
    {
        public string isim { get; set; }    
        public string Soyisim { get; set; }
        public string seriNumarası { get; set; }
        public decimal birimMiktari  { get; set; }

        public decimal ilkendeks { get; set; }

        public decimal sonendeks { get; set; }
        public  DateTime tarih { get; set; }

        public decimal kullanimMiktari { get; set; }

        


    }
}
