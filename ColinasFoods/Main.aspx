<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

<asp:Content ID = "BodyContent" ContentPlaceHolderID="MainContent" runat ="server">
    
    <div id ="Maindiv">
        <asp:Panel runat="server" ID="WelcomeDiv" CssClass="subtitle" Font-Size="20px" Width="500px" HorizontalAlign="Left">
            <h1 style="margin-top:-30px;">Welcome Back, <%= ColinasFoods.Essentials.UserName != null && ColinasFoods.Essentials.UserName.Length > 0 ? (Char.ToUpper(ColinasFoods.Essentials.UserName[0]) + ColinasFoods.Essentials.UserName.Substring(1)) : "" %></h1>
        </asp:Panel>
        <br />
        <table style ="margin-left:10px; margin-right:auto; margin-top: -40px;">
            <tr>
                <td align ="center">
                    <asp:Label align ="center" runat ="server" ID ="LblWelcome" CssClass="subtitle" Text ="About Us"/>

                        <h2 style ="color: black;font-size:19px; width:600px;">As a Texas-based company founded in 2015, we pride ourselves as a family-owned and operated
                            business committed to our customers' success. We are dedicated to supplying high-quality protein, produce, groceries, dairy products 
                            and dry goods for restaurants and other foodservice clients, as well as residential. We understand that the food industry demands 
                            a reliable and consistent supply chain. By striving to become a partner to our customers, we aim to foster loyalty, satisfaction, 
                            and mutual growth.  With our focus on customization, quality, and reliability, we are confident in our ability to meet the needs of
                            our customers and help them achieve their goals.</h2>
                    <div id="recentSales">
                        <table>
                            <tr>
                                <td align="center">
                                    <asp:Label align="center" runat="server" ID="RecentSales" CssClass="tablelabel" Text="Recent Sales Orders" />
                                </td>
                            </tr>
                            <tr>
                                <td width="100%" valign="top" align="center">
                                    <asp:Panel ID="RecentPanel" runat="server" ScrollBars="Auto" style="width:auto;height:600px;overflow:auto;" >

                                    <asp:GridView ID="ItemsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black" OnSelectedIndexChanged="ItemsGrid_SelectedIndexChanged"  ShowHeaderWhenEmpty="true" EmptyDataText="You have no previous Sales Orders" runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" DataKeyNames="SalesOrderID">
                            
                                        <Columns>
                                     
                                            <asp:BoundField DataField="SalesOrderNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Order Number" SortExpression="SalesOrderNo" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="ReleaseDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Date Submitted"  SortExpression="ReleaseDate" ReadOnly="true" InsertVisible="false" />
                                     
                                            <asp:BoundField DataField="RequiredDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Required Date"  SortExpression="RequiredDate" ReadOnly="true" InsertVisible="false" />
                                           
                                            <asp:BoundField DataField="Total" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Total $"  SortExpression="Total" ReadOnly="true" InsertVisible="false" />

                                
                                        </Columns>
                  
                                    </asp:GridView>
                       
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Sales_OrderHistory"  />
                                    
                                </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </div>
                  

                     

                </td>
               

            </tr>
        </table>
         
    </div>
    <!--<div style="margin-left:200px; margin-bottom:auto; margin-top:-200px;">
                  <asp:Button ID="BtnAddNewSO" Width="200px" Text="New Sales Order" runat="server" CssClass="botonForm" OnClick="BtnAddNewSO_Click"/>
              </div>
    -->
    <div style ="margin-left:1200px; margin-bottom:auto; margin-top:-850px">
     

         <asp:Label font-size= "20px" ForeColor="White" BackColor ="#b00505" BorderColor="black" BorderWidth="2px" ID="Label1" runat="server"/></a>
         <asp:Button  Width="200px" Text="My Balance" runat="server" CssClass="botonForm" OnClick="BtnBalance_Click" />
                   
  
        <div style =" margin-bottom:30px; margin-top:10px">
        
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