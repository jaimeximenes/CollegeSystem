<%@ Page Title="Adicionar Matéria" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSubject.aspx.cs" Inherits="WebApplication1.AddSubject" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <h1>Add Subject</h1>


    <h2>Welcome</h2>
    <hr />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <h4>Input Subject Name</h4>
    <br />
    <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br />
    <br />
    <h4>Input Id Professor</h4>
    <asp:TextBox ID="txtIdProfessor" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" CssClass="btn-success" runat="server" OnClick="Button1_Click" Text="Save" />
    <br />

    <asp:Repeater ID="RepeaterSubject" OnItemCommand="RepeaterSubject_ItemCommand" runat="server">
        <HeaderTemplate>
            <table>
                <tr>
                    <td>ID Subject</td>
                    <td>Name</td>
                    <td>Teacher ID</td>
                    <td>Opções</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr style="background-color: #ffffff">
                <td>
                    <tr>
                        <td><%# Eval("IdSubject") %> </td>
                        <td><%# Eval("Name") %> </td>
                        <td><%# Eval("TecharId") %> </td>
                        <td>
                            <%--<asp:LinkButton ID="edit" runat="server" CommandArgument='<%# Eval("IdSubject") %>' OnClick="edit_Click" CommandName="edit">Edit</asp:LinkButton>--%>
                            <asp:HyperLink runat="server" ID="hlEdit" NavigateUrl='<%# Eval("IdSubject","~/EditSubject?id={0}") %>'>edit</asp:HyperLink>

                            <asp:LinkButton ID="delet" runat="server" CommandArgument='<%# Eval("IdSubject") %>' CommandName="delet">Delet</asp:LinkButton>

                        </td>
                    </tr>
                </td>
        </ItemTemplate>
    </asp:Repeater>


    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Edit Subject</h4>
                </div>
                <div class="modal-body">
                    <h4>Input Subject Name</h4>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                    <br />
                    <h4>Input Id Professor</h4>

                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>

                <div class="modal-footer">
                    <asp:Button ID="Button2" CssClass="btn-success" runat="server" Text="Save" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

