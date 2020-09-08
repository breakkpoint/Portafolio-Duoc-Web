using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Dalc;

namespace Bibliotecas.Negocio
{
    public class Usuario
    {
        #region--Atributos

        private string _rut;
        private string _nombre;
        private float _saldo;
        private DateTime _fecha;
        private string _password;
        private string _direccion;
        private string _telefono;
        private string _activo;



        #endregion

        #region --geters and Seters



        public string Rut1 { get => _rut; set => _rut = value; }
        public string Nombre1 { get => _nombre; set => _nombre = value; }
        public float Saldo { get => _saldo; set => _saldo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Password1 { get => _password; set => _password = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Activo { get => _activo; set => _activo = value; }
        #endregion

        #region-- Metodos
        public Usuario()
        {
            Init();
        }
        private void Init()
        {
            this.Rut1 = string.Empty;
            this.Nombre1 = string.Empty;
            this.Fecha = DateTime.Now;
            this.Direccion = string.Empty;
            this.Password1 = string.Empty;
            this.Telefono = string.Empty;
            this.Saldo = 50000F;
            this.Activo = "Si";

        }
        public bool Create()
        {
            try
            {
                Bibliotecas.Dalc.Usuario usu = new Dalc.Usuario();

                usu.rut = this.Rut1;
                usu.saldo = this.Saldo;
                usu.nombre = this.Nombre1;
                usu.telefono = this.Telefono;
                usu.direccion = this.Direccion;
                usu.contraseña = this.Password1;
                usu.FechaRegistro = this.Fecha;
                usu.activo = this.Activo;


                CommonBC.ModeloSmartPay.Usuario.Add(usu);
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
                Bibliotecas.Dalc.Usuario usu = CommonBC.ModeloSmartPay.Usuario.First
                    (
                     user => user.rut == this.Rut1
                    );


                this.Rut1 = usu.rut;
                this.Saldo = Convert.ToSingle(usu.saldo);
                this.Nombre1 = usu.nombre;
                this.Telefono = usu.telefono;
                this.Direccion = usu.direccion;
                this.Password1 = usu.contraseña;



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
                Bibliotecas.Dalc.Usuario usu = CommonBC.ModeloSmartPay.Usuario.First
                    (
                     user => user.rut == this.Rut1

                    );
                CommonBC.ModeloSmartPay.Usuario.Remove(usu);
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

                var usu = CommonBC.ModeloSmartPay.Usuario.First(
                        aux => aux.rut == this.Rut1);


                //usu.saldo = this.Saldo;
                //usu.nombre = this.Nombre1;
                usu.telefono = this.Telefono;
                usu.direccion = this.Direccion;
                usu.contraseña = this.Password1;

                CommonBC.ModeloSmartPay.SaveChanges();

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

                var usu = CommonBC.ModeloSmartPay.Usuario.First(
                        aux => aux.rut == this.Rut1);


                usu.saldo = this.Saldo;
                usu.nombre = this.Nombre1;
                usu.telefono = this.Telefono;
                usu.direccion = this.Direccion;
                usu.contraseña = this.Password1;
                usu.FechaRegistro = this.Fecha;
                usu.activo = this.Activo;
                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }

        public bool ValidarUsuario(string user, string pass)
        {
            try
            {
                var consulta = CommonBC.ModeloSmartPay.Usuario.First(
                    aux => aux.rut == user && aux.contraseña == pass);

                if (consulta.rut == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool ValidarActivo(string user)
        {
            try
            {
                var consulta = CommonBC.ModeloSmartPay.Usuario.First(
                    aux => aux.rut == user && aux.activo == "Si");

                if (consulta.rut == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }




        public Boolean UpdateEstadoActivo()
        {
            try
            {

                var usu = CommonBC.ModeloSmartPay.Usuario.First(
                aux => aux.rut == this.Rut1);
                usu.activo = this.Activo;


                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }


        public Boolean UpdateSaldo()
        {
            try
            {

                var usu = CommonBC.ModeloSmartPay.Usuario.First(
                aux => aux.rut == this.Rut1);
                usu.saldo = this.Saldo;


                CommonBC.ModeloSmartPay.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }


        public Boolean SaldoSuficiente(string rut, float saldo)
        {
            Usuario us = new Usuario();
            us.Rut1 = rut;
            us.Read();

            if (us.Saldo < saldo)
            {
                return false;
            }

            return true;
        }

        public Boolean EliminarUsuario(string rut)
        {
            EliminarVehUsuario(rut);
            EliminarViajeUsuario(rut);
            Usuario us = new Usuario();
            us.Rut1 = rut;
            us.Delete();

            return true;
        }

        private Boolean EliminarVehUsuarioSinLiq(string rut)
        {
            try
            {
                var col = CommonBC.ModeloSmartPay.Vehiculo;

                foreach (var item in col.ToList())
                {
                    if (item.rut == rut)
                    {
                        Usuario us = new Usuario();
                        us.Rut1 = item.rut;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public  Boolean EliminarViajeUsuario(string rut)
        {
            try
            {
                var col = (from cust in CommonBC.ModeloSmartPay.Viaje
                          where cust.rut==rut select cust).ToList();

                foreach (var item in col)
                {
                    if (item.rut == rut)
                    {
                        Viaje ve = new Viaje();
                        ve.Codigo = item.codigo;
                        ve.Delete();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

                    }

        public Boolean EliminarVehUsuario(string rut)
        {
            try
            {


                var custQuery =
                        (from cust in CommonBC.ModeloSmartPay.Vehiculo
                        where cust.rut == rut
                        select cust).ToList();

                foreach (var item in custQuery)
                {
                    Vehiculo ve = new Vehiculo();
                    ve.Patente1 = item.patente;
                    ve.Delete();

                }
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

