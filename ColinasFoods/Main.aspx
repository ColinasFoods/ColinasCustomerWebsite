<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

<asp:Content ID = "BodyContent" ContentPlaceHolderID="MainContent" runat ="server">

    <div id ="Maindiv">
        <table style ="margin-left:auto; margin-right:auto;">
            <tr>
                <td align ="center">
                    <asp:Label align ="center" runat ="server" ID ="LblWelcome" CssClass="subtitle" Text ="Welcome to Colinas Foods"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>