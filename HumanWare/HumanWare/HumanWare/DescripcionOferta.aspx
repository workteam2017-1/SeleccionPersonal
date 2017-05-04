<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescripcionOferta.aspx.cs" Inherits="HumanWare.HumanWare.DescripcionOferta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <br/>
   <br/>
    <table style="width:63%" border="0"> 
        <tr>
            <th colspan="2"> Descripción Oferta </th>
<%--        <asp:Label runat="server">Descripción Oferta</asp:Label> --%>
    </tr>
             <tr>
    <td style="width: 100px"><asp:Label Text="Nombre del puesto: " runat="server" /> </td> 
         <td><asp:TextBox runat="server" Enabled="false" Text="Ingeniero"/> </td>
    </tr>
         <tr>
    <td style="width: 100px"><asp:Label Text="Descripción del puesto:" runat="server" /> </td>
         <td> <br/><asp:TextBox runat="server" Enabled="false" TextMode="MultiLine" Height="77px" Width="586px"/> </td>
    </tr>
         <tr>
    <td style="width: 100px"><asp:Label Text="Rango salarial:" runat="server" /> </td>
         <td><asp:TextBox Enabled="false" runat="server" TextMode="Number"></asp:TextBox> -- <asp:TextBox Enabled="false" runat="server" TextMode="Number"></asp:TextBox> </td> 
    </tr>
         <tr>
    <td style="width: 100px"><asp:Label Text="Jornada:" runat="server" /> </td>
   <td> <asp:DropDownList Enabled="false" runat="server"  ToolTip="Seleccione un item"> 
     <asp:ListItem>Seleccione un item</asp:ListItem>
       <asp:ListItem>Completa</asp:ListItem>
        <asp:ListItem>Parcial</asp:ListItem>
    </asp:DropDownList> </td> </tr>
   <br/>
    <br/>
         <tr>
      <th colspan="2"> Requisitos del puesto: </th> </tr>
        <tr>
        <td style="width: 100px"> <asp:Label Text="Titulación/es requerida/s:" runat="server" /> </td> 
             <td><br><asp:TextBox runat="server" Enabled="false" TextMode="MultiLine" Height="77px" Width="172px"/> </td> </tr>
        </table>

        <tr> <td><asp:Label Text="Lea con mucha atención cada uno de los enunciados y seleccione el número que mejor dercriba tu habilidad."
        runat="server" /></td>
    </tr>
            <tr>
    <td>Donde 5 es Muy alto,4 Alto,3 Medio,2 Bajo y 1 Muy bajo.</td></tr> 
 
   <table border="1" width="70%" cellspacing="3" bgcolor="white" bordercolor="black">
        <tr>
            <td colspan="7" align="center" style="height: 26px"> <b>Habilidades que posee </b> </td>
        </tr>
        <tr>
            <td rowspan="2" style="width: 52px"> &nbsp;<b>Item</b> </td>
            <td rowspan="2" align="center"> &nbsp;<b>Enunciado</b></td>
            <td colspan="5" align="center"> &nbsp;<b> Valoración</b></td>
        </tr>
        <tr>
            <td align="center"> 1</td>
            <td align="center"> 2</td>
            <td align="center"> 3</td>
            <td align="center"> 4</td>
            <td align="center"> 5</td>
        </tr>
        <tr>
            <td align="center" style="width: 52px; height: 46px;"> 1</td>
            <td align="center" style="width: 347px; height: 46px;"> Capacidad para trabajar en una estructura de equipo</td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton1" runat="server" /></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton2" runat="server" /></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton3" runat="server" /></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton4" runat="server" /></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton5" runat="server" /></td>
        </tr>
        <tr>
             <td align="center" style="width: 52px; height: 26px;"> 2</td>
            <td align="center" style="width: 347px; height: 26px;"> Capacidad para tomar decisiones y resolver problemas</td>
            <td align="center"> <asp:RadioButton ID="RadioButton6" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton7" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton8" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton9" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton10" runat="server" /></td>

        </tr>
       <tr>
             <td align="center" style="width: 52px; height: 46px;"> 3</td>
            <td align="center" style="width: 347px; height: 46px;"> Nivel de ingles </td>
            <td align="center"> <asp:RadioButton ID="RadioButton11" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton12" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton13" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton14" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton15" runat="server" /></td>

        </tr>
         <tr>
             <td align="center" style="width: 52px; height: 46px;"> 4</td>
            <td align="center" style="width: 347px; height: 46px;"> Capacidad de comunicarse verbalmente</td>
            <td align="center"> <asp:RadioButton ID="RadioButton16" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton17" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton18" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton19" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton20" runat="server" /></td>

        </tr>
        <tr>
             <td align="center" style="width: 52px; height: 46px;"> 5</td>
            <td align="center" style="width: 347px; height: 46px;"> Capacidad para generar y/o editar informes escritos</td>
            <td align="center"> <asp:RadioButton ID="RadioButton21" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton22" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton23" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton24" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton25" runat="server" /></td>

        </tr>
         <tr>
             <td align="center" style="width: 52px; height: 46px;"> 6</td>
            <td align="center" style="width: 347px; height: 46px;">Puntualidad</td>
            <td align="center"> <asp:RadioButton ID="RadioButton26" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton27" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton28" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton29" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton30" runat="server" /></td>

        </tr>
            <tr>
             <td align="center" style="width: 52px; height: 46px;"> 7</td>
            <td align="center" style="width: 347px; height: 46px;">Capacidad para obtener y procesar información</td>
            <td align="center"> <asp:RadioButton ID="RadioButton31" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton32" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton33" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton34" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton35" runat="server" /></td>

        </tr>
        <tr>
             <td align="center" style="width: 52px; height: 46px;"> 8</td>
            <td align="center" style="width: 347px; height: 46px;">Capacidad para analizar datos cuantitativos y cualitativos</td>
            <td align="center"> <asp:RadioButton ID="RadioButton36" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton37" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton38" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton39" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton40" runat="server" /></td>

        </tr>
         <tr>
             <td align="center" style="width: 52px; height: 46px;"> 9</td>
            <td align="center" style="width: 347px; height: 46px;">Dominio de paquetería de software</td>
            <td align="center"> <asp:RadioButton ID="RadioButton41" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton42" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton43" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton44" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton45" runat="server" /></td>

        </tr>
       <tr>
             <td align="center" style="width: 52px; height: 46px;"> 10</td>
            <td align="center" style="width: 347px; height: 46px;">Habilidad de vender e influir en los demas</td>
            <td align="center"> <asp:RadioButton ID="RadioButton46" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton47" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton48" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton49" runat="server" /></td>
            <td align="center"> <asp:RadioButton ID="RadioButton50" runat="server" /></td>

        </tr>
          </table>

    <asp:Button runat="server" OnClick="OnClickAplicar" ID="o001" Text="Aplicar"/>
        

</asp:Content>
