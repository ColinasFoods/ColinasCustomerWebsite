<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PDFDownloads.aspx.cs" Inherits="ColinasFoods.PDFDownloads" %>

<asp:Content  ID = "BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div id="CreditAPP" style="left:2rem; top:-3rem; position:relative;">
        <img src="PDF/CreditApp.png" style="width:35%; height:100%"/> 
            <div style=" position:relative;left:14rem" >
                <a href = "PDF/CreditAPP.pdf" download = "CreditAPP.pdf"> Download Here </a>
            </div>
    </div>


</asp:Content>
