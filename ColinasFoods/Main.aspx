<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ColinasFoods.Main" %>

<asp:Content ID = "BodyContent" ContentPlaceHolderID="MainContent" runat ="server" style="margin:0px;width:0px; height:100rem">
    
    <div id="Maindiv" style="height: 0rem; width: 0rem;">
        <asp:Panel runat="server" ID="WelcomeDiv" CssClass="subtitle" Font-Size="20px" Width="500px" HorizontalAlign="Left">
            <h1 style="position: relative; left: 35rem; top: -5rem;">Welcome Back, <%= ColinasFoods.Essentials.UserName != null && ColinasFoods.Essentials.UserName.Length > 0 ? (Char.ToUpper(ColinasFoods.Essentials.UserName[0]) + ColinasFoods.Essentials.UserName.Substring(1)) : "" %></h1>
        </asp:Panel>
        <table style="width: 0rem; position: relative; right: -2rem; bottom: 7rem;">
            <tr>
                <td align="center">
                    <asp:Label align="center" runat="server" ID="LblWelcome" CssClass="subtitle" Text="About Us" />

                    <h2 style="color: black; font-size: 19px; width: 600px;">As a Texas-based company founded in 2015, we pride ourselves as a family-owned and operated
                            business committed to our customers' success. We are dedicated to supplying high-quality protein, produce, groceries, dairy products 
                            and dry goods for restaurants and other foodservice clients, as well as residential. We understand that the food industry demands 
                            a reliable and consistent supply chain. By striving to become a partner to our customers, we aim to foster loyalty, satisfaction, 
                            and mutual growth.  With our focus on customization, quality, and reliability, we are confident in our ability to meet the needs of
                            our customers and help them achieve their goals.</h2>
                    <div id="recentSales">
                        <table>
                            <tr>
                                <td align="center">
                                    <asp:Label align="center" runat="server" ID="RecentSales" CssClass="tablelabel" Text="Recent Sales Orders" />
                                </td>
                            </tr>
                            <tr>
                                <td width="100%" valign="top" align="center">
                                    <asp:Panel ID="RecentPanel" runat="server" ScrollBars="Auto">

                                        <asp:GridView ID="ItemsGrid" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderColor="Black" OnSelectedIndexChanged="ItemsGrid_SelectedIndexChanged" ShowHeaderWhenEmpty="true" EmptyDataText="You have no previous Sales Orders" runat="server" AutoGenerateColumns="False" CssClass="GridMain" BackColor="White" BorderColor="#d52a3d" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" DataKeyNames="SalesOrderID" AllowPaging="true" PageSize="3">
                                            <PagerStyle CssClass="hidden" />
                                            <Columns>

                                                <asp:BoundField DataField="SalesOrderNo" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Order Number" SortExpression="SalesOrderNo" ReadOnly="True" InsertVisible="False" />

                                                <asp:BoundField DataField="ReleaseDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Date Submitted" SortExpression="ReleaseDate" ReadOnly="true" InsertVisible="false" />

                                                <asp:BoundField DataField="RequiredDate" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Required Date" SortExpression="RequiredDate" ReadOnly="true" InsertVisible="false" />

                                                <asp:BoundField DataField="Total" DataFormatString="{0:C}" HeaderStyle-ForeColor="White" HeaderStyle-BackColor="#d52a3d" HeaderText="Total $" SortExpression="Total" ReadOnly="true" InsertVisible="false" />


                                            </Columns>

                                        </asp:GridView>

                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Sales_OrderHistory" />
                                        <asp:Button ID="BtnAddNewSO" Width="200px" Text="New Sales Order" runat="server" CssClass="botonForm" OnClick="BtnAddNewSO_Click" />
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
        <div id="MyBalanceDiv" style="position: relative; top: -18rem; right: -38rem; width: 10rem">
            <asp:GridView ID="hiddenBalanceGrid" runat="server" CssClass="hidden"></asp:GridView>
            <h1>My Total Balance:</h1>
            <asp:Label ID="balanceLabel" runat="server" CssClass="botonForm"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ColinasERPEntities %>" SelectCommandType="StoredProcedure" SelectCommand="Ac_GetBalance" />
        </div>

        <div style="position: relative; height: 0rem; width: 10rem; top: -200px;">
            <h1 cssclass="subtitle" style="left: 41.5rem;text-align: center;position: relative;display: flex;bottom: 500px;">Explore Our Page</h1>
            <div id="Buttons" style="position:relative;top: -500px;">
                <div style="position: relative;left: 41.5rem;bottom: 45rem;top: 0px;">

                    <asp:Button ID="Balance" Width="75px" Height="75px" Text="My Balance" Font-Size="Small" runat="server" CssClass="botonForm2" OnClick="BtnBalance_Click" />





                    <asp:Button Width="75px" Height="75px" Text="My Invoices" Font-Size="small" runat="server" CssClass="botonForm2" OnClick="BtnInvoice_Click" Style="position: relative; top: .5rem;" />




                </div>
                <div style="position: relative;left: 47.5rem;bottom: 200px;top: -150px;">


                    <asp:Button Width="75px" Height="75px" Text="My Sales" Font-Size="small" runat="server" CssClass="botonForm2" OnClick="BtnOrderHistory_Click" />



                    <asp:Button Width="75px" Height="75px" Text="My Payments" Font-Size="small" runat="server" CssClass="botonForm2" OnClick="BtnPayment_Click" Style="position: relative; top: .5rem;" />

                </div>

            </div>
        </div>

        <!-- Slideshow container -->
        <div class="slideshow-container" style="width: 20rem">

            <!-- Full-width images with number and caption text -->
            <div class="mySlides fade">
                <img src="Images/WelcomeTo.png" style="width: 160%">
                <div class="text" style="width: 200px">Welcome To Colinas</div>
            </div>

            <div class="mySlides fade">
                <img src="Images/OrderToday.png" style="width: 150%">
                <div class="text2" style="width: 200px">Order Today!</div>
            </div>

            <!-- <div class="mySlides fade">
            <div class="numbertext">3 / 3</div>
            <img src="img3.jpg" style="width:100%">
            <div class="text">Caption Three</div>
          </div> -->

            <!-- Next and previous buttons -->
            <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
            <a class="next" onclick="plusSlides(1)">&#10095;</a>
        </div>

        <!-- The dots/circles -->
        <div style="position: relative; top: -40rem; right: -70rem; text-align: center; width: 40px;">
            <span class="dot" onclick="currentSlide(1)"></span>
            <span class="dot" onclick="currentSlide(2)"></span>
        </div>

        <script>
            let slideIndex = 0;
            showSlides();

            // Next/previous controls
            function plusSlides(n) {
                showSlides(slideIndex += n);
            }

            // Thumbnail image controls
            function currentSlide(n) {
                showSlides(slideIndex = n);
            }

            function showSlides() {
                let i;
                let slides = document.getElementsByClassName("mySlides");
                let dots = document.getElementsByClassName("dot");
                if (slideIndex >= slides.length) { slideIndex = 0 }
                if (slideIndex < 0) { slideIndex = slides.length - 1 }
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = "none";
                }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i].className.replace(" active", "");
                }
                slides[slideIndex].style.display = "block";
                dots[slideIndex].className += " active";
            }
        </script>
    </div>
       
      
</asp:Content>