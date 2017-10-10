using FaturaUygulama.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaUygulama.Models
{
  public  class Elektrik:AnaFatura,Ihesapla
    {
        public Elektrik()
        {
            this.isim = "Mert";
            this.Soyisim = "Alptekin";
            this.tarih = DateTime.Now;
            this.seriNumarası = "EF341LKDASX33";
            this.ilkendeks = 549;
            this.sonendeks = 3333;
            this.kullanimMiktari = sonendeks - ilkendeks;
            this.birimMiktari = 0.42M;
        }

        public decimal hesapla()
        {
            return kullanimMiktari * birimMiktari;
        }
    }
}
