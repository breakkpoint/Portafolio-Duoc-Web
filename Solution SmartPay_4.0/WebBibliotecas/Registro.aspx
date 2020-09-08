<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebBibliotecas.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Modern Business - Start Bootstrap Template</title>

    <script type="text/javascript">
     
        function alerta(mensaje) {
            alert(mensaje);
        }
     
    </script>


    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>

    <!-- Custom CSS -->
    <link href="css/modern-business.css" rel="stylesheet"/>

    <!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    
     <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" >Smart Pay 2.0</a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                   
                    <li class="dropdown">
                        <a href="Index.aspx" class="dropdown-toggle">Login</a>
                    </li>


                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>
        <hr/>


        <div class="col-md-4">
                    <div class="wrapper">
                        
                        <form class="form-signin" runat="server">       
                            <h2 class="form-signin-heading">Registro De Usuario</h2>
                            <asp:TextBox ID="txtRut" runat="server" class="form-control" name="rut" placeholder="Rut" required="" autofocus="" ></asp:TextBox>
                            <br/>
                            <asp:TextBox ID="txtNombre" runat="server" class="form-control" name="nombre" placeholder="Nombre" required="" autofocus="" ></asp:TextBox>  
                            <br/>
                            <asp:TextBox ID="txtfono" runat="server" class="form-control" name="fono" placeholder="Telefono" required="" autofocus="" ></asp:TextBox>  
                            <br/>
                            <asp:TextBox ID="txtdireccion" runat="server" class="form-control" name="direccion" placeholder="Direccion" required="" autofocus="" ></asp:TextBox>  
                            <br/>
                            <asp:TextBox ID="txtPass" runat="server" class="form-control" name="pasword" placeholder="Password" required="" autofocus="" ></asp:TextBox>  
                            <br/>
                            <asp:Button ID="btnIngresar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" class="btn btn-lg btn-primary btn-block"/>                        
                            
                            
                        </form>
                    </div>
            
        </div>
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
