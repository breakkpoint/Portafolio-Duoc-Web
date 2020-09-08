using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bibliotecas.Negocio;


namespace WebBibliotecas
{
    public partial class Registro : System.Web.UI.Page
    {
        private List<Registro> MiEquipoS
        {
            get
            {
                if (Session["sEquipo"] == null)
                {
                    Session["sEquipo"] = new List<Registro>();
                }
                return (List<Registro>)Session["sEquipo"];
            }

            set
            {
                Session["sEquipo"] = value;
            }
        }

   
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           Usuario us = new Usuario();

            

            us.Rut1 =txtRut.Text;
            us.Password1 = txtPass.Text; ;
            us.Saldo = 50000;
            us.Telefono = txtfono.Text;
            us.Nombre1 = txtNombre.Text;
            us.Fecha = DateTime.Now;
            us.Direccion = txtdireccion.Text;

            if ((Esnumero()) && (LargoRut()))
            {

                if (LargoFono())
                {
                    if (ValidarFono())
                    {
                        if (us.Create())
                        {

                            Server.Transfer("Index.aspx");

                        }
                        else
                        {
                            string script = @"<script type='text/javascript'>
                            alerta('El Usuario ya existe');
                        </script>";

                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                        }
                    }
                    else
                    {
                        string script = @"<script type='text/javascript'>
                            alerta('Numero no valido');
                        </script>";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    }
                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('Largo de telefono debe ser de 8 numeros');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
               
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('Rut no valido ');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                
            }

                 


        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Index.aspx");
        }

        public Boolean Esnumero()
        {
            try
            {
                char[] arre = txtRut.Text.ToCharArray();
                for (int i = 0; i < txtRut.Text.Length; i++)
                {
                    string num = arre[i].ToString();
                    if ((i == 8) && (num != "-"))
                    {
                        return false;
                    }
                   else if ((i == 8) && (num == "-"))
                    {
                        
                    }
                    else if (i == 9 && CodigoRut(num) == false )
                    {
                        return false;
                    }
                     else if ((i == 9 )&& (CodigoRut(num)))
                    {
                        return true;
                    }
                    else
                    {
                        
                        Convert.ToInt32(num);
                    }
                }

                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean LargoRut()
        {
            if (txtRut.Text.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean LargoFono()
        {
            if (txtfono.Text.Length == 8)
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
                char[] arre = txtfono.Text.ToCharArray();
                int num = Convert.ToInt32(txtfono.Text);


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
                char[] arre = txtfono.Text.ToCharArray();
                Convert.ToInt32(arre[0].ToString());

                return false;
            }
            catch (Exception)
            {

                return true;
            }
        }

       public Boolean CodigoRut(string num)
        {
            if (Numero(num))
            {
                return true;
            }
            else if (num=="k")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

 
        public Boolean Numero(string num)
        {
            switch (num)
            {
                case "1":
                    return true;
                    break;
                case "2":
                    return true;
                    break;
                case "3":
                    return true;
                    break;
                case "4":
                    return true;
                    break;
                case "5":
                    return true;
                    break;
                case "6":
                    return true;
                    break;
                case "7":
                    return true;
                    break;
                case "8":
                    return true;
                    break;
                case "9":
                    return true;
                    break;
                case "0":
                    return true;
                    break;
                
            }
            return false; ;
        }
    }
}