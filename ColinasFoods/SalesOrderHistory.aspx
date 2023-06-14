<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalesOrderHistory.aspx.cs" Inherits="ColinasFoods.SalesOrderHistory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <table id="OuterTable" width="100%">
        <tr>
            <td>
                <div id="SalesOrderDiv">
                    <table>
                        <tr>
                            <td align="center">
                                    <asp:Label align="center" runat="server" ID="LblInvoices" CssClass="tablelabel" Text="Sales Orders" />
                            </td>
                            <td>&nbsp</td>
                            <td align="center">
                                    <asp:Label align="center" runat="server" ID="Label1" CssClass="tablelabel" Text="Order Details" />
                            </td>
                        </tr>
                        <tr>
                            <td width="40%" valign="top" align="center">
                                <asp:Panel ID="SalesPanel" runat="server"  ScrollBars ="Auto" style="padding: 0px; width:590px;height:600px;overflow:auto;">
                                    
                                <asp:Button ID="BtnAddNewSO" Width="200px" Text="New Sales Order" runat="server" CssClass="botonForm" OnClick="BtnAddNewSO_Click" />
                           
                                    <asp:GridView ID="ItemsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black" OnSelectedIndexChanged="ItemsGrid_SelectedIndexChanged"  ShowHeaderWhenEmpty="true" EmptyDataText="You have no previous Sales Orders" runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" DataKeyNames="SalesOrderID">
                            
                                        <Columns>
                                     
                                            <asp:BoundField DataField="SalesOrderNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Order Number" SortExpression="SalesOrderNo" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="ReleaseDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Date Submitted"  SortExpression="ReleaseDate" ReadOnly="true" InsertVisible="false" />
                                     
                                            <asp:BoundField DataField="RequiredDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Required Date"  SortExpression="RequiredDate" ReadOnly="true" InsertVisible="false" />
                                           
                                            <asp:BoundField DataField="Total" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Total $"  SortExpression="Total" ReadOnly="true" InsertVisible="false" />

                                            
                                
                                            <asp:TemplateField>
                                                <HeaderStyle BackColor="#b00505" />
                                                <HeaderTemplate>
                                                    <asp:Label runat="server" Text="Details" ssClass="Grid th" />
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:Button runat="server" ID="btnDetails" Text="Details" Width="75px" CssClass="botonForm" OnClick="btnDetails_Click" />
                                                </ItemTemplate> 
                                            </asp:TemplateField>
                                
                                        </Columns>
                  
                                    </asp:GridView>
                       
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Sales_OrderHistory"  />
                                    
                                </asp:Panel>
                            </td>
                            <td width="10%">&nbsp</td>
                            <td valign="top" width="40%">
                                <table>
                                    <tr>
                                        <td>
                                            Order No.:&nbsp&nbsp
                                            <asp:Textbox ID="TxtSalesOrderNo" runat="server" ReadOnly="true" BackColor="White"></asp:Textbox>
                                            &nbsp&nbsp&nbsp&nbsp Total:&nbsp&nbsp
                                            <asp:TextBox ID="TxtTotal" runat="server" ReadOnly="true" BackColor="White"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="SalesDetailsPanel" runat="server" align="Top" ScrollBars="Auto">
                                                <asp:GridView ID="DetailsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black"  runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" DataKeyNames="SalesOrderDetailID">
                            
                                                    <Columns>
                                     
                                                        <asp:BoundField DataField="ItemNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Item #" SortExpression="ItemNo" ReadOnly="True" InsertVisible="False" />
                                     
                                                        <asp:BoundField DataField="Quantity" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Qty." SortExpression="Quantity" ReadOnly="True" InsertVisible="False" />
                                    
                                                        <asp:BoundField DataField="UofM" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="UM"  SortExpression="UofM" ReadOnly="true" InsertVisible="false" />
                                    
                                                        <asp:BoundField DataField="Description" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Description"  SortExpression="ShipDate" ReadOnly="true" InsertVisible="false" />
                                    
                                                        <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Unit Price"  SortExpression="UnitPrice" ReadOnly="true" InsertVisible="false" />
                                    
                                                        <asp:BoundField DataField="Amount" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Amount"  SortExpression="Amount" ReadOnly="true" InsertVisible="false" />

                                                    </Columns>

                                                </asp:GridView>
                           
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Sales_SelectSales_Details" />
                               
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>

</asp:Content>
