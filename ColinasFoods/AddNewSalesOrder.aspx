<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewSalesOrder.aspx.cs" Inherits="ColinasFoods.AddNewSalesOrder" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(document).ready(function () {
            $('.datepicker-field').datepicker({
                minDate: 1
            });
        });
    </script>
    <asp:Panel runat="server" Width="100%">
    <table>
        <tr>
            <td align="center">
                <asp:Button ID="BtnOrdered" Width="200px" Text="Ordered Items" runat="server" CssClass="botonForm2" OnClick="BtnOrdered_Click"/>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnOther" Width="200px" Text="Other Items" runat="server" CssClass="botonForm2" OnClick="BtnOther_Click"  />
            </td>
            <td>&nbsp;</td>
            <td align="center">
                <asp:Label runat="server" ID="LblCart" Text="Cart" CssClass="tablelabel" />
            </td>
        </tr>
    </table>
    <!-- Added Table Right Below -->
    <table>
        <tr>
            <td>
                <asp:Panel runat="server" style="width:45%;height:400px;overflow:auto;">
                        <asp:TextBox runat="server" ID="TxtFilter" Width="100%" AutoPostBack="true" CssClass="form_Form" OnTextChanged="TxtFilter_TextChanged" placeholder="Search" />
                        <asp:GridView ID="ItemsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black" OnSelectedIndexChanged="ItemsGrid_SelectedIndexChanged"  ShowHeaderWhenEmpty="true" EmptyDataText="No previously ordered items were found" runat="server" AutoGenerateColumns="False"  CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" DataKeyNames="MaterialID">
                            
                            <Columns>
                                     
                                <asp:BoundField DataField="PartNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Part #" SortExpression="PartNo" ReadOnly="True" InsertVisible="False" />
                                    
                                <asp:BoundField DataField="MaterialDescription" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Item Description"  SortExpression="MaterialDescription" ReadOnly="true" InsertVisible="false" />
                                     
                                <asp:BoundField DataField="UM" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Measurement"  SortExpression="UM" ReadOnly="true" InsertVisible="false" />
                                           
                                <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" HeaderText="Price $"  SortExpression="Price" ReadOnly="true" InsertVisible="false" />
                                
                                <asp:CommandField ShowSelectButton="True" SelectText="Add" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" ItemStyle-ForeColor="#b00505" ItemStyle-BackColor="White"   />       
                                   
                            </Columns>
                  
                        </asp:GridView>
                       
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure"  />
             
                </asp:Panel>
            </td>
            <td>&nbsp</td>
            <td valign="top" align="center">
                <asp:Panel runat="server" Width="100%" >
                    <asp:gridview ID="CartGrid" runat="server" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black"  ShowHeaderWhenEmpty="true" EmptyDataText="No Items on Cart" ShowFooter="true" AutoGenerateColumns="false" OnRowDataBound="CartGrid_RowDataBound" CssClass="Grid"  BackColor="White" BorderColor="#b00505" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                            <Columns>
                            <asp:BoundField DataField="ItemNumber" HeaderText="Item #" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" ItemStyle-HorizontalAlign="Center" SortExpression="ItemNumber" ReadOnly="True" InsertVisible="False" />

                            <asp:BoundField DataField="PartNo"  HeaderText="Part #" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" ItemStyle-HorizontalAlign="Center" SortExpression="ItemNumber" ReadOnly="True" InsertVisible="False" />

                            <asp:BoundField DataField="ItemDesc" HeaderText="Item" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" ItemStyle-HorizontalAlign="Left" SortExpression="ItemNumber" ReadOnly="True" InsertVisible="False" />

                            <asp:BoundField DataField="UM" HeaderText="Measurement" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" ItemStyle-HorizontalAlign="Right" SortExpression="ItemNumber" ReadOnly="True" InsertVisible="False" />

                            <asp:BoundField DataField="Price" HeaderText="Price $" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" ItemStyle-HorizontalAlign="Right" SortExpression="ItemNumber" ReadOnly="True" InsertVisible="False" />

                            <asp:TemplateField HeaderText="Quantity" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505">
                                <ItemTemplate>
                                     <asp:TextBox ID="Qty" runat="server" AutoPostBack="true" OnTextChanged="Qty_TextChanged" Width="75px" style="text-align: center" CssClass="ui-icon-tag"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="Total" ItemStyle-HorizontalAlign="Right" HeaderText="Total $" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#b00505" SortExpression="ItemNumber" ReadOnly="True" InsertVisible="False" />

                            </Columns>

                            <FooterStyle BackColor="#b00505" Font-Bold="true" HorizontalAlign="Right" ForeColor="White" />
                    </asp:gridview>
                    <table>
                        <tr>
                            <td>Required Date</td>
                            <td>
                                <asp:TextBox ID="TxtStartDate" Width="75px" runat="server" CssClass="datepicker-field"/>
                            </td>
                        </tr>
                    </table>
                    <asp:Button runat="server" ID="BtnSubmit" Text="Submit Order" Width="150px" valign="center" CssClass="botonForm" OnClick="BtnSubmit_Click" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Panel>
    
</asp:Content>

