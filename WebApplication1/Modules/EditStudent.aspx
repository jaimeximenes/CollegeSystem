<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="WebApplication1.EditStudent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <body>
        <div>
            <h1>Edit Student</h1>

            <div>
                <h2>Welcome</h2>
                <asp:Label ID="Label1" runat="server" Text="">Student</asp:Label>
                <hr />
                <br />
                <h3>Input the Name</h3>
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
                <h3>Input Age</h3>
                <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox><br />
                <h3>Input Id Subject</h3>
                <asp:TextBox ID="TxtIdSubject" runat="server"></asp:TextBox><br />
                <br />

                <asp:Button ID="SaveStudent" runat="server" OnClick="SaveStudent_Click" Text="Save"></asp:Button>
            </div>
    </body>
</asp:Content>
