<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="WebBibliotecas.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
  
  <div id="derecha" ; style="border-right-style"; >
<p>
    <asp:Label ID="lbTitulo" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lbNombre" runat="server" Text="Nombre:"></asp:Label>
        &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server" Width="206px" Enabled="False" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        <asp:Label ID="lbRut" runat="server" Text="Rut:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRut" runat="server" Width="209px" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbDireccion" runat="server" Text="Direccion:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDireccion" runat="server" Width="208px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbTelefono" runat="server" Text="Telefono:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefono" runat="server" Width="205px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbPassword" runat="server" Text="Password:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPastword" runat="server" Width="206px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
        <asp:Button ID="BtnEliminar" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar Cuenta" />
    </p>
    <p>
        &nbsp;</p>
      <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbTitulo2" runat="server" Text="Label"></asp:Label>
    </p>
      <p>
        &nbsp;<asp:Label ID="lbSaldo" runat="server" Text="Label"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtSaldo" runat="server" Enabled="False"></asp:TextBox>
    </p>
      <p>
        &nbsp;&nbsp;
          <asp:Button ID="btnCargarSaldo" runat="server" OnClick="btnCargarSaldo_Click" Text="Cargar Saldo" />
&nbsp;&nbsp;
          <asp:TextBox ID="txtIngSaldo" runat="server"></asp:TextBox>
    </p>
      <p>
          &nbsp;</p>
      <p>
          &nbsp;</p>
      <p>
          &nbsp;</p>
      <p>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" SelectCommand="SELECT [patente], [marca], [modelo], [color] FROM [Vehiculo] WHERE ([rut] = @rut)">
              <SelectParameters>
                  <asp:SessionParameter Name="rut" SessionField="CLAVE" Type="String" />
              </SelectParameters>
          </asp:SqlDataSource>
    </p>
      <p>
          <asp:Label ID="lbhayVehivulo" runat="server" Text="Label"></asp:Label>
    </p>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="patente" DataSourceID="SqlDataSource1" Width="414px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowPaging="True">
          <AlternatingRowStyle BackColor="#CCCCCC" />
          <Columns>
              <asp:BoundField DataField="patente" HeaderText="patente" ReadOnly="True" SortExpression="patente" />
              <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
              <asp:BoundField DataField="modelo" HeaderText="modelo" SortExpression="modelo" />
              <asp:BoundField DataField="color" HeaderText="color" SortExpression="color" />
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
      <p>
        <asp:Button ID="btnVehiculo" runat="server" Text="Agregar vehiculo" OnClick="btnVehiculo_Click" />
    </p>
      <p>
          &nbsp;</p>
    <p>
        &nbsp;</p>
     
    </div>
    <div id="Izquierda">


    </div>
</asp:Content>
