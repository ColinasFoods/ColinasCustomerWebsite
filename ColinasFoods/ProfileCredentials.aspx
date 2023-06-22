<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProfileCredentials.aspx.cs" Inherits="ColinasFoods.ProfileCredentials" %>

<asp:Content  ID = "BodyContent" ContentPlaceHolderID="MainContent" style="text-align:center;" runat="server">
    <h1 class:"text" style="text-align:center;"> My Credentials </h1>
        <h2 class:"text2" style ="text-align:center;">Username: <%= ColinasFoods.Essentials.UserName != null && ColinasFoods.Essentials.UserName.Length > 0 ? ColinasFoods.Essentials.UserName.Substring(0) : "" %> </h2>
        <div style="align-content:center; text-align:center;">
                 <asp:Label runat="server" ID="passwordLabel" style="text-align:center;">
                    Password: 
                </asp:Label>
            </div>
</asp:Content>
