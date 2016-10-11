<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LocationMaintenance.aspx.vb" Inherits="LocationMaintenance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#0C4690" Height="278px" Style="z-index: 100;
                left: 10px; position: absolute; top: 124px" Width="256px">
                &nbsp;
                <asp:LinkButton ID="btnMaintenanceHome" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 100; left: 15px; position: absolute;
                    top: 175px" Width="176px">Maintenance Home</asp:LinkButton>
                <p>
                </p>
                <p>
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Names="Georgia"
                        Font-Size="Small" ForeColor="White" Height="10px" Width="192px">What would you like to do?</asp:Label></p>
                <p>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="btnDepartmentmaintenance" runat="server" BackColor="Transparent"
                        Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 105;
                        left: 15px; position: absolute; top: 69px" Width="184px">Department Maintenance</asp:LinkButton>
                </p>
                <p>
                    &nbsp;&nbsp;
                </p>
                <p>
                    &nbsp;&nbsp;
                </p>
                <p>
                    &nbsp; &nbsp;
                    <asp:LinkButton ID="btnMaintenance" runat="server" BackColor="Transparent" Font-Names="Georgia"
                        Font-Size="Small" ForeColor="White" Style="z-index: 102; left: 18px; position: absolute;
                        top: 211px" Width="184px">Home</asp:LinkButton>
                    <asp:LinkButton ID="btnEmployeeMaintenance" runat="server" BackColor="Transparent"
                        Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 103;
                        left: 16px; position: absolute; top: 104px" Width="184px">Employee Maintenance</asp:LinkButton>
                    <asp:LinkButton ID="btnQuestionMaintenance" runat="server" BackColor="Transparent"
                        Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 104;
                        left: 15px; position: absolute; top: 138px" Width="184px">Question Maintenance</asp:LinkButton>
                </p>
            </asp:Panel>
            <asp:GridView ID="DGLocations" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                DataSourceID="Locations" PageSize="15" Style="z-index: 101; left: 337px; position: absolute;
                top: 64px" Width="504px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="IntLocationID" HeaderText="ID" InsertVisible="False" ReadOnly="True"
                        SortExpression="IntLocationID" />
                    <asp:BoundField DataField="StrLocation" HeaderText="Location" SortExpression="StrLocation" />
                    <asp:TemplateField HeaderText="Active" SortExpression="blnactive">
                        <EditItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("blnactive") %>' />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("blnactive") %>' Enabled="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="Locations" runat="server" ConnectionString="<%$ ConnectionStrings:local %>"
                SelectCommand="usp_RetrieveFullLocationList" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>
            <asp:TextBox ID="txtLocation" runat="server" Style="z-index: 102; left: 477px; position: absolute;
                top: 476px" Visible="False" Width="365px"></asp:TextBox>
            <asp:Label ID="lblLocation" runat="server" Style="z-index: 103; left: 352px; position: absolute;
                top: 479px" Text="Location" Visible="False"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" Style="z-index: 104; left: 507px; position: absolute;
                top: 31px" Text="Add Location" />
            <asp:Button ID="btnSave" runat="server" Style="z-index: 105; left: 426px; position: absolute;
                top: 560px" Text="Save" Visible="False" Width="111px" />
            <asp:TextBox ID="txtLocationID" runat="server" Style="z-index: 106; left: 755px;
                position: absolute; top: 560px" Visible="False" Width="71px"></asp:TextBox>
            <asp:Label ID="lblerrors" runat="server" Height="148px" Style="z-index: 107; left: 22px;
                position: absolute; top: 427px" Visible="False" Width="252px"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" Style="z-index: 108; left: 577px; position: absolute;
                top: 563px" Text="Deactivate" Visible="False" Width="111px" />
            <asp:CheckBox ID="chkActive" runat="server" Style="z-index: 110; left: 389px; position: absolute;
                top: 520px" Text="Active" TextAlign="Left" Visible="False" Width="123px" />
        </div>
    
    </div>
    </form>
</body>
</html>
