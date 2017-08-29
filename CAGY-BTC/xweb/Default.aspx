<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Default.aspx.cs" Inherits="xweb._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="jumbotron">
      <div class="container">
        <h1>NASA-COIN</h1>
        <p>NASA-COIN</p>
        <p><dx:BootstrapButton ID="Button7" runat="server" Text="Learn more &raquo;" AutoPostBack="false" CssClasses-Button="btn-primary btn-lg">
            </dx:BootstrapButton></p>
      </div>
    </div>

    <div class="container">
      <!-- Example row of columns -->
      <div class="row">
        <div class="col-md-4">
          <h2>Bootstrap-Enabled</h2>
          <p>These controls natively integrate into Bootstrap-driven layouts thus contributing to the application's adaptivity and consistent look across browsers and devices. </p>
          <p><dx:BootstrapButton ID="Button1" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
        <div class="col-md-4">
          <h2>Adaptive by Design</h2>
          <p>Our rendered code uses Bootstrap CSS components exclusively, meaning that all controls will adjust to any screen resolution. Simply follow Bootstrap guidelines, and you are guaranteed to achieve application-level adaptivity. </p>
          <p><dx:BootstrapButton ID="Button2" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
       </div>
        <div class="col-md-4">
          <h2>Mobile-Friendly</h2>
          <p>With lightweight render, responsive layout, and performance approaching native controls, you can be sure to extend your site's audience reach and boost search rankings. </p>
          <p><dx:BootstrapButton ID="Button3" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
      </div>
      <div class="row">
        <div class="col-md-4">
          <h2>Visually Consistent</h2>
          <p>Focus on business and stop wasting cycles on design. Leave it to Bootstrap's myriad of available visual themes to guarantee consistent look and feel throughout your web application - from early prototype to production. </p>
          <p><dx:BootstrapButton ID="Button4" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
        <div class="col-md-4">
          <h2>An Extensive Control Suite</h2>
          <p>The Bootstrap Control Suite includes a GridView with powerful data analysis and display features, Data Editors with automatic layout management, and Navigation Controls. </p>
          <p><dx:BootstrapButton ID="Button5" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
       </div>
        <div class="col-md-4">
          <h2>Powered by ASP.NET Controls</h2>
          <p>New render comes with familiar feature set. Expect the same level of server-side and client-side API as in  ASP.NET WebForms Controls. And yes, we made sure that transition to the new suite is a breeze. </p>
          <p><dx:BootstrapButton ID="Button6" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
      </div>
     </div>
</asp:Content>