using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas.Negocio
{
    public class RegistroDescuento
    {
        private Decimal _porcentaje;
        private string _rut;
        private string _ruta;
        private int _peaje;
        private DateTime _fecha;

        public decimal Porcentaje { get => _porcentaje; set => _porcentaje = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public int Peaje { get => _peaje; set => _peaje = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public RegistroDescuento()
        {
            this.Porcentaje = 0;
            this.Rut = string.Empty;
            this.Ruta = string.Empty;
            this.Peaje = 0;
            this.Fecha = DateTime.Now;
        }


        public bool Create()
        {
            try
            {
                Bibliotecas.Dalc.RegistroDescuento usu = new Dalc.RegistroDescuento();

                usu.fecha = this.Fecha;
                usu.porcentaje = this.Porcentaje;
                usu.ruta = this.Ruta;
                usu.peajes = this.Peaje;
                usu.rut = this.Rut;

                CommonBC.ModeloSmartPay.RegistroDescuento.Add(usu);
                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
