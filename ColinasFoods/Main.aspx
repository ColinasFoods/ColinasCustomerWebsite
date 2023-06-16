<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

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
</asp:Content>