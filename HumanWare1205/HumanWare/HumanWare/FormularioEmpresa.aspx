<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioEmpresa.aspx.cs" Inherits="HumanWare.HumanWare.FormularioEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ValidationSummary ID="vsEmpresa" runat="server" />

    <br/>
    <table style="width:63%" border="0">
    <tr>
            <th colspan="2"> Datos Empresa </th>
        <%--<asp:Label Text="Datos Empresa" runat="server" />--%>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr>
    <td><asp:Label Text="Nombre:" runat="server" /></td>
        <td> <asp:TextBox ID="txtNombreEmp" runat="server"/>
            <asp:RequiredFieldValidator ID="rfvNombre" ControlToValidate="txtNombreEmp" Text="Por favor ingrese Nombre de la Empresa" ForeColor="Red"
                    runat="server"></asp:RequiredFieldValidator></td>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
    <td><asp:Label Text="Teléfono:" runat="server" /></td>
        <td> <asp:TextBox ID="txtTelEmpresa" runat="server" TextMode="Number"/>
            <asp:RequiredFieldValidator ID="rfvTelefono" ControlToValidate="txtTelEmpresa" Text="Por favor ingrese Telefono de la Empresa" ForeColor="Red"
                    runat="server"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
        <th colspan="2"> Datos Oferta </th>
    <%--<td><asp:Label Text="Datos Oferta" runat="server" /></td>--%>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
    <td><asp:Label Text="Nombre del puesto: " runat="server" /></td>
        <td> <asp:TextBox ID="txtNombrePuesto" runat="server"/>
            <asp:RequiredFieldValidator ID="rfvNombrePuesto" ControlToValidate="txtNombrePuesto" Text="Por favor ingrese el nombre del Puesto" ForeColor="Red"
                    runat="server"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
    <td><asp:Label Text="Descripción del puesto:" runat="server" /> </td>
        <td><asp:TextBox ID="txtDescPuesto" runat="server" TextMode="MultiLine" Height="77px" Width="586px"/>
            <asp:RequiredFieldValidator ID="rfvDescripcPuesto" ControlToValidate="txtDescPuesto" Text="Por favor ingrese la Descripción del Puesto" ForeColor="Red"
                    runat="server" ></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
    <td><asp:Label Text="Rango salarial:" runat="server" /></td>
        <td> <asp:TextBox  ID="txtRangoSalario1" runat="server" TextMode="Number" ></asp:TextBox> -- <asp:TextBox  ID="txtRangoSalario2" runat="server" TextMode="Number" ></asp:TextBox> 
        <asp:RequiredFieldValidator ID="salarioMinValid" ControlToValidate="txtRangoSalario1" Text="*" ForeColor="Red" 
                    runat="server" > </asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="salarioMaxValid" ControlToValidate="txtRangoSalario2" Text="*" ForeColor="Red" 
                    runat="server" > </asp:RequiredFieldValidator>
        </td>    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
    <td><asp:Label Text="Jornada:" runat="server" /></td>
        <td> <asp:DropDownList ID="ddlJornadaEmp" runat="server" ToolTip="Seleccione un item">
        <%--<asp:ListItem>Seleccione un item</asp:ListItem>
        <asp:ListItem>Completa</asp:ListItem>
        <asp:ListItem>Parcial</asp:ListItem>--%>
    </asp:DropDownList>
           <%-- <asp:RequiredFieldValidator ID="rfvJornadaEmp" ControlToValidate="ddlJornadaEmp" Text="*" ForeColor="Red"
                    runat="server" ErrorMessage="No puedes dejar este campo en blanco. "></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
       <tr><td>&nbsp; </td></tr>
    <tr >
        <th colspan="2"> Requisitos del puesto </th>
    <%--<td><asp:Label Text="Requisitos del puesto:" runat="server" /></td>--%>
    </tr>
        <tr><td>&nbsp; </td></tr>
    <tr >
    <td><asp:Label Text="Titulación/es requerida/s:" runat="server" /></td>
        <td><asp:TextBox ID="txtTitulacion" runat="server" TextMode="MultiLine" Height="77px" Width="172px"/>
            <asp:RequiredFieldValidator ID="rfvTitulacion" ControlToValidate="txtTitulacion" Text="Por favor ingrese la titulación requerida" ForeColor="Red"
                    runat="server"></asp:RequiredFieldValidator>
        </td>
    </tr>
    </table>
            <br />
    <table>
        <tr> <td><asp:Label Text="Lea con mucha atención cada uno de los enunciados y seleccione el número que mejor dercriba tu habilidad."
        runat="server" /></td>
    </tr>
            <tr>
    <td><asp:Label Text="Donde 5 es Muy alto,4 Alto,3 Medio,2 Bajo y 1 Muy bajo."
        runat="server" /></tr> 
        </table>
 
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
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton1" runat="server" GroupName="cap1"/></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton2" runat="server" GroupName="cap1"/></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton3" runat="server" GroupName="cap1"/></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton4" runat="server" GroupName="cap1"/></td>
            <td align="center" style="height: 46px"> <asp:RadioButton ID="RadioButton5" runat="server" GroupName="cap1"/></td>
        </tr>
        <tr>
             <td align="center" style="width: 52px; height: 26px;"> 2</td>
            <td align="center" style="width: 347px; height: 26px;"> Capacidad para tomar decisiones y resolver problemas</td>
            <td align="center"> <asp:RadioButton ID="RadioButton6" runat="server" GroupName="cap2"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton7" runat="server" GroupName="cap2"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton8" runat="server" GroupName="cap2"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton9" runat="server" GroupName="cap2"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton10" runat="server" GroupName="cap2"/></td>
        </tr>
       <tr>
             <td align="center" style="width: 52px; height: 46px;"> 3</td>
            <td align="center" style="width: 347px; height: 46px;"> Nivel de ingles </td>
            <td align="center"> <asp:RadioButton ID="RadioButton11" runat="server" GroupName="cap3"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton12" runat="server" GroupName="cap3"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton13" runat="server" GroupName="cap3"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton14" runat="server" GroupName="cap3"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton15" runat="server" GroupName="cap3"/></td>
        </tr>
         <tr>
             <td align="center" style="width: 52px; height: 46px;"> 4</td>
            <td align="center" style="width: 347px; height: 46px;"> Capacidad de comunicarse verbalmente</td>
            <td align="center"> <asp:RadioButton ID="RadioButton16" runat="server" GroupName="cap4"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton17" runat="server" GroupName="cap4"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton18" runat="server" GroupName="cap4"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton19" runat="server" GroupName="cap4"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton20" runat="server" GroupName="cap4"/></td>
        </tr>
        <tr>
             <td align="center" style="width: 52px; height: 46px;"> 5</td>
            <td align="center" style="width: 347px; height: 46px;"> Capacidad para generar y/o editar informes escritos</td>
            <td align="center"> <asp:RadioButton ID="RadioButton21" runat="server" GroupName="cap5"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton22" runat="server" GroupName="cap5"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton23" runat="server" GroupName="cap5"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton24" runat="server" GroupName="cap5"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton25" runat="server" GroupName="cap5"/></td>
        </tr>
         <tr>
             <td align="center" style="width: 52px; height: 46px;"> 6</td>
            <td align="center" style="width: 347px; height: 46px;">Puntualidad</td>
            <td align="center"> <asp:RadioButton ID="RadioButton26" runat="server" GroupName="cap6"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton27" runat="server" GroupName="cap6"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton28" runat="server" GroupName="cap6"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton29" runat="server" GroupName="cap6"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton30" runat="server" GroupName="cap6"/></td>
        </tr>
            <tr>
             <td align="center" style="width: 52px; height: 46px;"> 7</td>
            <td align="center" style="width: 347px; height: 46px;">Capacidad para obtener y procesar información</td>
            <td align="center"> <asp:RadioButton ID="RadioButton31" runat="server" GroupName="cap7"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton32" runat="server" GroupName="cap7"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton33" runat="server" GroupName="cap7"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton34" runat="server" GroupName="cap7"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton35" runat="server" GroupName="cap7"/></td>
        </tr>
        <tr>
             <td align="center" style="width: 52px; height: 46px;"> 8</td>
            <td align="center" style="width: 347px; height: 46px;">Capacidad para analizar datos cuantitativos y cualitativos</td>
            <td align="center"> <asp:RadioButton ID="RadioButton36" runat="server" GroupName="cap8"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton37" runat="server" GroupName="cap8"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton38" runat="server" GroupName="cap8"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton39" runat="server" GroupName="cap8"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton40" runat="server" GroupName="cap8"/></td>
        </tr>
         <tr>
             <td align="center" style="width: 52px; height: 46px;"> 9</td>
            <td align="center" style="width: 347px; height: 46px;">Dominio de paquetería de software</td>
            <td align="center"> <asp:RadioButton ID="RadioButton41" runat="server" GroupName="cap9"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton42" runat="server" GroupName="cap9"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton43" runat="server" GroupName="cap9"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton44" runat="server" GroupName="cap9"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton45" runat="server" GroupName="cap9"/></td>
        </tr>
       <tr>
             <td align="center" style="width: 52px; height: 46px;"> 10</td>
            <td align="center" style="width: 347px; height: 46px;">Habilidad de vender e influir en los demas</td>
            <td align="center"> <asp:RadioButton ID="RadioButton46" runat="server" GroupName="cap10"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton47" runat="server" GroupName="cap10"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton48" runat="server" GroupName="cap10"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton49" runat="server" GroupName="cap10"/></td>
            <td align="center"> <asp:RadioButton ID="RadioButton50" runat="server" GroupName="cap10"/></td>
        </tr>
          </table>
            <br/>
    <asp:Button ID="btnPublicar" runat="server" Text="Publicar Oferta" OnClick="OnClickPublicar" />
    <asp:Label runat="server" ID="lblResultado" ForeColor="Blue" Font-Bold="true"></asp:Label>
    
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
