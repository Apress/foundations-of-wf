<%@ Page Language="VB" AutoEventWireup="false" CodeFile="QuestionMaintenance.aspx.vb" Inherits="QuestionMaintenance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#0C4690" Height="278px" Style="z-index: 100;
            left: 3px; position: absolute; top: 152px" Width="256px">
            &nbsp;
            <asp:LinkButton ID="btnMaintenanceHome" runat="server" BackColor="Transparent" Font-Names="Georgia"
                Font-Size="Small" ForeColor="White" Style="z-index: 100; left: 15px; position: absolute;
                top: 165px" Width="176px">Maintenance Home</asp:LinkButton>
            <p>
            </p>
            <p>
                &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Height="10px" Width="192px">What would you like to do?</asp:Label></p>
            <p>
                &nbsp;&nbsp;
                <asp:LinkButton ID="btnLocationmaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 105;
                    left: 18px; position: absolute; top: 106px" Width="184px">Location Maintenance</asp:LinkButton>
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
                    top: 204px" Width="184px">Home</asp:LinkButton>
                <asp:LinkButton ID="btnEmployeeMaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 103;
                    left: 16px; position: absolute; top: 135px" Width="184px">Employee Maintenance</asp:LinkButton>
                <asp:LinkButton ID="btnDepartmentMaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 104;
                    left: 19px; position: absolute; top: 70px" Width="184px">Department Maintenance</asp:LinkButton>
            </p>
        </asp:Panel>
        <asp:GridView ID="DGQuestion" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataSourceID="Question" Style="z-index: 101; left: 287px; position: absolute;
            top: 65px" Width="504px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="IntQuestionId" HeaderText="ID" InsertVisible="False" ReadOnly="True"
                    SortExpression="IntQuestionId" />
                <asp:BoundField DataField="intorder" HeaderText="Order" SortExpression="intorder" />
                <asp:BoundField DataField="StrQuestion" HeaderText="Question" SortExpression="StrQuestion" />
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
        <asp:SqlDataSource ID="Question" runat="server" ConnectionString="<%$ ConnectionStrings:local %>"
            SelectCommand="usp_RetrieveFullQuestionList" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:TextBox ID="txtQuestion" runat="server" Style="z-index: 102; left: 433px;
            position: absolute; top: 402px" Visible="False" Width="365px" Height="63px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="lblQuestion" runat="server" Style="z-index: 103; left: 370px; position: absolute;
            top: 410px" Text="Question" Visible="False"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" Style="z-index: 104; left: 496px; position: absolute;
            top: 29px" Text="Add Question" />
        <asp:Button ID="btnSave" runat="server" Style="z-index: 105; left: 411px; position: absolute;
            top: 544px" Text="Save" Visible="False" Width="111px" />
        <asp:TextBox ID="txtQuestionID" runat="server" Style="z-index: 106; left: 822px;
            position: absolute; top: 352px" Visible="False" Width="71px"></asp:TextBox>
        <asp:Label ID="lblerrors" runat="server" Height="148px" Style="z-index: 107; left: 9px;
            position: absolute; top: 436px" Visible="False" Width="252px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Style="z-index: 108; left: 568px; position: absolute;
            top: 543px" Text="Deactivate" Visible="False" Width="111px" />
        <asp:CheckBox ID="chkActive" runat="server" Style="z-index: 109; left: 376px; position: absolute;
            top: 497px" Text="Active" TextAlign="Left" Visible="False" Width="123px" />
        <asp:TextBox ID="txtOrder" runat="server" Height="16px" Style="z-index: 110; left: 436px;
            position: absolute; top: 372px" Visible="False" Width="59px"></asp:TextBox>
        <asp:Label ID="lblOrder" runat="server" Style="z-index: 112; left: 370px; position: absolute;
            top: 371px" Text="Order" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
