<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebBibliotecas.Index" %>

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
    <form id="form1" runat="server">
    
        <!-- Modal de Registro-->
        
        <!-- Navigation -->
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
                   
                  <%--  <li class="dropdown">
                        <a href="Registro.aspx" class="dropdown-toggle">Registrar</a>
                    </li>

                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle">Contacto</a>
                    </li>--%>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>
        <hr/>

            <div class="container">
                <!-- Heading Row -->
                <div class="row">
                    <div class="col-md-8">
                        <div class="wrapper">
                            <img class="img-responsive img-rounded" 
                                 src="img/img1.jpg" alt=""/>    
                        </div>
                    </div>
                <!-- REgistro-->
                <div class="col-md-4">
                    <div class="wrapper">
                        
                        <form class="form-signin" method="POST" action="loginServlet">       
                            <h2 class="form-signin-heading">Iniciar Sesión</h2>
                            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" name="usuario" placeholder="Rut"  autofocus="" ></asp:TextBox>
                            <br/>
                            <asp:TextBox ID="txtPassword" runat="server" class="form-control" name="password" placeholder="Password"  autofocus="" Font-Strikeout="False" TextMode="Password" ></asp:TextBox>  
                            <br/>
                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-lg btn-primary btn-block" OnClick="btnIngresar_Click"/>
                                                    
                            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" class="btn btn-lg btn-primary btn-block" OnClick="btnRegistrar_Click"/>
                            

                        </form>
                    </div>
                </div>
              <div>
                    </form>
               </div> <!-- /.account-body -->
          </div> <!-- /.account-wrapper -->
       

        <br/>
               
               
        <footer>
            <div class="row">
                <div class="col-lg-12">
                    <p</p>
                </div>
            </div>
        </footer>

  
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>
</body>
        


</html>
