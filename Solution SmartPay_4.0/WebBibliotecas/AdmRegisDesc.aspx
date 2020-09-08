<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="AdmRegisDesc.aspx.cs" Inherits="WebBibliotecas.AdmRegisDesc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbTitulo" runat="server" Text="LISTADO DE REGISTRO DE DESCUENTO"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" AllowPaging="True">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="porcentaje" HeaderText="porcentaje" SortExpression="porcentaje" />
            <asp:BoundField DataField="ruta" HeaderText="ruta" SortExpression="ruta" />
            <asp:BoundField DataField="rut" HeaderText="rut" SortExpression="rut" />
            <asp:BoundField DataField="peajes" HeaderText="peajes" SortExpression="peajes" />
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
</p>
    <p>
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
</p>
    <p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" DeleteCommand="DELETE FROM [RegistroDescuento] WHERE [id] = @id" InsertCommand="INSERT INTO [RegistroDescuento] ([porcentaje], [ruta], [rut], [peajes], [fecha]) VALUES (@porcentaje, @ruta, @rut, @peajes, @fecha)" SelectCommand="SELECT * FROM [RegistroDescuento]" UpdateCommand="UPDATE [RegistroDescuento] SET [porcentaje] = @porcentaje, [ruta] = @ruta, [rut] = @rut, [peajes] = @peajes, [fecha] = @fecha WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="porcentaje" Type="Decimal" />
            <asp:Parameter Name="ruta" Type="String" />
            <asp:Parameter Name="rut" Type="String" />
            <asp:Parameter Name="peajes" Type="Int32" />
            <asp:Parameter DbType="Date" Name="fecha" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="porcentaje" Type="Decimal" />
            <asp:Parameter Name="ruta" Type="String" />
            <asp:Parameter Name="rut" Type="String" />
            <asp:Parameter Name="peajes" Type="Int32" />
            <asp:Parameter DbType="Date" Name="fecha" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
