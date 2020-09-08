using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBibliotecas
{
    public partial class Viajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SaldoActual();
        }



        protected void btnPagar_Click(object sender, EventArgs e)
        {
            string rut = Session["CLAVE"].ToString();
            Bibliotecas.Negocio.Usuario user = new Bibliotecas.Negocio.Usuario();
            user.Rut1 = rut;
            float total = Convert.ToSingle(txtTotal.Text);


            if (ValidarCampos())
            {
                if (user.SaldoSuficiente(rut, total))
                {
                    Bibliotecas.Negocio.Viaje ve = new Bibliotecas.Negocio.Viaje();

                    user.Read();
                    int saldo = Convert.ToInt32(user.Saldo);

                    ve.Rut = rut;
                    ve.Fecha = CLFecha.SelectedDate;
                    ve.Patente = DLPatente.SelectedValue;
                    ve.Ruta = DLruta.SelectedValue;
                    ve.Precio = Convert.ToDecimal(txtTotal.Text);
                    ve.Create();

                    Bibliotecas.Negocio.Peaje pe = new Bibliotecas.Negocio.Peaje();
                    pe.Ruta = DLruta.SelectedValue;
                    pe.Read();

                    user.Saldo = saldo - Convert.ToSingle(txtTotal.Text);
                    user.UpdateSaldo();

                    Bibliotecas.Negocio.RegistroDescuento re = new Bibliotecas.Negocio.RegistroDescuento();
                    re.Rut = rut;
                    re.Fecha = DateTime.Now;
                    re.Peaje = pe.Cantidad_portico;
                    re.Ruta = DLruta.SelectedValue;
                    re.Porcentaje = Convert.ToDecimal(pe.Descuento);
                    re.Create();
                    SaldoActual();

                    string script = @"<script type='text/javascript'>
                            alerta('Viaje realizado');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('No tiene saldo suficiente');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('Campo patente o fecha no validos');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }

           
        }

        public double  descuento()
         {
            Bibliotecas.Negocio.Peaje pe = new Bibliotecas.Negocio.Peaje();
            pe.Ruta = DLruta.ToString();
            pe.Read();

            float des = Convert.ToSingle(pe.Descuento);
            return des;
         }

        public void llenartexbox()
        {
           


                Bibliotecas.Negocio.Peaje pe = new Bibliotecas.Negocio.Peaje();
                string a = string.Empty;
                pe.Ruta = DLruta.SelectedValue;
                a = DLruta.SelectedValue;
                pe.Read();
                int cant = pe.Cantidad_portico;

                float des = pe.Descuento /100;
                Decimal pre = pe.Precio;
                int desc = Convert.ToInt32(Convert.ToSingle(pre) * des);
                int total = Convert.ToInt32(pre) - desc;

                txtPrecio.Text = pre.ToString();
                txtCantidad.Text = cant.ToString();
                txtDescuento.Text = desc.ToString();
                txtTotal.Text = total.ToString();
            
            

        }

        protected void DLruta_TextChanged(object sender, EventArgs e)
        {
            //llenartexbox();
        }

        protected void DLruta_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenartexbox();
          
        }

        protected void EntityDataSource2_Selecting(object sender, EntityDataSourceSelectingEventArgs e)
        {

        }

        public Boolean ValidarCampos()
        {
            
            int numero = DateTime.Compare(CLFecha.SelectedDate, DateTime.Now.Date);
            if ((numero < 0) || ( DLPatente.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public void SaldoActual()
        {
            string rut = Session["CLAVE"].ToString();
            Bibliotecas.Negocio.Usuario us = new Bibliotecas.Negocio.Usuario();
            us.Rut1 = rut;
            us.Read();
            lbSaldo.Text = "Su saldo actual es: $" + us.Saldo.ToString();
        }   

        
    }
}