<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

<asp:Content ID = "BodyContent" ContentPlaceHolderID="MainContent" runat ="server">
    
    <div id ="Maindiv">
        <asp:Panel runat="server" ID="WelcomeDiv">
            <h1>Welcome Back <%= ColinasFoods.Essentials.UserName %></h1>
        </asp:Panel>
        <table style ="margin-left:auto; margin-right:auto; margin-top: -40px;">
            <tr>
                <td align ="center">
                    <asp:Label align ="center" runat ="server" ID ="LblWelcome" CssClass="subtitle" Text ="About Us"/>
                        <h2 style ="color: black;font-size:19px; width:600px;">As a Texas-based company founded in 2015, we pride ourselves as a family-owned and operated
                            business committed to our customers' success. We are dedicated to supplying high-quality protein, produce, groceries, dairy products 
                            and dry goods for restaurants and other foodservice clients, as well as residential. We understand that the food industry demands 
                            a reliable and consistent supply chain. By striving to become a partner to our customers, we aim to foster loyalty, satisfaction, 
                            and mutual growth.  With our focus on customization, quality, and reliability, we are confident in our ability to meet the needs of
                            our customers and help them achieve their goals.</h2>
                     <asp:Button ID="BtnAddNewSO" Width="200px" Text="New Sales Order" runat="server" CssClass="botonForm" OnClick="BtnAddNewSO_Click" />
                   

                     

                </td>
               

            </tr>
        </table>
    </div>
    <div style ="margin-left:1200px; margin-bottom:400px; margin-top:-75px">
    
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label1" runat="server"/></a>
         <asp:Button  Width="200px" Text="My Balance" runat="server" CssClass="botonForm" OnClick="BtnBalance_Click" />
                   
  
        <div style =" margin-bottom:300px; margin-top:10px">
        
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label2" runat="server"/></a>
             <asp:Button  Width="200px" Text="My Invoices" runat="server" CssClass="botonForm" OnClick="BtnInvoice_Click" />
   
       
       
        <div style =" margin-bottom:300px; margin-top:10px">
           
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label4" runat="server" /></a>
            <asp:Button  Width="200px" Text="My Order History" runat="server" CssClass="botonForm" OnClick="BtnOrderHistory_Click" />
            
        <div style=" margin-bottom:300px; margin-top:10px">
             
         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label5" runat="server" /></a>
             <asp:Button  Width="200px" Text="My Payments" runat="server" CssClass="botonForm" OnClick="BtnPayment_Click" />
     
            </div>

        </div>
    </div>
        </div>
</asp:Content>