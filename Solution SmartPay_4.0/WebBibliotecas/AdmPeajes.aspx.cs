using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bibliotecas.Negocio;

namespace WebBibliotecas
{
    public partial class AdmPeajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "LISTADO DE RUTAS";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Peaje pe = new Peaje();

            if (VacioAgregar())
            {
                if (EsNumerico(txtcantportico.Text, txtDescuento.Text, txtprecio.Text))
                {
                    if (Positivo())
                    {
                        if (porcentaje())
                        {
                            pe.Ruta = txtRuta.Text;
                            pe.Precio = Convert.ToInt32(txtprecio.Text);
                            pe.Descuento = Convert.ToSingle(txtDescuento.Text);
                            pe.Cantidad_portico = Convert.ToInt32(txtcantportico.Text);
                            pe.Create();
                            Server.Transfer("AdmPeajes.aspx");
                        }
                        else
                        {
                            string script = @"<script type='text/javascript'>
                            alerta('El porcentaje debe estar entre 0 y 100');
                        </script>";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                        }
                    }
                    else
                    {
                        string script = @"<script type='text/javascript'>
                            alerta('Debe ingresar numeros positivos');
                        </script>";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    }
                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('Debe ingresar numeros enteros');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('No pueden haber campos vacios');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        public Boolean EsNumerico(string numero, string numero2, string numero3)
        {
            try
            {
                Convert.ToInt32(numero);
                Convert.ToInt32(numero2);
                Convert.ToInt32(numero3);

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        protected void RowDelting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void RowDeltingEvent(object sender, GridViewDeleteEventArgs e)
        {
            Bibliotecas.Negocio.Peaje us = new Bibliotecas.Negocio.Peaje();
            string valor = GBPeaje.Rows[e.RowIndex].Cells[0].Text;
            us.EliminarPeaje(valor);
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            System.Web.UI.HtmlControls.HtmlForm form = new System.Web.UI.HtmlControls.HtmlForm();


            GBPeaje.AllowPaging = false;
            GBPeaje.DataBind();
            GBPeaje.EnableViewState = false;



            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(GBPeaje);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/xls";
            Response.AddHeader("Content-Disposition", "attachment;filename=ViajesRealizados.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }

        public Boolean EsPositivo(string texto)
        {
            int num = Convert.ToInt32(texto);
            if (num >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean Positivo()
        {
            Boolean num = EsPositivo(txtprecio.Text);
            Boolean num2 = EsPositivo(txtDescuento.Text);
            Boolean num3 = EsPositivo(txtcantportico.Text);
            if (num == true && num2 == true && num3 == true)
            {
                return true;
            }
            else
            {
                return false;
            }

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

        public Boolean porcentaje()
        {
            int porce = Convert.ToInt32(txtDescuento.Text);
            if (porce >= 0 && porce <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        protected void GBPeaje_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {


            
            GridViewRow row = (GridViewRow)GBPeaje.Rows[e.RowIndex];
         
            TextBox tprecio = (TextBox)row.FindControl("txtprecio2");
            TextBox tdesc = (TextBox)row.FindControl("txtDesc2");
            TextBox tcantpor = (TextBox)row.FindControl("txtCantPor2");
            string pre = tprecio.Text;
            string des = tdesc.Text;
            string can = tcantpor.Text;       


            #region CodigoVaLidacion
            Bibliotecas.Negocio.Peaje pej = new Bibliotecas.Negocio.Peaje();

            string ruta = GBPeaje.Rows[e.RowIndex].Cells[0].Text;


            if (vacio(pre, can, des))
            {
                if (EsNumero(pre, can, des))
                {
                    pej.Ruta = ruta;
                    pej.Precio = Convert.ToDecimal(pre);
                    pej.Descuento = Convert.ToSingle(des);
                    pej.Cantidad_portico = Convert.ToInt32(can);
                    pej.UpdateCompleto();
                }
                else
                {

                    e.Cancel = true;
                    string script = @"<script type='text/javascript'>
                            alerta('Debe ingresar numeros enteros');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                e.Cancel = true;
                string script = @"<script type='text/javascript'>
                            alerta('Ningun campo puede estar vacio');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
            #endregion


        }

        public Boolean vacio(string precio, string cantportico, string descuento)
        {


            if (precio == "")
            {
                return false;
            }
            else if (cantportico == "")
            {
                return false;
            }
            else if (descuento == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public Boolean EsNumero(string precio, string cantportico, string descuento)
        {
            try
            {

                Convert.ToInt32(precio);
                Convert.ToInt32(cantportico);
                Convert.ToInt32(descuento);

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public Boolean VacioAgregar()
        {
            if (txtRuta.Text == "")
            {
                return false;
            }
            else if (txtprecio.Text == "")
            {
                return false;
            }
            else if (txtDescuento.Text == "")
            {
                return false;
            }
            else if (txtcantportico.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }



        }

        protected void GBPeaje_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
          
        }
    }

    

   
}