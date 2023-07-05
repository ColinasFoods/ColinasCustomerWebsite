<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Balance.aspx.cs" Inherits="ColinasFoods.Balance" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
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
                <div id="BalanceDiv">
                    <table>
                        <tr>
                            <td align="center" width="100%">
                                <asp:Panel ID="BalancePanel" runat="server" ScrollBars="Auto" style="width:auto;height:auto;">
                                    <asp:GridView ID="BalancesGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black" Width="1200px" ShowHeaderWhenEmpty="true" runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#d52a3d" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" OnRowDataBound="BalancesGrid_RowDataBound" ShowFooter="true" DataKeyNames="InvoiceNo">
                            
                                        <Columns>
                                     
                                            <asp:BoundField DataField="InvoiceNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Invoice #" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="InvoiceDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Invoice Date"  ReadOnly="true" InsertVisible="false" />
                                    
                                            <asp:BoundField DataField="InvoicePDueDate"  HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Due Date"   ReadOnly="true" InsertVisible="false" />
                                            
                                            <asp:BoundField DataField="PTDescription" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Terms" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="Balance" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Balance"  ReadOnly="true" InsertVisible="false" />
                                    
                                            <asp:BoundField DataField="OnTime" DataFormatString="{0:C}"  HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="On Time"   ReadOnly="true" InsertVisible="false" />
                                            
                                            <asp:BoundField DataField="P130" DataFormatString="{0:C}"  HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="1 - 30"   ReadOnly="true" InsertVisible="false" />
                                            
                                            <asp:BoundField DataField="P3160" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="31 - 60" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="P6190" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="61 - 90"  ReadOnly="true" InsertVisible="false" />
                                    
                                            <asp:BoundField DataField="P91" DataFormatString="{0:C}"  HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="90+"   ReadOnly="true" InsertVisible="false" />

                                        </Columns>

                                        <FooterStyle BackColor="#d52a3d" Font-Bold="true" HorizontalAlign="Right" ForeColor="White"  BorderColor="Black" BorderStyle ="Solid" />

                                    </asp:GridView>
                           
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_GetBalance" />
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
    <asp:HiddenField ID="HiddenFieldSID" runat="server" />
</asp:Content>
