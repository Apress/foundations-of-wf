<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#0C4690" Height="278px" Style="z-index: 100;
            left: 0px; position: absolute; top: 170px" Width="256px">
            &nbsp;
            <p>
            </p>
            <p>
                &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Height="10px" Width="192px">What would you like to do?</asp:Label></p>
            <p>
                &nbsp;&nbsp;
                <asp:LinkButton ID="btnNewSelfReview" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Width="176px">New Self-Review</asp:LinkButton></p>
            <p>
                &nbsp;&nbsp;
                <asp:LinkButton ID="btnExistingReviews" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Width="184px">Existing Reviews</asp:LinkButton></p>
            <p>
                &nbsp;&nbsp;
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnMaintenance" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 101; left: 10px; position: absolute;
                    top: 198px" Width="184px">Maintenance</asp:LinkButton>
                <asp:LinkButton ID="btnMyEmployees" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 103; left: 12px; position: absolute;
                    top: 154px" Width="184px">My Employees</asp:LinkButton>
            </p>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
