﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginEvaluador.aspx.cs" Inherits="HumanWare.HumanWare.HumanWareLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
   <table  style="width:63%" border="0" align="center" bgcolor="red"> 
       <tr>
    <th  colspan="2"> Evaluador</th>
           </tr>
    <tr>
    <td><asp:Label runat="server"> Usuario </asp:Label> </td>
    <td><asp:TextBox runat="server" > </asp:TextBox></td> </tr>
    <tr>
       <br />
    <td><asp:Label runat="server"> Contraseña</asp:Label> </td>
        <td><asp:TextBox runat="server" TextMode="Password"> </asp:TextBox> </td>
    </tr>
          <tr>
           
    <td><br /><asp:Button runat="server" Text="Ingresar" OnClick="OnClickLoguearse" bgcolor="blue"/> </td>
           </tr>
       </table>

</asp:Content>