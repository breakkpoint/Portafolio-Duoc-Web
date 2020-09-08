using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Dalc;


    

namespace Bibliotecas.Negocio
{
    public class BibliotecasCollection
    {
        public BibliotecasCollection()
        {

        }

        private List<Bibliotecas.Negocio.Vehiculo> GenerarListado
            (List<Bibliotecas.Dalc.Vehiculo> biblioDALC)
        {

            try
            {
                List<Bibliotecas.Negocio.Vehiculo> bibliotecas =
                      new List<Vehiculo>();

                foreach (Bibliotecas.Dalc.Vehiculo item in biblioDALC)
                {
                    Bibliotecas.Negocio.Vehiculo bibliotecaTemporal = new Vehiculo();

                    bibliotecaTemporal.Patente1 = item.patente;
                    bibliotecaTemporal.Color = item.color;
                    bibliotecaTemporal.Marca = item.marca;
                    bibliotecaTemporal.Modelo = item.modelo;
                    bibliotecaTemporal.Rut1 = item.rut;


                    bibliotecas.Add(bibliotecaTemporal);
                }

                return bibliotecas;
            }
            catch (Exception)
            {

                throw;

            }
        }

        public List<Vehiculo> ReadAllVehiculo()
        {
            var bibliotecas = CommonBC.ModeloSmartPay.Vehiculo;
            return GenerarListado(bibliotecas.ToList());
        }

        public int CantidadUsuario()
        {
            var usu = CommonBC.ModeloSmartPay.Usuario.Count();
            return usu;
        }

        public int CantidadAutos()
        {
            var au = CommonBC.ModeloSmartPay.Vehiculo.Count();
            return au;

        }

        public int CantidadViajes()
        {
            var au = CommonBC.ModeloSmartPay.Viaje.Count();
            return au;

        }

        public int CantidadDescuentos()
        {
            var au = CommonBC.ModeloSmartPay.RegistroDescuento.Count();
            return au;

        }

        public int CantidadRutas()
        {
            var au = CommonBC.ModeloSmartPay.Peaje.Count();
            return au;

        }

        public void UpdateMasivoDescuento(int desc)
        {
            try
            {
                var bibliotecas = CommonBC.ModeloSmartPay.Peaje;
                Peaje pe = new Peaje();
                foreach (Bibliotecas.Dalc.Peaje item in bibliotecas.ToList())
                {
                    item.descuento = desc;
                    CommonBC.ModeloSmartPay.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Boolean EsNumerico(string text)
        {

            try
            {
                int a = Convert.ToInt32(text);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
