<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vehiculo.aspx.cs" Inherits="WebBibliotecas.Vehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        REGISTRAR AUTO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpatente" runat="server" Width="198px" placeholder="Patente"></asp:TextBox>
&nbsp;&nbsp;

    </p>
    

    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtmodelo" runat="server" Width="197px" placeholder="Modelo"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcolor" runat="server" Width="197px" placeholder="Color"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtmarca" runat="server" Width="195px" placeholder="Marca"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR" OnClick="btnRegistrar_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GBauto" runat="server" AutoGenerateColumns="False" DataKeyNames="patente" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GBauto_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="365px" AllowPaging="True" OnRowUpdating="GBauto_RowUpdating">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="patente" HeaderText="patente" ReadOnly="True" SortExpression="patente" />
               
                <asp:TemplateField HeaderText="Marca">
                <ItemTemplate>
                    <asp:Label ID="Label134" runat="server" Text='<% #Bind("marca") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtMarca2" runat="server" Text='<% #Bind("marca") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Modelo">
                <ItemTemplate>
                    <asp:Label ID="Label231" runat="server" Text='<% #Bind("modelo") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtModelo2" runat="server" Text='<% #Bind("modelo") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Color">
                <ItemTemplate>
                    <asp:Label ID="Label12" runat="server" Text='<% #Bind("color") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtColor2" runat="server" Text='<% #Bind("color") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
                
                
                <%--<asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />--%>
                <%--<asp:BoundField DataField="modelo" HeaderText="modelo" SortExpression="modelo" />--%>
                <%--<asp:BoundField DataField="color" HeaderText="color" SortExpression="color" />--%>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SmartPayConnectionString %>" DeleteCommand="DELETE FROM [Vehiculo] WHERE [patente] = @patente" InsertCommand="INSERT INTO [Vehiculo] ([patente], [marca], [modelo], [color]) VALUES (@patente, @marca, @modelo, @color)" SelectCommand="SELECT [patente], [marca], [modelo], [color] FROM [Vehiculo] WHERE ([rut] = @rut)" UpdateCommand="UPDATE [Vehiculo] SET [marca] = @marca, [modelo] = @modelo, [color] = @color WHERE [patente] = @patente">
            <DeleteParameters>
                <asp:Parameter Name="patente" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="patente" Type="String" />
                <asp:Parameter Name="marca" Type="String" />
                <asp:Parameter Name="modelo" Type="String" />
                <asp:Parameter Name="color" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:SessionParameter Name="rut" SessionField="CLAVE" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="marca" Type="String" />
                <asp:Parameter Name="modelo" Type="String" />
                <asp:Parameter Name="color" Type="String" />
                <asp:Parameter Name="patente" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
