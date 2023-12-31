﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ColinasFoods.Login"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Body Table -->
    <table class="cntr_box" border="0">
        <!-- UserName Label & Text Box -->
        <tr>
            <td align="right" valign="middle" class="txt_login2"> 
                <asp:Label ID="lbl_username" width="115px" runat="server" Text="User name" CssClass="txt_login2"></asp:Label>
            </td>
            <td width="5px" align="left" valign="middle">&nbsp;</td>
            <td align="left" valign="middle">
                <asp:TextBox ID="tb_UserName" runat="server" CssClass="form_Form"></asp:TextBox>
            </td>
            <td align="left" valign="middle">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" CssClass="txt_validate" runat="server" ControlToValidate="tb_UserName" ErrorMessage="UserName is required"> </asp:RequiredFieldValidator>
            </td>
        </tr>

        <!-- Password Label & Text Box -->
        <tr>
            <td align="right" class="txt_login2"> <br />
                <asp:Label ID="lbl_Password" runat="server" Text="Password" CssClass="txt_login2"></asp:Label>
            </td>
            <td align="right" valign="middle">&nbsp;</td>
            <td align="left" valign="middle"> 
                <asp:TextBox ID="tb_Password" runat="server" TextMode="Password" CssClass="form_Form"></asp:TextBox>
            </td>
            <td align="left" valign="middle"> <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" CssClass="txt_validate" runat="server" ControlToValidate="tb_Password" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
            </td>
            <td align="left" valign="middle">
                <button id="btn_PasswordToggle" type="button" class="btn_toggle" onclick="PasswordVisibility(); return false;">Show</button>
            </td>
        </tr>

        <!-- Login Button -->
        <tr>
            <td align="left" valign="middle">&nbsp;</td>
            <td align="left" valign="middle">&nbsp;</td>
            <td colspan="2" align="left" valign="middle">
                <br />
                <asp:Button ID="btn_LogIn" Text="Log In" runat="server" OnClick="btn_LogIn_Click" CssClass="botonForm" />
            </td>
        </tr>
        
    </table>

    <!-- JavaScript code -->
    <script>
        // Function to toggle password visibility
        function PasswordVisibility() {
            var passwordField = document.getElementById('<%= tb_Password.ClientID %>');
            var passwordToggle = document.getElementById('btn_PasswordToggle');

            if (passwordField.type === 'password') {
                passwordField.type = 'text';
                passwordToggle.innerText = 'Hide';
            } else {
                passwordField.type = 'password';
                passwordToggle.innerText = 'Show';
            }
        }
        // Function to handle the key press event
        function handleKeyPress(e) {
            if (e.keyCode === 13) {
                document.getElementById('<%= btn_LogIn.ClientID %>').click();
                return false;
            }
        }
        document.addEventListener('keypress', handleKeyPress);
    </script>
</asp:Content>
