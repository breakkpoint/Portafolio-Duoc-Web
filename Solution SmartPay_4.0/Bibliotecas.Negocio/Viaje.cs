using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Dalc;

namespace Bibliotecas.Negocio
{
    public class Viaje
    {
        #region-- Atributos
   
        private int _codigo;
        private string _rut;
        private string _ruta;
        private DateTime _fecha;
        private Decimal _precio;
        private string _patente;
        


        #endregion

        #region-- Geters and Seters
        
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Ruta { get => _ruta; set => _ruta = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public string Patente { get => _patente; set => _patente = value; }
        #endregion

        #region-- Metodos
        public Viaje()
        {
            Init();
        }

        private void Init()
        {
            this.Rut = string.Empty;
            this.Patente = string.Empty;
            this.Ruta = string.Empty;
            this.Precio = 0;
            this.Codigo = 0;
            this.Fecha = DateTime.Now.Date;

        }


        public bool Create()
        {
            try
            {
                Bibliotecas.Dalc.Viaje usu = new Dalc.Viaje();

                usu.rut = this.Rut;
                usu.patente = this.Patente;
                usu.precio= this.Precio;
                usu.ruta = this.Ruta;
                usu.fecha = this.Fecha;
              


                CommonBC.ModeloSmartPay.Viaje.Add(usu);
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
                Bibliotecas.Dalc.Viaje usu = CommonBC.ModeloSmartPay.Viaje.First
                    (
                     user => user.codigo == this.Codigo
                    );


                

                this.Rut = usu.rut ;
                this.Patente = usu.patente ;
                this.Precio= Convert.ToDecimal(usu.precio);
                this.Ruta= usu.ruta ;
                this.Fecha = Convert.ToDateTime( usu.fecha);


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
                Bibliotecas.Dalc.Viaje usu = CommonBC.ModeloSmartPay.Viaje.First
                    (
                     user => user.codigo == this.Codigo

                    );
                CommonBC.ModeloSmartPay.Viaje.Remove(usu);
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

                var usu = CommonBC.ModeloSmartPay.Viaje.First(
                    aux => aux.codigo == this.Codigo);

                usu.rut = this.Rut;
                usu.patente = this.Patente;
                usu.precio = this.Precio;
                usu.ruta = this.Ruta;
                usu.fecha = this.Fecha;

                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public bool TieneViajes()
        {
            
              var usu = CommonBC.ModeloSmartPay.Viaje.Count
                    (
                     user => user.rut == this.Rut
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

        public bool HayViajes()
        {

            var usu = CommonBC.ModeloSmartPay.Viaje.Count
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


        #endregion
    }
}
