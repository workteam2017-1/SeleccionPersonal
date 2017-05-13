﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluadorOferta2.aspx.cs" Inherits="HumanWare.HumanWare.EvaluadorOferta2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

   <br/>
    <table style="width:63%" border="0"> 
        <tr>
            <th colspan="2"> Descripción Oferta </th>
<%--        <asp:Label runat="server">Descripción Oferta</asp:Label> --%>
    </tr>
        <tr><td>&nbsp; </td></tr>
             <tr>
    <td style="width: 100px"><asp:Label Text="Nombre del puesto: " runat="server" /> </td> 
         <td><asp:TextBox ID="txtNombrePuesto" runat="server" Enabled="false" Text="Celador nocturno"/> </td>
    </tr>
        <tr><td>&nbsp; </td></tr>
         <tr>
    <td style="width: 100px"><asp:Label Text="Descripción del puesto:" runat="server" /> </td>
         <td> <br/><asp:TextBox ID="txtDescPuesto" runat="server" Enabled="false" TextMode="MultiLine" Text="Se solicita celador nocturno con 1 año de experiencia en el área
Persona responsable, comprometida y con disposición de laborar.
" Height="77px" Width="586px"/> </td>
    </tr>
         <tr><td>&nbsp;</td></tr>
         <tr>
    <td style="width: 100px"><asp:Label Text="Rango salarial:" runat="server" /> </td>
         <td><asp:TextBox ID="txtRangoSalarial1" Enabled="false" runat="server" TextMode="Number" Text="737717"></asp:TextBox> -- <asp:TextBox ID="txtRangoSalarial2" Enabled="false" runat="server" TextMode="Number" Text="850000"></asp:TextBox> </td> 
    </tr>
         <tr><td>&nbsp;</td></tr>
         <tr>
    <td style="width: 100px"><asp:Label Text="Jornada:" runat="server" /> </td>
   <td> <asp:DropDownList ID="ddlJornada" Enabled="false" runat="server"  ToolTip="Seleccione un item"> 
     <%--<asp:ListItem>Seleccione un item</asp:ListItem>
       <asp:ListItem>Completa</asp:ListItem>
        <asp:ListItem>Parcial</asp:ListItem>--%>
    </asp:DropDownList> </td> </tr>
<tr><td>&nbsp;</td></tr>
         <tr>
      <th colspan="2"> Requisitos del puesto: </th> </tr>
        <tr><td>&nbsp; </td></tr>
        <tr>
        <td style="width: 100px"> <asp:Label Text="Titulación/es requerida/s:" runat="server" /> </td> 
             <td><br><asp:TextBox ID="txtTitulacionReq" runat="server" Enabled="false" TextMode="MultiLine" Text="Educación mínima: Bachillerato / Educación Media. Años de experiencia: 1. Disponibilidad de viajar: No. Disponibilidad de cambio de residencia: No"
                  Height="77px" Width="554px"/> </td> </tr>
    </table>
<br/>
   <table border="1" width="70%" cellspacing="3" bgcolor="white" bordercolor="black">
        <tr>
            <td colspan="15" align="center" style="height: 26px"> <b>CANDIDATOS </b> </td>
        </tr>
        <tr>
            <td rowspan="2" style="width: 52px"> &nbsp;<b>Nombre del candidato</b> </td>
            <td rowspan="2" align="center"> &nbsp;<b>Titulación</b></td>
            <td rowspan="2" align="center"> &nbsp;<b>Rango salarial</b></td>
            <td rowspan="2" align="center"> &nbsp;<b>Jornada disponible</b></td>
            <td colspan="10" align="center"> &nbsp;<b> Habilidades</b></td>
            <td rowspan="2" align="center"> &nbsp;<b>Puntuación General</b></td>
        </tr>
        <tr>
            <td align="center"> Trabajo en equipo</td>
            <td align="center"> Toma de decisiones</td>
            <td align="center" style="width: 979px"> Inglés</td>
            <td align="center"> Comunicación</td>
            <td align="center"> Generar Informes</td>
            <td align="center"> Puntualidad</td>
            <td align="center"> Procesar Información</td>
            <td align="center"> Analizar datos</td>
            <td align="center"> Software</td>
            <td align="center"> Vender e Influenciar</td>
        </tr>
        <tr>
            <td align="center"> Pepito Perez</td>
            <td align="center"> Bachiller</td>
            <td align="center"> $670.000</td>
            <td align="center"> Completa</td>
            <td align="center"> 3</td>
            <td align="center"> 2</td>
            <td align="center"> 1</td>
            <td align="center"> 4</td>
            <td align="center"> 4</td>
            <td align="center"> 1</td>
            <td align="center"> 4</td>
            <td align="center"> 4</td>
            <td align="center"> 4</td>
            <td align="center"> 2</td>
            <td align="center"> C1</td>
        </tr>
        <tr>
            <td align="center"> Yanneth Rodriguez</td>
            <td align="center"> Técnica en seguridad</td>
            <td align="center"> $800.000</td>
            <td align="center"> Completa</td>
            <td align="center"> 3</td>
            <td align="center"> 4</td>
            <td align="center"> 2</td>
            <td align="center"> 3</td>
            <td align="center"> 4</td>
            <td align="center"> 1</td>
            <td align="center"> 4</td>
            <td align="center"> 4</td>
            <td align="center"> 5</td>
            <td align="center"> 4</td>
            <td align="center"> C3</td>
        </tr>
   </table>

</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
