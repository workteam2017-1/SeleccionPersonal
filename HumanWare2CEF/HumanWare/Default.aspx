<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanWare._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br/>
    <table  style="width:63%" border="0" align="left" bgcolor="red"> 
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
    </table>
    <table border="1" width="70%" cellspacing="3" bgcolor="white" bordercolor="black">
       <tr><td></td></tr>
       <tr>
            <td rowspan="1" style="width: 255px" align="center"> &nbsp;<b>Empresa</b> </td>
            <td rowspan="1" align="center"> &nbsp;<b>Oferta</b></td>
        </tr>
        <asp:PlaceHolder ID="ButtonsPlaceHolder" runat="server"></asp:PlaceHolder>
    </table>
</asp:Content>
