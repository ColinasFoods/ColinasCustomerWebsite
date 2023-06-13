<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InvoiceSearch.aspx.cs" Inherits="ColinasFoods.InvoiceSearch" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(document).ready(function () {
            $('.datepicker-field').datepicker();
        });
    </script>
    <table id="OuterTable" width="100%">
        <tr>
            <td>

                <table id="FilterTable">
                    <tr>
                        <td>From:</td>
                        <td>
                            <asp:TextBox ID="TxtStartDate" Width="75px" runat="server" CssClass="datepicker-field"/>
                        </td>
                        <td>&nbsp&nbsp&nbsp</td>
                        <td>To:</td>
                        <td>
                            <asp:TextBox ID="TxtEndDate" Width="75px" runat="server" CssClass="datepicker-field"/>
                        </td>
                        <td>&nbsp&nbsp&nbsp</td>
                        <td>
                            <asp:Button ID="BtnQuery" Width="75px" Text="Query" runat="server" CssClass="botonForm" OnClick="BtnQuery_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <div id="InvoiceDiv">
                    <table>
                        <tr>
                            <td align="center">
                                    <asp:Label align="center" runat="server" ID="LblInvoices" CssClass="tablelabel" Text="Invoices" />
                            </td>
                            <td>&nbsp</td>
                            <td align="center">
                                    <asp:Label align="center" runat="server" ID="Label1" CssClass="tablelabel" Text="Invoice Details" />
                            </td>
                        </tr>
                        <tr>
                            <td width="40%" valign="top" align="Center" >
                               <asp:Panel ID="InvoicePanel" runat="server" style="width:auto;height:600px;overflow:auto;">
                                    <asp:GridView ID="InvoicesGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black"  ShowHeaderWhenEmpty="true" runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" DataKeyNames="InvoiceID" OnRowDataBound="InvoicesGrid_RowDataBound" ShowFooter="True">
                            
                                        <Columns>
                                     
                                            <asp:BoundField DataField="InvoiceNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Invoice #" SortExpression="InvoiceNo" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="InvoiceDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Invoice Date"  SortExpression="InvoiceDate" ReadOnly="true" InsertVisible="false" />
                                    
                                            <asp:BoundField DataField="Total" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Total"  SortExpression="Total" ReadOnly="true" InsertVisible="false" />

                                            

                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:Button runat="server" ID="btnDetails" Text="Details" Width="75px" CssClass="botonForm" OnClick="btnDetails_Click" />
                                                </ItemTemplate> 
                                            </asp:TemplateField>
                                        </Columns>

                                        <FooterStyle BackColor="#b00505" Font-Bold="true" HorizontalAlign="Right" ForeColor="White" />

                                    </asp:GridView>
                           
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_SelectInvoices" />
                                </asp:Panel>
                            </td>
                            <td width="10%">&nbsp</td>
                            <td valign="top" width="40%">
                                <table>
                                    <tr>
                                        <td>
                                            InvoiceNo:&nbsp&nbsp
                                            <asp:Textbox ID="TxtInvoiceNo" runat="server" ReadOnly="true" BackColor="White"></asp:Textbox>
                                            &nbsp&nbsp&nbsp&nbsp Total:&nbsp&nbsp
                                            <asp:TextBox ID="TxtTotal" runat="server" ReadOnly="true" BackColor="White"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="InvoiceDetailsPanel" runat="server" ScrollBars="Auto">
                                                <asp:GridView ID="DetailsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black"  runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" DataKeyNames="InvoiceDetailsID">
                            
                                                    <Columns>
                                     
                                                        <asp:BoundField DataField="ItemNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Item #" SortExpression="ItemNo" ReadOnly="True" InsertVisible="False" />
                                     
                                                        <asp:BoundField DataField="Quantity" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Qty." SortExpression="Quantity" ReadOnly="True" InsertVisible="False" />
                                    
                                                        <asp:BoundField DataField="UofM" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="UM"  SortExpression="UofM" ReadOnly="true" InsertVisible="false" />
                                    
                                                        <asp:BoundField DataField="Description" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Description"  SortExpression="ShipDate" ReadOnly="true" InsertVisible="false" />
                                    
                                                        <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Unit Price"  SortExpression="UnitPrice" ReadOnly="true" InsertVisible="false" />
                                    
                                                        <asp:BoundField DataField="Amount" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Amount"  SortExpression="Amount" ReadOnly="true" InsertVisible="false" />

                                                    </Columns>

                                                </asp:GridView>
                           
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_SelectInvoice_Details" />
                               
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
    <asp:HiddenField ID="HiddenFieldSID" runat="server" />
</asp:Content>
