<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanWare._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server"> HUMANWARE </asp:Label>
<br />
<asp:Label runat="server"> Ofertas </asp:Label>
<br />
<asp:Button runat="server" OnClick="OnClickOferta" ID="o001" Text="Se busca Ingeniero"/>
</asp:Content>
