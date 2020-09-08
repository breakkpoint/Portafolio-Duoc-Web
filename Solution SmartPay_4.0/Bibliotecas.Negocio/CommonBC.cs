using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Dalc;

namespace Bibliotecas.Negocio
{
   public class CommonBC
    {
        private static SmartPayEntities2 _modeloSmartPay;

        public static SmartPayEntities2 ModeloSmartPay
        {
            get
            {
                if (_modeloSmartPay == null)
                {
                    _modeloSmartPay = new SmartPayEntities2();
                }
                return _modeloSmartPay;
            }
        }
        public CommonBC()
        {

        }
    }
}
