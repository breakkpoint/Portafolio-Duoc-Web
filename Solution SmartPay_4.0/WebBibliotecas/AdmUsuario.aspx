<%@ Page Title="" Language="C#" MasterPageFile="~/MaestraAdmin.Master" AutoEventWireup="true" CodeBehind="AdmUsuario.aspx.cs" Inherits="WebBibliotecas.AdmUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbTitulo" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp; &nbsp;
        <asp:GridView ID="GbUser" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="rut" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Width="590px" OnRowDeleting="RowDeletingEvent" OnSelectedIndexChanging="GbUser_SelectedIndexChanging" AllowPaging="True" OnRowUpdating="GbUser_RowUpdating">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="rut" HeaderText="rut" ReadOnly="True" SortExpression="rut" />
                
                <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label ID="Label10" runat="server" Text='<% #Bind("nombre") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtnombre2" runat="server" Text='<% #Bind("nombre") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

                <asp:TemplateField HeaderText="Direccion">
                <ItemTemplate>
                    <asp:Label ID="Label12" runat="server" Text='<% #Bind("direccion") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdireccion2" runat="server" Text='<% #Bind("direccion") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

                <asp:TemplateField HeaderText="Telefono">
                <ItemTemplate>
                    <asp:Label ID="Label13" runat="server" Text='<% #Bind("telefono") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtTelefono2" runat="server" Text='<% #Bind("telefono") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
               
                <asp:TemplateField HeaderText="Contraseña">
                <ItemTemplate>
                    <asp:Label ID="Label14" runat="server" Text='<% #Bind("contraseña") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcontra" runat="server" Text='<% #Bind("contraseña") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

                <asp:TemplateField HeaderText="Saldo">
                <ItemTemplate>
                    <asp:Label ID="Label15" runat="server" Text='<% #Bind("saldo") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtsaldo2" runat="server" Text='<% #Bind("saldo") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

                <asp:TemplateField HeaderText="FechaRegistro">
                <ItemTemplate>
                    <asp:Label ID="Label16" runat="server" Text='<% #Bind("FechaRegistro") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtFecha2" runat="server" Text='<% #Bind("FechaRegistro") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

                <asp:TemplateField HeaderText="Activo">
                <ItemTemplate>
                    <asp:Label ID="Label17" runat="server" Text='<% #Bind("activo") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtactivo2" runat="server" Text='<% #Bind("activo") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

                <%--<asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />--%>
                <%--<asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />--%>
                <%--<asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />--%>
                <%--<asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />--%>
                <%--<asp:BoundField DataField="saldo" HeaderText="saldo" SortExpression="saldo" />--%>
                <%--<asp:BoundField DataField="FechaRegistro" HeaderText="FechaRegistro" SortExpression="FechaRegistro" />--%>
                <%--<asp:BoundField DataField="activo" HeaderText="activo" SortExpression="activo" />--%>
               
                
                
                
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" Text="Exportar" />
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" DeleteCommand="DELETE FROM [Usuario] WHERE [rut] = @rut" InsertCommand="INSERT INTO [Usuario] ([rut], [nombre], [direccion], [telefono], [contraseña], [saldo], [FechaRegistro], [activo]) VALUES (@rut, @nombre, @direccion, @telefono, @contraseña, @saldo, @FechaRegistro, @activo)" SelectCommand="SELECT * FROM [Usuario]" UpdateCommand="UPDATE [Usuario] SET [nombre] = @nombre, [direccion] = @direccion, [telefono] = @telefono, [contraseña] = @contraseña, [saldo] = @saldo, [FechaRegistro] = @FechaRegistro, [activo] = @activo WHERE [rut] = @rut">
            <DeleteParameters>
                <asp:Parameter Name="rut" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="rut" Type="String" />
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="direccion" Type="String" />
                <asp:Parameter Name="telefono" Type="String" />
                <asp:Parameter Name="contraseña" Type="String" />
                <asp:Parameter Name="saldo" Type="Double" />
                <asp:Parameter DbType="Date" Name="FechaRegistro" />
                <asp:Parameter Name="activo" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="direccion" Type="String" />
                <asp:Parameter Name="telefono" Type="String" />
                <asp:Parameter Name="contraseña" Type="String" />
                <asp:Parameter Name="saldo" Type="Double" />
                <asp:Parameter DbType="Date" Name="FechaRegistro" />
                <asp:Parameter Name="activo" Type="String" />
                <asp:Parameter Name="rut" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Eliminar usuario" />
    <p>
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
