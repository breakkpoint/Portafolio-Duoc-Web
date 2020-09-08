<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebBibliotecas.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
        .auto-style2 {
            margin-right: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:Label ID="Label5" runat="server" Text="BIENVENIDO ADMINISTRADOR"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Estadisticas"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LbUsuario" runat="server" Text="Numero de usuaruios registrados:"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LbVehiculo" runat="server" Text="Numero de vehiculos registrados:"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LbViajes" runat="server" Text="Numero de viajes registrados:"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LbDescuentos" runat="server" Text="Numero de descuentos realizados:"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="LbRutas" runat="server" Text="Numero de rutas registradas:"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Rutas en Sistema"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CssClass="auto-style1" DataKeyNames="ruta" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Width="383px" OnRowUpdating="GridView1_RowUpdating">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="ruta" HeaderText="ruta" ReadOnly="True" SortExpression="ruta" />
               
               <asp:TemplateField HeaderText="Precio">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<% #Bind("precio") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtprecio2" runat="server" Text='<% #Bind("precio") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Cantidad Portico">
                <ItemTemplate>
                    <asp:Label ID="Label23" runat="server" Text='<% #Bind("cantPortico") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtCantPor2" runat="server" Text='<% #Bind("cantPortico") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Descuento">
                <ItemTemplate>
                    <asp:Label ID="Label123" runat="server" Text='<% #Bind("descuento") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDesc2" runat="server" Text='<% #Bind("descuento") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
               
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" DeleteCommand="DELETE FROM [Peaje] WHERE [ruta] = @ruta" InsertCommand="INSERT INTO [Peaje] ([ruta], [precio], [cantPortico], [descuento]) VALUES (@ruta, @precio, @cantPortico, @descuento)" SelectCommand="SELECT * FROM [Peaje]" UpdateCommand="UPDATE [Peaje] SET [precio] = @precio, [cantPortico] = @cantPortico, [descuento] = @descuento WHERE [ruta] = @ruta">
            <DeleteParameters>
                <asp:Parameter Name="ruta" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ruta" Type="String" />
                <asp:Parameter Name="precio" Type="Decimal" />
                <asp:Parameter Name="cantPortico" Type="Int32" />
                <asp:Parameter Name="descuento" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="precio" Type="Decimal" />
                <asp:Parameter Name="cantPortico" Type="Int32" />
                <asp:Parameter Name="descuento" Type="Double" />
                <asp:Parameter Name="ruta" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        <asp:Button ID="btnDescuento" runat="server" Height="32px" OnClick="btnDescuento_Click" Text="Cambiar todos los descuentos" />
        <asp:TextBox ID="txtDescuento" runat="server"  ></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnExportar" runat="server" CssClass="auto-style2" OnClick="btnExportar_Click" Text="Exportar" />
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
