﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginEvaluador.aspx.cs" Inherits="HumanWare.HumanWare.HumanWareLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ValidationSummary ID="vsLoginEval" runat="server" />
    <br />
   <table  style="width:63%" border="0" align="center" bgcolor="red"> 
       <tr>
    <th  colspan="2"> Evaluador</th>
           </tr>
       <tr><td>&nbsp; </td></tr>
    <tr>
    <td><asp:Label runat="server"> Usuario </asp:Label> </td>
    <td><asp:TextBox ID="txtUsuario" runat="server" > </asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUsuario" 
                    ControlToValidate="txtUsuario" Text="Por favor ingrese su usuario" ForeColor="Red"
                    runat="server"></asp:RequiredFieldValidator>
    </td> </tr>
       <tr><td>&nbsp; </td></tr>
    <tr>
    <td><asp:Label runat="server"> Contraseña</asp:Label> </td>
        <td><asp:TextBox ID="txtClave" runat="server" TextMode="Password"> </asp:TextBox> 
            <asp:RequiredFieldValidator ID="rfvClave" 
                    ControlToValidate="txtClave" Text="Por favor ingrese su clave" ForeColor="Red"
                    runat="server"></asp:RequiredFieldValidator> </td>
    </tr>
       <tr><td>&nbsp; </td></tr>
          <tr>          
    <td> <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="OnClickLoguearse" bgcolor="blue"/> </td>
           </tr>

              <tr>     
    <td> <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label> </td>
           </tr>
       
       </table>

    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
