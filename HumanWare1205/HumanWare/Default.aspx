<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanWare._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br/>
    <table  style="width:63%" border="0" align="center" bgcolor="red"> 
   <tr>
    <td>
<asp:Label runat="server"> <b>HUMAN-WARE</b> </asp:Label></td> </tr>
<tr><td>&nbsp; </td></tr>
<tr>
    <td>
<asp:Label ID="lblOfertas" runat="server"> Ofertas </asp:Label></td> </tr>
        <tr><td>&nbsp; </td></tr>
<tr>
    <td>
<asp:Button ID="btnBusca" runat="server" OnClick="OnClickOferta" Text="Se busca oferta"/></td> </tr>
        </table>
</asp:Content>
