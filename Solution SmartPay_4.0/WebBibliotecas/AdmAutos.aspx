<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="AdmAutos.aspx.cs" Inherits="WebBibliotecas.AdmAutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:Label ID="lbTitulo" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="patente" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" AllowPaging="True">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="patente" HeaderText="patente" ReadOnly="True" SortExpression="patente" />
            <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
            <asp:BoundField DataField="modelo" HeaderText="modelo" SortExpression="modelo" />
            <asp:BoundField DataField="color" HeaderText="color" SortExpression="color" />
            <asp:BoundField DataField="rut" HeaderText="rut" SortExpression="rut" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" DeleteCommand="DELETE FROM [Vehiculo] WHERE [patente] = @patente" InsertCommand="INSERT INTO [Vehiculo] ([patente], [marca], [modelo], [color], [rut]) VALUES (@patente, @marca, @modelo, @color, @rut)" SelectCommand="SELECT * FROM [Vehiculo]" UpdateCommand="UPDATE [Vehiculo] SET [marca] = @marca, [modelo] = @modelo, [color] = @color, [rut] = @rut WHERE [patente] = @patente">
        <DeleteParameters>
            <asp:Parameter Name="patente" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="patente" Type="String" />
            <asp:Parameter Name="marca" Type="String" />
            <asp:Parameter Name="modelo" Type="String" />
            <asp:Parameter Name="color" Type="String" />
            <asp:Parameter Name="rut" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="marca" Type="String" />
            <asp:Parameter Name="modelo" Type="String" />
            <asp:Parameter Name="color" Type="String" />
            <asp:Parameter Name="rut" Type="String" />
            <asp:Parameter Name="patente" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
    <p>
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
