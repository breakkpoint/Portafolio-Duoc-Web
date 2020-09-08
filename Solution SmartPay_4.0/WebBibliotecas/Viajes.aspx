<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Viajes.aspx.cs" Inherits="WebBibliotecas.Viajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 373px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;<table style="width:100%;">
            <tr>
                <td class="auto-style1" aria-autocomplete="inline">
        <asp:Label ID="Label1" runat="server" Text="REALIZAR VIAJE"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbSaldo" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Bibliotecas.Dalc.SmartPayEntities2" EntityTypeName="" Select="new (patente)" TableName="Vehiculo" Where="rut == @rut">
                        <WhereParameters>
                            <asp:SessionParameter Name="rut" SessionField="CLAVE" Type="String" />
                        </WhereParameters>
                    </asp:LinqDataSource>
    <asp:EntityDataSource ID="EntityDataSource2" runat="server" ConnectionString="name=SmartPayEntities2" DefaultContainerName="SmartPayEntities2" EnableFlattening="False" EntitySetName="Peaje" Select="it.[ruta]">
    </asp:EntityDataSource>
                    <asp:Label ID="Label2" runat="server" Text="Ruta"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DLruta" runat="server" DataSourceID="EntityDataSource2" DataTextField="ruta" DataValueField="ruta" OnSelectedIndexChanged="DLruta_SelectedIndexChanged" OnDataBound="DLruta_SelectedIndexChanged" OnTextChanged="DLruta_TextChanged" AutoPostBack="True">
        </asp:DropDownList>
                    <br />
                    <br />
    <asp:Label ID="Label3" runat="server" Text="Patente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DLPatente" runat="server" DataSourceID="LinqDataSource1" DataTextField="patente" DataValueField="patente">
    </asp:DropDownList>
                    <br />
                    <br />
        <asp:Label ID="Label4" runat="server" Text="Cantidad porticos"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtCantidad" runat="server" Enabled="False"></asp:TextBox>
                    <br />
        <asp:Label ID="Label8" runat="server" Text="Fecha"></asp:Label>
    <asp:Calendar ID="CLFecha" runat="server"></asp:Calendar>
                    <br />
        <asp:Label ID="Label5" runat="server" Text="Precio"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrecio" runat="server" Enabled="False"></asp:TextBox>
                    <br />
    <asp:Label ID="Label6" runat="server" Text="Descuento"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtDescuento" runat="server" Enabled="False"></asp:TextBox>
                    <br />
        <asp:Label ID="Label7" runat="server" Text="Total a pagar"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTotal" runat="server" Enabled="False"></asp:TextBox>
                    <br />
                    <br />
                    <br />
    <asp:Button ID="btnPagar" runat="server" OnClick="btnPagar_Click" Text="PAGAR" />
                    <br />
                </td>
                <td>&nbsp;</td>
               
            </tr>
            
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
               
            </tr>
            
        </table>
    </p>

</asp:Content>
