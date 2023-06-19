<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

<<<<<<< HEAD
<asp:Content ID = "BodyContent" ContentPlaceHolderID="MainContent" runat ="server">
    
    <div id ="Maindiv">
        <table style ="margin-left:auto; margin-right:auto; margin-top: -40px;">
            <tr>
                <td align ="center">
                    <asp:Label align ="center" runat ="server" ID ="LblWelcome" CssClass="subtitle" Text ="About Us"/>
                        <h2 style ="color: black;font-size:20px;"> We are a company that works with 100+ restaurants</h2>
                     <asp:Button ID="BtnAddNewSO" Width="200px" Text="New Sales Order" runat="server" CssClass="botonForm" OnClick="BtnAddNewSO_Click" />
                   

                     

                </td>
               

            </tr>
        </table>
    </div>
    <div style ="margin-left:1200px; margin-bottom:400px; margin-top:-75px">
     <td height="20" ><a href="Balance.aspx">
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label1" runat="server" Text="My Balance" /></a>
     </td>
        <div style =" margin-bottom:300px; margin-top:10px">
        <td height="20" ><a href="InvoiceSearch.aspx">
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label2" runat="server" Text="My Invoices" /></a>
     </td>
       
       
        <div style =" margin-bottom:300px; margin-top:10px">
            <td height="20" ><a href="SalesOrderHistory.aspx">
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label4" runat="server" Text="My Order History" /></a>
            </td>
            
        <div style=" margin-bottom:300px; margin-top:10px">
             <td height="20" ><a href="PaymentSearch.aspx">
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label5" runat="server" Text="My Payments" /></a>
     </td>
            </div>

        </div>
    </div>
        </div>
</asp:Content>