<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Michael.aspx.cs" Inherits="Pruebas_Web.Michael" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:label ID ="label1"  runat="server">User Name</asp:label>
            <br />
            <asp:TextBox ID="text"  runat="server"></asp:TextBox>
            <br />
            <asp:Button ID ="btn1"  runat="server" OnClick="OneClick_Submite" />

            <asp:Label ID ="label2" Text ="" runat="server"></asp:Label>
            <br />

             <asp:Calendar id="calendar1" runat="server" OnSelectionChanged="Calender1_seleccionado">

           <OtherMonthDayStyle ForeColor="LightGray">
           </OtherMonthDayStyle>

           <TitleStyle BackColor="Blue"
                       ForeColor="White">
           </TitleStyle>

           <DayStyle BackColor="gray">
           </DayStyle>

           <SelectedDayStyle BackColor="LightGray"
                             Font-Bold="True">
           </SelectedDayStyle>


      </asp:Calendar>
            

            <asp:Label ID="data_text" runat="server"></asp:Label>
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Button Onclick="desplegable" runat="server" Text="Conect"></asp:Button>
            <asp:DropDownList ID="cumples" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
