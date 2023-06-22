<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

<asp:Content ID = "BodyContent" ContentPlaceHolderID="MainContent" runat ="server">
    
    <div id ="Maindiv" style="height:20rem; width:0rem;">
        <asp:Panel runat="server" ID="WelcomeDiv" CssClass="subtitle" Font-Size="20px" Width="500px" HorizontalAlign="Left">
            <h1 style="position:relative; left:35rem;top:-5rem;">Welcome Back, <%= ColinasFoods.Essentials.UserName != null && ColinasFoods.Essentials.UserName.Length > 0 ? (Char.ToUpper(ColinasFoods.Essentials.UserName[0]) + ColinasFoods.Essentials.UserName.Substring(1)) : "" %></h1>
        </asp:Panel>
        <br />
        <table style ="width:0rem;position:relative;right:-2rem; bottom:7rem; height:0rem" >
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
                                    <asp:Panel ID="RecentPanel" runat="server" ScrollBars="Auto">

                                    <asp:GridView ID="ItemsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black" OnSelectedIndexChanged="ItemsGrid_SelectedIndexChanged"  ShowHeaderWhenEmpty="true" EmptyDataText="You have no previous Sales Orders" runat="server" AutoGenerateColumns="False"  CssClass="GridMain"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" DataKeyNames="SalesOrderID" allowpaging=true PageSize=3>
                                        <PagerStyle CssClass="hidden" />
                                        <Columns>
                                     
                                            <asp:BoundField DataField="SalesOrderNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Order Number" SortExpression="SalesOrderNo" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="ReleaseDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Date Submitted"  SortExpression="ReleaseDate" ReadOnly="true" InsertVisible="false" />
                                     
                                            <asp:BoundField DataField="RequiredDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Required Date"  SortExpression="RequiredDate" ReadOnly="true" InsertVisible="false" />
                                           
                                            <asp:BoundField DataField="Total" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Total $"  SortExpression="Total" ReadOnly="true" InsertVisible="false" />

                                
                                        </Columns>
                  
                                    </asp:GridView>
                       
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Sales_OrderHistory" />
                                    <asp:Button ID="BtnAddNewSO" Width="200px" Text="New Sales Order" runat="server" CssClass="botonForm" OnClick="BtnAddNewSO_Click"/>
                                </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </div>

    <div id="MyBalanceDiv" style="position:relative;top:-20rem;left:60rem;width: 275px;">
        <asp:GridView ID="hiddenBalanceGrid" runat="server" CssClass="hidden"></asp:GridView>
        <h1>My Total Balance:</h1>
        <asp:Label ID="balanceLabel" runat="server" CssClass="botonForm"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_GetBalance" />
    </div>
    <div style="right:45rem; height:0rem; width:10rem;">
        <h1 CssClass="subtitle" style="left: 41.5rem; text-align: center; position:relative; display:flex; bottom:27rem;">Explore Our Page</h1>
      <div style="position:relative; left:41.5rem; bottom:27rem">
          
        <asp:Button  ID="Balance" Width="75px" Height="75px" Text="My Balance" Font-Size="Small" runat="server" CssClass="botonForm2" OnClick="BtnBalance_Click"  />





            <asp:Button Width="75px" Height="75px" Text="My Invoices" Font-Size="small" runat="server" CssClass="botonForm2" OnClick="BtnInvoice_Click" Style="position: relative; top: .5rem;" />




          </div>
        <div style="position: relative; left:47.5rem; bottom: 36.35rem;">


           <asp:Button Width="75px" Height="75px" Text="My Sales" Font-Size="small" runat="server" CssClass="botonForm2" OnClick="BtnOrderHistory_Click" /> 



            <asp:Button Width="75px" Height="75px" Text="My Payments" Font-Size="small" runat="server" CssClass="botonForm2" OnClick="BtnPayment_Click" style="position:relative; top:.5rem;" />

        </div>

        </div>
       
      
</asp:Content>