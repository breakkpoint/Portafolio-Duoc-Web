using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Dalc;

namespace Bibliotecas.Negocio
{
    public class Peaje
    {
        #region-- Atributos
       
        private string _ruta;
        private Decimal _precio;
        private int _cantidad_portico;
        private float _descuento;
        #endregion

        #region-- Geters and Seters
       

        public string Ruta { get => _ruta; set => _ruta = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Cantidad_portico { get => _cantidad_portico; set => _cantidad_portico = value; }
        public float Descuento { get => _descuento; set => _descuento = value; }
        #endregion

        #region-- Metodos
        public Peaje()
        {
            Init();
        }

        private void Init()
        {
            this.Ruta = string.Empty;
            this.Precio = 0;
            this.Cantidad_portico = 0;
            this.Descuento= 0.2F;
        }

        public bool Create()
        {
            try
            {
                Bibliotecas.Dalc.Peaje usu = new Dalc.Peaje();

                usu.cantPortico = this.Cantidad_portico;
                usu.precio = this.Precio;
                usu.ruta = this.Ruta;
                usu.descuento = this.Descuento;

                CommonBC.ModeloSmartPay.Peaje.Add(usu);
                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool Read()
        {
            try
            {
                Bibliotecas.Dalc.Peaje usu = CommonBC.ModeloSmartPay.Peaje.First
                    (
                     user => user.ruta == this.Ruta
                    );

                 this.Cantidad_portico= Convert.ToInt32(usu.cantPortico);
                 this.Precio = Convert.ToDecimal(usu.precio) ;
                this.Descuento = Convert.ToSingle(usu.descuento);
                
             

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                Bibliotecas.Dalc.Peaje usu = CommonBC.ModeloSmartPay.Peaje.First
                    (
                     user => user.ruta == this.Ruta

                    );
                CommonBC.ModeloSmartPay.Peaje.Remove(usu);
                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean Update()
        {
            try
            {

                var usu = CommonBC.ModeloSmartPay.Peaje.First(
                    aux => aux.ruta == this.Ruta);


                usu.precio = this.Precio;
                usu.cantPortico = this.Cantidad_portico;

                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public bool TienePeaje()
        {

            var usu = CommonBC.ModeloSmartPay.Peaje.Count
                  (
                 
                  );

            if (usu == 0)
            {
                return false;
            }
            else
            {
                return true;
            }




        }

        public Boolean EliminarViajePeaje(string ruta)
        {
            try
            {
                var col = (from cust in CommonBC.ModeloSmartPay.Viaje
                           where cust.ruta == ruta
                           select cust).ToList();

                foreach (var item in col)
                {
                    
                        Viaje ve = new Viaje();
                        ve.Codigo = item.codigo;
                        ve.Delete();
                    
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean EliminarPeaje(String ruta)
        {
            try
            {
                EliminarViajePeaje(ruta);
                Peaje pe = new Peaje();
                pe.Ruta = ruta;
                pe.Delete();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean UpdateCompleto()
        {
            try
            {

                var usu = CommonBC.ModeloSmartPay.Peaje.First(
                    aux => aux.ruta == this.Ruta);


                usu.precio = this.Precio;
                usu.cantPortico = this.Cantidad_portico;
                usu.descuento = this.Descuento;
                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
        #endregion

    }
}
