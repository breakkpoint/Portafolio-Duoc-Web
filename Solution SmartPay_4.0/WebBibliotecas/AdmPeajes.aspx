<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="AdmPeajes.aspx.cs" Inherits="WebBibliotecas.AdmPeajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbTitulo" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GBPeaje" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="ruta" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnRowDeleting="RowDeltingEvent" OnRowUpdating="GBPeaje_RowUpdating">
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
</p>
    <p>
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
</p>
    <p>
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbAgregar" runat="server" Text="AGREGAR RUTA"></asp:Label>
</p>
    <p>
        &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtRuta" runat="server" placeholder="Ruta"  Width="148px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtprecio" runat="server" placeholder="Precio"  Width="152px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcantportico" runat="server" placeholder="Cantidad porticos" Width="153px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescuento" runat="server" placeholder="Descuento"  Width="153px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR " OnClick="btnAgregar_Click" />
</p>
    <p>
        &nbsp;</p>
<p>
</p>
<p>
</p>
</asp:Content>
