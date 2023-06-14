<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentSearch.aspx.cs" Inherits="ColinasFoods.PaymentSearch" %>

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
                <div id="PaymentDiv">
                    <table>
                        <tr>
                            <td align="center">
                                    <asp:Label align="center" runat="server" ID="LblPayments" CssClass="tablelabel" Text="Payments" />
                            </td>
                            <td>&nbsp</td>
                            <td align="center">
                                    <asp:Label align="center" runat="server" ID="Label1" CssClass="tablelabel" Text="Payment Details" />
                            </td>
                        </tr>
                        <tr>
                            <td width="40%">
                                <asp:Panel ID="PaymentPanel" align="Center" runat="server" ScrollBars="Auto" style="width:auto;height:600px;overflow:auto;">
                                    <asp:GridView ID="PaymentsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black"  ShowHeaderWhenEmpty="true" runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ShowFooter="true" OnRowDataBound="PaymentsGrid_RowDataBound" DataKeyNames="PaymentAplicationID">
                            
                                        <Columns>
                                     
                                            <asp:BoundField DataField="PaymentNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Payment #" ReadOnly="True" InsertVisible="False" />
                                    
                                            <asp:BoundField DataField="PaymentDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Payment Date"  ReadOnly="true" InsertVisible="false" />
                                    
                                            <asp:BoundField DataField="PaymentTotal" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Total Payment"   ReadOnly="true" InsertVisible="false" />
                                            
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

                                        <FooterStyle BackColor="#b00505" Font-Bold="true" HorizontalAlign="Right" ForeColor="White" />

                                    </asp:GridView>
                           
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_SelectPayments" />
                                </asp:Panel>
                            </td>
                            <td width="10%">&nbsp</td>
                            <td valign="top" width="40%">
                                <table>
                                    <tr>
                                        <td>
                                            PaymentNo:&nbsp&nbsp
                                            <asp:Textbox ID="TxtPaymentNo" runat="server" ReadOnly="true" BackColor="White"></asp:Textbox>
                                            &nbsp&nbsp&nbsp&nbsp Total:&nbsp&nbsp
                                            <asp:TextBox ID="TxtPaymentTotal" runat="server" ReadOnly="true" BackColor="White"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="PaymentDetailsPanel" runat="server" ScrollBars="Auto">
                                                <asp:GridView ID="DetailsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black"  runat="server" width="500px" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" DataKeyNames="PaymentReceivedID">
                            
                                                    <Columns>
                                     
                                                        <asp:BoundField DataField="InvoiceNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Invoice #" ReadOnly="True" InsertVisible="False" />
                                     
                                                        <asp:BoundField DataField="Total" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Invoice Total" ReadOnly="True" InsertVisible="False" />
                                    
                                                        <asp:BoundField DataField="Amount" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Payment" ReadOnly="true" InsertVisible="false" />

                                                    </Columns>

                                                </asp:GridView>
                           
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_SelectPayment_Details" />
                               
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
