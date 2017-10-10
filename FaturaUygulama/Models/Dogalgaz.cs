using FaturaUygulama.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaUygulama.Models
{
    public class Dogalgaz : AnaFatura,Ihesapla
    {
        
        public Dogalgaz()
        {
            this.isim = "Osman";
            this.Soyisim = "Ünsal";
            this.tarih = DateTime.Now;
            this.seriNumarası = "DF341LKDASX33";
            this.ilkendeks = 1600;
            this.sonendeks = 2000;
            this.kullanimMiktari = sonendeks - ilkendeks;
            this.birimMiktari = 1.0103M;

        }

        public decimal hesapla()
        {
            return birimMiktari * kullanimMiktari;
        }
    }
}
