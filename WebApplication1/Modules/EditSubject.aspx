<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditSubject.aspx.cs" Inherits="WebApplication1.EditSubject" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <body>
        <div>
            <h1>Edit Professor</h1>

            <div>
                <h2>Welcome</h2>
                <hr />
                <br />
                <h3>Input the Name</h3>
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
                <h3>Input Professor Id</h3>
                <asp:TextBox ID="TxtProId" runat="server"></asp:TextBox><br />
                
                <br />


                <asp:Button ID="SaveSubject" runat="server" OnClick="SaveSubject_Click" Text="Save"></asp:Button>
            </div>
    </body>
</asp:Content>
