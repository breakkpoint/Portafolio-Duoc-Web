using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBibliotecas
{
    public partial class AdmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "LISTADO DE USUARIOS";
        }

        

        protected void RowDeletingEvent(object sender, GridViewDeleteEventArgs e)
        {
            Bibliotecas.Negocio.Usuario us = new Bibliotecas.Negocio.Usuario();
            string valor = GbUser.Rows[e.RowIndex].Cells[0].Text;
            us.EliminarUsuario(valor);
        }

        protected void GbUser_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            System.Web.UI.HtmlControls.HtmlForm form = new System.Web.UI.HtmlControls.HtmlForm();


            GbUser.AllowPaging = false;
            GbUser.DataBind();
            GbUser.EnableViewState = false;



            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(GbUser);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/xls";
            Response.AddHeader("Content-Disposition", "attachment;filename=Usuarios.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }

        protected void GbUser_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GbUser.Rows[e.RowIndex];

            TextBox tnom = (TextBox)row.FindControl("txtnombre2");
            TextBox tdirec = (TextBox)row.FindControl("txtdireccion2");
            TextBox tel = (TextBox)row.FindControl("txtTelefono2");
            TextBox tcon = (TextBox)row.FindControl("txtcontra");
            TextBox tsaldo = (TextBox)row.FindControl("txtsaldo2");
            TextBox tfecha = (TextBox)row.FindControl("txtFecha2");
            TextBox tActivo = (TextBox)row.FindControl("txtactivo2");

          


            #region CodigoVaLidacion
            Bibliotecas.Negocio.Usuario us = new Bibliotecas.Negocio.Usuario();

            string rut = GbUser.Rows[e.RowIndex].Cells[0].Text;


            if (vacio(tnom.Text,tdirec.Text,tel.Text,tcon.Text,tfecha.Text,tActivo.Text,tsaldo.Text))
            {
                if (ValidarActivo(tActivo.Text))
                {
                    us.Rut1 = rut;
                    us.Nombre1 = tnom.Text;
                    us.Telefono =tel.Text;
                    us.Direccion = tdirec.Text;
                    us.Fecha = Convert.ToDateTime(tfecha.Text);
                    us.Password1 = tcon.Text;
                    us.Saldo = Convert.ToSingle(tsaldo.Text);
                    us.Activo = tActivo.Text;                
                }
                else
                {

                    e.Cancel = true;
                    string script = @"<script type='text/javascript'>
                            alerta('El valor de activo debe ser Si o No');
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

        public Boolean vacio(string nom , string dir , string fon , string pass,
            string fech, string act, string sal)
        {
            if (nom=="")
            {
                return false;
            }
            else if (dir == "")
            {
                return false;
            }
            else if (fon == "")
            {
                return false;
            }
            else if (pass == "")
            {
                return false;
            }
            else if (fech == "")
            {
                return false;
            }
            else if (sal == "")
            {
                return false;
            }
            else if (act == "")
            {
                return false;
            }
            else
            {
                return true;
            }

          
        }

        public Boolean ValidarActivo(string activo)
        {
            if (activo=="Si")
            {
                return true;
            }
            else if (activo =="No")
            {
                return true;
            }
            else
            {
                return false;
            }


        }



        

        public Boolean LargoFono(string txtfono)
        {
            if (txtfono.Length > 12)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean ValidarFono(string txtfono)
        {

            try
            {
                char[] arre = txtfono.ToCharArray();
                int num = Convert.ToInt32(txtfono);

                if ((arre[0].ToString() != "+") && (NoESNumero(txtfono)))
                {
                    return false; ;
                }
                else if (num < 0)
                {
                    return false;
                }
                else
                {
                    for (int i = 1; i < txtfono.Length; i++)
                    {

                        Convert.ToInt32(txtfono[i]);
                    }
                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean NoESNumero(string  txtfono)
        {
            try
            {
                char[] arre = txtfono.ToCharArray();
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