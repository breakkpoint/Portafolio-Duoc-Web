using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Dalc;

namespace Bibliotecas.Negocio
{
    public class Vehiculo
    {
        #region-- Atributos


        private string _patente;
        private string _marca;
        private string _modelo;
        private string _rut;
        private string _color;

        #endregion

        #region-- Seters and Geters


        public string Patente1 { get => _patente; set => _patente = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Rut1 { get => _rut; set => _rut = value; }
        public string Color { get => _color; set => _color = value; }
        #endregion

        #region -- Metodos
        public Vehiculo()
        {
            Init();
        }
        private void Init()
        {
            this.Patente1 = string.Empty;
            this.Color = string.Empty;
            this.Marca = string.Empty;
            this.Modelo = string.Empty;
            this.Rut1 = string.Empty;
        }
        public bool Create()
        {
            try
            {
                Bibliotecas.Dalc.Vehiculo usu = new Dalc.Vehiculo();

                usu.rut = this.Rut1;
                usu.patente = this.Patente1;
                usu.marca = this.Marca;
                usu.modelo = this.Modelo;
                usu.color = this.Color;

                CommonBC.ModeloSmartPay.Vehiculo.Add(usu);
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
                Bibliotecas.Dalc.Vehiculo usu = CommonBC.ModeloSmartPay.Vehiculo.First
                    (
                     user => user.patente == this.Patente1
                    );
                this.Rut1 = usu.rut;
                this.Patente1 = usu.patente;
                this.Marca = usu.marca;
                this.Modelo = usu.modelo;
                this.Color = usu.color;

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
                Bibliotecas.Dalc.Vehiculo usu = CommonBC.ModeloSmartPay.Vehiculo.First
                    (
                     user => user.patente == this.Patente1

                    );
                CommonBC.ModeloSmartPay.Vehiculo.Remove(usu);
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

                var ve = CommonBC.ModeloSmartPay.Vehiculo.First(
                        aux => aux.patente == this.Patente1);

                ve.modelo = this.Modelo;
                ve.marca = this.Marca;
                ve.color = this.Color;
            
                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }


        public bool TieneVehiculo()
        {

            var usu = CommonBC.ModeloSmartPay.Vehiculo.Count
                (
                 user => user.rut == this.Rut1
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


        public Boolean ViajeRealizado(string patente, DateTime fecha, string ruta)
        {
            var cont = CommonBC.ModeloSmartPay.Viaje.Count(
                user => user.patente == patente && user.fecha == fecha && user.ruta == ruta);

            if (cont == 0)
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

