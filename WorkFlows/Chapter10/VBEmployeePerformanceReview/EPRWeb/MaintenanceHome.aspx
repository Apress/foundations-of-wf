<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MaintenanceHome.aspx.vb" Inherits="MaintenanceHome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#0C4690" Height="278px" Style="z-index: 100;
            left: 5px; position: absolute; top: 157px" Width="256px">
            &nbsp;
            <p>
            </p>
            <p>
                &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Height="10px" Width="192px">What would you like to do?</asp:Label></p>
            <p>
                &nbsp;&nbsp;
                <asp:LinkButton ID="btnDepartmentMaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Width="176px">Department Maintenance</asp:LinkButton></p>
            <p>
                &nbsp;&nbsp;
                <asp:LinkButton ID="btnLocationmaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Width="184px">Location Maintenance</asp:LinkButton></p>
            <p>
                &nbsp;&nbsp;
            </p>
            <p>
                &nbsp; &nbsp;
                <asp:LinkButton ID="btnMaintenance" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 100; left: 10px; position: absolute;
                    top: 225px" Width="184px">Home</asp:LinkButton>
                <asp:LinkButton ID="btnEmployeeMaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 101;
                    left: 12px; position: absolute; top: 154px" Width="184px">Employee Maintenance</asp:LinkButton>
                <asp:LinkButton ID="btnQuestionMaintenance" runat="server" BackColor="Transparent"
                    Font-Names="Georgia" Font-Size="Small" ForeColor="White" Style="z-index: 103;
                    left: 12px; position: absolute; top: 189px" Width="184px">Question Maintenance</asp:LinkButton>
            </p>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
