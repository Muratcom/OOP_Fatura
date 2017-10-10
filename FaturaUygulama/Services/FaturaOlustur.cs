using FaturaUygulama.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaUygulama.Services
{
   public class FaturaOlustur<T> : IFaturaOlustur<T>
    {
        public T Olustur()
        {

            return Activator.CreateInstance<T>();

        }

    }
}
