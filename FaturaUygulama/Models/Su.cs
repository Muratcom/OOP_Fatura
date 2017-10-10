using FaturaUygulama.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaUygulama.Models
{
   public class Su:AnaFatura,Ihesapla
    {
        public Su()
        {

            this.isim = "Murat";
            this.Soyisim = "Ekşi";
            this.tarih = DateTime.Now;
            this.seriNumarası = "SF341LKDASX33";
            this.ilkendeks = 875;
            this.sonendeks = 1263;
            this.kullanimMiktari = sonendeks - ilkendeks;
            this.birimMiktari = 4.44M;


        }

        public decimal hesapla()
        {
            return kullanimMiktari * birimMiktari;

        }
    }
}
