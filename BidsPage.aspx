<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="BidsPage.aspx.cs" Inherits="BidsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper row3">
    <div id="container">
        <div class="full_width clear"> 
            <asp:panel ID="divSuccess" runat="server" CssClass="alert alert-success alert-dismissable">
                <asp:label ID="lblSuccess" runat="server"></asp:label>
            </asp:panel> 
            <asp:panel ID="divError" runat="server" CssClass="alert alert-danger alert-dismissable">
                <asp:label ID="lblError" runat="server"></asp:label>
            </asp:panel>
        </div>
        <div class="full_width clear">
            <div class="one_half first">
                <div class="table-responsive">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th style="width: 40%;">
                                    Client
                                </th>
                                <th style="width: 20%;">
                                    Bid
                                </th>
                                <th style="width: 10%;">
                                    Status
                                </th>
                                <th style="width: 15%;">
                                    &nbsp;
                                </th>
                                <th style="width: 15%;">
                                    &nbsp;
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:Label ID="namelbl" runat="server"  Text='<%# Eval("name") %>'></asp:Label>
                                        </td>
                                        <td>
                                            $<asp:Label ID="pricelbl" runat="server" Text='<%# Eval("amount") %>' ></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("status") %>' ></asp:Label>
                                        </td>
                                        <td>
                                            <asp:LinkButton  CommandName="accept" ID="LinkButton1" CssClass="btn btn-sm btn-primary" runat="server" style="margin-left:70px" commandArgument='<%#Eval("bidid") + ","+Eval("status") %>'>Accept</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton  CommandName="reject" ID="LinkButton2" CssClass="btn btn-sm btn-default" runat="server"  style="padding:5px" commandArgument='<%#Eval("bidid") + ","+Eval("status") %>'>Reject</asp:LinkButton>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>                                
                        </tbody>
                    </table>
                    <asp:HiddenField ID="hfbidid" runat="server" />
                </div>
            </div>
            <div class="one_half">
                &nbsp;
            </div>
        </div>
    </div>
</div>    
</asp:Content>

