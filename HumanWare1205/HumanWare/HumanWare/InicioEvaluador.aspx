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
       <tr>
            <td align="center"> ETB</td>
            <td align="center" style="height: 46px"> <asp:Button ID="Button1" runat="server" Text="Se busca Ingeniero de telecomunicaciones" OnClick="OnClickOferta1"/></td>
        </tr>
       <tr>
            <td align="center"> ETB</td>
            <td align="center" style="height: 46px"> <asp:Button ID="Button2" runat="server" Text="Se busca celador nocturno" OnClick="OnClickOferta2"/></td>
        </tr>
    </table>

    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
