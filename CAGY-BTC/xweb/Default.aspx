<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Default.aspx.cs" Inherits="xweb._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="jumbotron">
      <div class="container">
        <h1>NASA-COIN</h1>
        <p>2017-10-1 Start mining...</p>
        <p><dx:BootstrapButton ID="Button7" runat="server" Text="Download wallet &raquo;" AutoPostBack="false" CssClasses-Button="btn-primary btn-lg">
            </dx:BootstrapButton></p>
      </div>
    </div>

    <div class="container">
      <!-- Example row of columns -->
      <div class="row">
        <div class="col-md-4">
          <h2>BLOCKCHAIN</h2>
          <p>&nbsp;</p>
          <p><dx:BootstrapButton ID="Button1" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
        <div class="col-md-4">
          <h2>UTXO</h2>
          <p>&nbsp;</p>
          <p><dx:BootstrapButton ID="Button2" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
       </div>
        <div class="col-md-4">
          <h2>P2P</h2>
          <p>&nbsp;</p>
          <p><dx:BootstrapButton ID="Button3" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
      </div>
      <div class="row">
        <div class="col-md-4">
          <h2>WORTH CALC</h2>
          <p>&nbsp;</p>
          <p><dx:BootstrapButton ID="Button4" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
        <div class="col-md-4">
          <h2>Cryptography</h2>
          <p>&nbsp;</p>
          <p><dx:BootstrapButton ID="Button5" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
       </div>
        <div class="col-md-4">
          <h2>Other</h2>
          <p>&nbsp;</p>
          <p><dx:BootstrapButton ID="Button6" runat="server" Text="View details &raquo;" AutoPostBack="false">
            </dx:BootstrapButton></p>
        </div>
      </div>
     </div>
</asp:Content>