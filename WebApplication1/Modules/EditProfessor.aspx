<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProfessor.aspx.cs" Inherits="WebApplication1.EditProfessor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <body>
        <div>
            <h1>Edit Professor</h1>

        <div>
            <h2>Welcome</h2>
            <asp:Label ID="Label1" runat="server" Text="">Professor ID: </asp:Label>
            <hr />
            <br />
            <h3>Input the Name</h3>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
            <h4>Input CPF</h4>
            <asp:TextBox ID="TxtCPF" runat="server"></asp:TextBox><br />
            <h4>Input the Age</h4>
            <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox><br />
            <br />

            
            <asp:Button ID="SaveTeacher" runat="server" OnClick="SaveTeacher_Click" Text="Save"></asp:Button>
        </div>

    </body>
</asp:Content>

