<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebBibliotecas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;
        

        <asp:Label ID="lbBienvenida" runat="server" Text="Label"></asp:Label>
        

        <p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" SelectCommand="SELECT [rut], [patente], [ruta], [precio], [fecha] FROM [Viaje] WHERE ([rut] = @rut)">
        <SelectParameters>
            <asp:SessionParameter Name="rut" SessionField="CLAVE" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lbTitulo" runat="server" Text="LISTADO DE SUS  VIAJES REALIZADOS"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="269px" Width="787px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="rut" HeaderText="rut" SortExpression="rut" >
            </asp:BoundField>
            <asp:BoundField DataField="patente" HeaderText="patente" SortExpression="patente" >
            </asp:BoundField>
            <asp:BoundField DataField="ruta" HeaderText="ruta" SortExpression="ruta" >
            </asp:BoundField>
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
&nbsp;<asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="EXPORTAR " />
    </p>

</p>
   <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d31703.966680633534!2d-70.70803326798229!3d-33.34916400912288!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x96626f6a7df81e51%3A0x60cdc26d444b83da!2sRegi%C3%B3n+Metropolitana!5e0!3m2!1ses-419!2scl!4v1536778911235" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe><p>
    &nbsp;
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
