<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="AdmViajes.aspx.cs" Inherits="WebBibliotecas.AdmViajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:Label ID="lbTitulo" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="codigo" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" AllowPaging="True">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="rut" HeaderText="rut" SortExpression="rut" />
            <asp:BoundField DataField="patente" HeaderText="patente" SortExpression="patente" />
            <asp:BoundField DataField="ruta" HeaderText="ruta" SortExpression="ruta" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
            <asp:BoundField DataField="codigo" HeaderText="codigo" InsertVisible="False" ReadOnly="True" SortExpression="codigo" />
            <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
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
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
    <p>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" DeleteCommand="DELETE FROM [Viaje] WHERE [codigo] = @codigo" InsertCommand="INSERT INTO [Viaje] ([rut], [patente], [ruta], [precio], [fecha]) VALUES (@rut, @patente, @ruta, @precio, @fecha)" SelectCommand="SELECT * FROM [Viaje]" UpdateCommand="UPDATE [Viaje] SET [rut] = @rut, [patente] = @patente, [ruta] = @ruta, [precio] = @precio, [fecha] = @fecha WHERE [codigo] = @codigo">
        <DeleteParameters>
            <asp:Parameter Name="codigo" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="rut" Type="String" />
            <asp:Parameter Name="patente" Type="String" />
            <asp:Parameter Name="ruta" Type="String" />
            <asp:Parameter Name="precio" Type="Decimal" />
            <asp:Parameter DbType="Date" Name="fecha" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="rut" Type="String" />
            <asp:Parameter Name="patente" Type="String" />
            <asp:Parameter Name="ruta" Type="String" />
            <asp:Parameter Name="precio" Type="Decimal" />
            <asp:Parameter DbType="Date" Name="fecha" />
            <asp:Parameter Name="codigo" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
