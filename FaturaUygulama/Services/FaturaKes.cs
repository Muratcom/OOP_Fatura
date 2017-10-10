using FaturaUygulama.Models;
using FaturaUygulama.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaUygulama.Services
{


   public class FaturaKes
    {

        private FaturaTipi _fatura;

        public FaturaKes(FaturaTipi tip)
        {

            _fatura = tip;

        }
       
        public AnaFatura FaturaSec() {
            AnaFatura fatura = null;

            switch (_fatura)
            {
                case FaturaTipi.Dogalgaz:
                    fatura = new FaturaOlustur<Dogalgaz>().Olustur();
                    break;
                case FaturaTipi.Elektrik:
                    fatura = new FaturaOlustur<Elektrik>().Olustur();
                    break;
                case FaturaTipi.Su:
                    fatura = new FaturaOlustur<Su>().Olustur();
                    break;
                default:
                    break;
            }

            return fatura;

        }



    }
}
