using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bibliotecas.Negocio;

namespace WebBibliotecas
{
    public partial class Index : System.Web.UI.Page
    {
        Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registro.aspx");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario us = new Usuario();

           
                if (us.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
                {
                    if (EsAdmin())
                    {
                        Session["CLAVE"] = txtUsuario.Text;
                        Server.Transfer("Admin.aspx");

                    }
                    else
                    {
                    
                        if (us.ValidarActivo(txtUsuario.Text))
                        {

                            Session["CLAVE"] = txtUsuario.Text;
                            Server.Transfer("Inicio.aspx");

                        }
                        else
                        {
                            string script = @"<script type='text/javascript'>
                            alerta('Usuario desactivado o eliminado porfavor contacte al administrador');
                        </script>";

                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                        }
                    
                    
                    }

                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('Rut o Password incorrectas');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            
                     


        }

        public Boolean EsAdmin()
        {
            if ((txtUsuario.Text=="admin") && (txtPassword.Text=="admin"))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        
        public Boolean Esnumero()
        {
            try
            {
                for (int i = 0; i < txtUsuario.Text.Length; i++)
            {
                    if (txtUsuario.Text[i] == '-')
                    {
                        break;
                    }
                    else
                    {
                        Convert.ToInt32(txtUsuario.Text[i]);
                    }
            }            
               
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean Largo()
        {
            if (txtUsuario.Text.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}