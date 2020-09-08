using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bibliotecas.Negocio;
namespace WebBibliotecas
{
    public partial class Perfil : System.Web.UI.Page
    {
        public static string sesion = string.Empty;
        public static int contador = 0;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                sesion = Session["CLAVE"].ToString();
                llenarLabel();
                llenarLabelVehiculo();
                llenarTexbox();
            }






        }

        public void Limpiar()
        {
            txtNombre.Text = " ";
            txtRut.Text = " ";
            txtTelefono.Text = " ";
            txtSaldo.Text = " ";
            txtPastword.Text = " ";
            txtDireccion.Text = " ";
        }

        public void llenarTexbox()
        {

            Usuario u = new Usuario();


            u.Rut1 = sesion;

            u.Read();

            txtNombre.Text = u.Nombre1;
            txtRut.Text = u.Rut1;
            txtTelefono.Text = u.Telefono;
            txtSaldo.Text = "$"+u.Saldo.ToString();
            txtPastword.Text = u.Password1;
            txtDireccion.Text = u.Direccion;




        }

        public void llenarLabel()
        {


            lbSaldo.Text = "Saldo";
            lbTitulo.Text = "MIS DATOS";
            lbTitulo2.Text = "MI MONEDERO";



        }

        public void llenarLabelVehiculo()
        {

            Bibliotecas.Negocio.Vehiculo ve = new Bibliotecas.Negocio.Vehiculo();
            ve.Rut1 = sesion;
            if (ve.TieneVehiculo())
            {
                lbhayVehivulo.Text = "TUS VEHICULOS DISPONIBLES";
            }
            else
            {
                lbhayVehivulo.Text = "NO HAY VEHICULOS DISPONIBLES";
            }


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            Bibliotecas.Negocio.Usuario u = new Bibliotecas.Negocio.Usuario();
            u.Rut1 = sesion;
            u.Direccion = txtDireccion.Text;
            u.Telefono = txtTelefono.Text;
            u.Password1 = txtPastword.Text;
            if (UpdateVacio())
            {

                if (LargoFono())
                {


                    if (ValidarFono())
                    {
                        u.Update();
                        contador -= contador;

                        llenarTexbox();

                        string script = @"<script type='text/javascript'>
                            alerta('Su informacion a sido actualizada');
                        </script>";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                    }
                    else
                    {
                        string script = @"<script type='text/javascript'>
                            alerta('Telefono no valido');
                        </script>";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                    }
                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('El largo del telefono debe ser de 8 caracteres');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                }
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('Ningun campo puede estar vacio');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }




        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

            Bibliotecas.Negocio.Usuario u = new Bibliotecas.Negocio.Usuario();
            u.Rut1 = sesion;
            u.Activo = "No";
            u.UpdateEstadoActivo();
            Server.Transfer("Index.aspx");

        }

        protected void btnVehiculo_Click(object sender, EventArgs e)
        {
            Server.Transfer("Vehiculo.aspx");
        }

        protected void btnCargarSaldo_Click(object sender, EventArgs e)
        {
            if (EsNumero())
            {
                if (SoloPositivo())
                {
                    Usuario us = new Usuario();
                    us.Rut1 = sesion;
                    us.Saldo = Convert.ToSingle(txtIngSaldo.Text) + Convert.ToSingle(txtSaldo.Text);
                    us.UpdateSaldo();
                    Server.Transfer("Perfil.aspx");
                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('No puede disminuir su saldo');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('Debe ingresar un numero entero');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }

        }

        public Boolean EsNumero()
        {
            try
            {
                Convert.ToInt32(txtSaldo.Text);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public Boolean SoloPositivo()
        {
            try
            {
                int num = Convert.ToInt32(txtIngSaldo.Text);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean UpdateVacio()
        {
            if (txtDireccion.Text == "")
            {
                return false;
            }
            else if (txtTelefono.Text == "")
            {
                return false;
            }
            else if (txtPastword.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        

        public Boolean LargoFono()
        {
            if (txtTelefono.Text.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidarFono()
        {

            try
            {
                char[] arre = txtTelefono.Text.ToCharArray();
                int num = Convert.ToInt32(txtTelefono.Text);

                
                 if (num < 0)
                {
                    return false;
                }
                else
                {
                    for (int i = 1; i < arre.Length; i++)
                    {

                        Convert.ToInt32(arre[i].ToString());
                    }
                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean NoESNumero()
        {
            try
            {
                char[] arre = txtTelefono.Text.ToCharArray();
                Convert.ToInt32(arre[0].ToString());

                return false;
            }
            catch (Exception)
            {

                return true;
            }
        }
    }
}