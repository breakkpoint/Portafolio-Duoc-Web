using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBibliotecas
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bibliotecas.Negocio.BibliotecasCollection bl = new Bibliotecas.Negocio.BibliotecasCollection();

            LbDescuentos.Text = "Numero de descuentos realizados: " + bl.CantidadDescuentos().ToString();
            LbUsuario.Text = " Numero de usuaruios registrados: " + bl.CantidadUsuario().ToString();
            LbVehiculo.Text = " Numero de vehiculos registrados:" + bl.CantidadAutos().ToString();
            LbViajes.Text = "Numero de viajes registrados: " + bl.CantidadViajes().ToString();
            LbRutas.Text = "Numero de rutas registradas: " + bl.CantidadRutas().ToString();
        }

        protected void btnDescuento_Click(object sender, EventArgs e)
        {
            Bibliotecas.Negocio.BibliotecasCollection col = new Bibliotecas.Negocio.BibliotecasCollection();
            if (col.EsNumerico(txtDescuento.Text))
            {
                if (porcentaje())
                {
                    Bibliotecas.Negocio.BibliotecasCollection bl = new Bibliotecas.Negocio.BibliotecasCollection();
                    bl.UpdateMasivoDescuento(Convert.ToInt32(txtDescuento.Text));
                    Server.Transfer("Admin.aspx");
                }
                else
                {
                    string script = @"<script type='text/javascript'>
                            alerta('Porcentaje fuera de rango 0 a 100');
                        </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alerta('Lo sentimos ese no es un numero entero');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            System.Web.UI.HtmlControls.HtmlForm form = new System.Web.UI.HtmlControls.HtmlForm();


            GridView1.AllowPaging = false;
            GridView1.DataBind();
            GridView1.EnableViewState = false;



            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(GridView1);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/xls";
            Response.AddHeader("Content-Disposition", "attachment;filename=TodasLasRutas.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];

            TextBox tprecio = (TextBox)row.FindControl("txtprecio2");
            TextBox tdesc = (TextBox)row.FindControl("txtDesc2");
            TextBox tcantpor = (TextBox)row.FindControl("txtCantPor2");
            string pre = tprecio.Text;
            string des = tdesc.Text;
            string can = tcantpor.Text;


            #region CodigoVaLidacion
            Bibliotecas.Negocio.Peaje pej = new Bibliotecas.Negocio.Peaje();

            string ruta = GridView1.Rows[e.RowIndex].Cells[0].Text;


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

    }
}