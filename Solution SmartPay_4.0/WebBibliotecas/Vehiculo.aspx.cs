using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBibliotecas
{
    public partial class Vehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Bibliotecas.Negocio.Vehiculo ve = new Bibliotecas.Negocio.Vehiculo();


            if (Vacio()==false)
            {
                
                if (ValidarColorYMarca())
                {

                    if (LargoPatente(txtpatente.Text))
                    {
                        ve.Color = txtcolor.Text;
                        ve.Marca = txtmarca.Text;
                        ve.Modelo = txtmodelo.Text;
                        ve.Patente1 = txtpatente.Text;
                        ve.Rut1 = Session["CLAVE"].ToString();

                        ve.Create();
                        Server.Transfer("Vehiculo.aspx");
                    }
                    else
                    {
                        string script = @"<script type='text/javascript'>
                            alerta('La patente debe tener 6 caracteres');
                        </script>";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    }                  

                  

                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('La marca y el color no deben tener numeros');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('No puedes tener campos vacios');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }


        }

        protected void GBauto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public Boolean ValidarString(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                string num = texto[i].ToString();
                switch (num)
                {
                    case "1":
                   
                        return false;
                    case "2":
                        return false;
                        break;
                    case "3":
                        return false;
                        break;
                    case "4":
                        return false;
                        break;
                    case "5":
                        return false;
                        break;
                    case "6":
                        return false;
                        break;
                    case "7":
                        return false;
                        break;
                    case "8":
                        return false;
                        break;
                    case "9":
                        return false;
                        break;
                    case "0":
                        return false;


                       
                }
            }
            return true;
        }

        public Boolean ValidarColorYMarca(){

            if ((ValidarString(txtcolor.Text) ) && ( ValidarString(txtmarca.Text)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean Vacio()
        {                  
                  
            if (txtcolor.Text=="")
            {
                return true;
            }
            else if (txtmarca.Text == "")
            {
                return true;
            }
            else if (txtmodelo.Text == "")
            {
                return true;
            }
            else if (txtpatente.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }


           
        }

        protected void GBauto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GBauto.Rows[e.RowIndex];

            TextBox txtMarca2= (TextBox)row.FindControl("txtMarca2");
            TextBox txtModelo2 = (TextBox)row.FindControl("txtModelo2");
            TextBox txtColor2 = (TextBox)row.FindControl("txtColor2");

            string marca = txtMarca2.Text;
            string color = txtColor2.Text;
            string modelo = txtModelo2.Text;

            Bibliotecas.Negocio.Vehiculo ve = new Bibliotecas.Negocio.Vehiculo();

            if (Vacio2(marca,color,modelo))
            {

                if (ValidarString(color))
                {
                    ve.Patente1 = GBauto.Rows[e.RowIndex].Cells[0].Text.ToString();
                    ve.Marca = marca;
                    ve.Color = color;
                    ve.Modelo = marca;
                    ve.Update();
                }
                else
                {
                    e.Cancel = true;
                    string script = @"<script type='text/javascript'>
                            alerta('No puedes tener numeros en el color');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                e.Cancel = true;
                string script = @"<script type='text/javascript'>
                            alerta('No puedes tener campos vacios');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }


        }

        public Boolean Vacio2(string marca , string color, string modelo)
        {

            if (marca == "")
            {
                return false;
            }
            else if (modelo == "")
            {
                return false;
            }
            else if (color == "")
            {
                return false;
            }
            else
            {
                return true;
            }



        }

        public Boolean LargoPatente(string patente)
        {
            if (patente.Length == 6)
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