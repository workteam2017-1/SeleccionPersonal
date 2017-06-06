<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioEvaluador.aspx.cs" Inherits="HumanWare.HumanWare.InicioEvaluador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <br/>
   <table border="1" width="70%" cellspacing="3" bgcolor="white" bordercolor="black">
       <tr><td></td></tr>
       <tr>
            <td rowspan="1" style="width: 255px" align="center"> &nbsp;<b>Empresa</b> </td>
            <td rowspan="1" align="center"> &nbsp;<b>Oferta</b></td>
        </tr>
        <asp:PlaceHolder ID="ButtonsPlaceHolder" runat="server"></asp:PlaceHolder>
    </table>

    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
