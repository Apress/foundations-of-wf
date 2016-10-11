<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Review.aspx.vb" Inherits="Review" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#0C4690" Height="278px" Style="z-index: 100;
            left: 0px; position: absolute; top: 152px" Width="256px">
            &nbsp;
            <p>
            </p>
            <p>
                &nbsp; &nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Height="10px" Width="192px">What would you like to do?</asp:Label></p>
            <p>
                &nbsp; &nbsp;
                <asp:LinkButton ID="btnExistingReviews" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Width="184px">Existing Reviews</asp:LinkButton></p>
            <p>
                &nbsp; &nbsp;
                <asp:LinkButton ID="btnMaintenance" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 100; left: 17px; position: absolute;
                    top: 155px" Width="184px">Maintenance</asp:LinkButton>
                <asp:LinkButton ID="btnMyEmployees" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 101; left: 15px; position: absolute;
                    top: 119px" Width="184px">My Employees</asp:LinkButton>
                <asp:LinkButton ID="btnHome" runat="server" BackColor="Transparent" Font-Names="Georgia"
                    Font-Size="Small" ForeColor="White" Style="z-index: 103; left: 16px; position: absolute;
                    top: 189px" Width="184px">Home</asp:LinkButton>
            </p>
        </asp:Panel>
        <asp:TextBox ID="txtEmployeeID" runat="server" Style="z-index: 101; left: 149px;
            position: absolute; top: 127px" Visible="False" Width="60px"></asp:TextBox>
        <asp:Label ID="lblEmployeeName" runat="server" Font-Names="Arial" Font-Size="Medium"
            Style="z-index: 102; left: 260px; position: absolute; top: 16px" Text="Employee Name:"></asp:Label>
        <asp:TextBox ID="txtEmployeeName" runat="server" ReadOnly="True" Style="z-index: 103;
            left: 260px; position: absolute; top: 39px" Width="287px"></asp:TextBox>
        <asp:Label ID="lblJobTitle" runat="server" Font-Names="Arial" Font-Size="Medium"
            Style="z-index: 104; left: 586px; position: absolute; top: 16px" Text="Job Title:"></asp:Label>
        <asp:TextBox ID="txtJobTitle" runat="server" ReadOnly="True" Style="z-index: 105;
            left: 586px; position: absolute; top: 38px" Width="304px"></asp:TextBox>
        <asp:Label ID="lblDepartment" runat="server" Font-Names="Arial" Font-Size="Medium"
            Style="z-index: 106; left: 260px; position: absolute; top: 67px" Text="Department:"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" ReadOnly="True" Style="z-index: 107;
            left: 261px; position: absolute; top: 90px" Width="279px"></asp:TextBox>
        <asp:Label ID="lblSupervisor" runat="server" Font-Names="Arial" Font-Size="Medium"
            Style="z-index: 108; left: 589px; position: absolute; top: 67px" Text="Supervisor"></asp:Label>
        <asp:TextBox ID="txtSupervisor" runat="server" ReadOnly="True" Style="z-index: 109;
            left: 589px; position: absolute; top: 88px" Width="298px"></asp:TextBox>
        <asp:Label ID="lblSummaryHeading" runat="server" Font-Bold="True" Font-Names="Arial"
            Style="z-index: 110; left: 407px; position: absolute; top: 121px" Text="Part II: Summary of Performance Goals"
            Width="304px"></asp:Label>
        <asp:TextBox ID="txtSummary" runat="server" Height="184px" Style="z-index: 111;
            left: 267px; position: absolute; top: 187px" TextMode="MultiLine" Width="618px"></asp:TextBox>
        <asp:Label ID="lblSummaryInstructions" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 112; left: 267px; position: absolute; top: 152px"
            Text="Highlight performance relative to goals and business conditions that contributed to circumstances. Note any mid-year position changes."
            Width="629px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label ID="lblCareerInterestsHeader" runat="server" Font-Bold="True" Font-Names="Arial"
            Style="z-index: 113; left: 354px; position: absolute; top: 469px" Text="Part V:  Career Interests (Optional)"
            Width="304px"></asp:Label>
        <asp:Label ID="lblCareerInterestInstructions" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 114; left: 255px; position: absolute; top: 504px"
            Text="Employee may note other functions, positions, or locations of interest.  This section is optional."
            Width="608px"></asp:Label>
        <asp:TextBox ID="txtCareerInterest" runat="server" Height="184px"
            Style="z-index: 115; left: 255px; position: absolute; top: 529px" TextMode="MultiLine"
            Width="618px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtReviewID" runat="server" Style="z-index: 116; left: 150px; position: absolute;
            top: 97px" Visible="False" Width="60px"></asp:TextBox>
        &nbsp;&nbsp;
        <table style="z-index: 125; left: 0px; position: absolute; top: 0px">
            <tr>
                <td style="width: 3px; height: 47px">
                </td>
                <td style="width: 3px; height: 47px">
                </td>
            </tr>
            <tr>
                <td style="width: 3px">
                </td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td style="width: 3px">
                </td>
                <td style="width: 3px">
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;
        <asp:Button ID="btnPerformance" runat="server" Style="z-index: 117; left: 393px;
            position: absolute; top: 399px" Text="Part III: Performance Criteria" Width="218px" />
        <asp:Button ID="btnGoals" runat="server" Style="z-index: 118; left: 395px; position: absolute;
            top: 435px" Text="Part IV: Goals" Width="218px" />
        <asp:TextBox ID="txterrors" runat="server" Height="184px" ReadOnly="True" Style="z-index: 119;
            left: -2px; position: absolute; top: 448px" TextMode="MultiLine" Visible="False"
            Width="248px"></asp:TextBox>
        <asp:Label ID="lblEmployeeCommentsInstructions" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 120; left: 326px; position: absolute; top: 797px"
            Text="Employee may comment on review.  This section is optional." Width="400px"></asp:Label>
        <asp:TextBox ID="txtEmployeeComments" runat="server" Height="184px" Style="z-index: 121; left: 257px;
            position: absolute; top: 828px" TextMode="MultiLine" Width="618px"></asp:TextBox>
        <asp:Label ID="lblEmployeeCommentsHeader" runat="server" Font-Bold="True" Font-Names="Arial"
            Style="z-index: 122; left: 361px; position: absolute; top: 770px" Text="Part VII:  Employee Comments (Optional)"
            Width="332px"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" Style="z-index: 123; left: 592px;
            position: absolute; top: 737px" Text="Submit to Supervisor" Width="218px" />
        <asp:Button ID="btnSave" runat="server" Style="z-index: 126; left: 329px;
            position: absolute; top: 736px" Text="Save Review" Width="218px" />
    
    </div>
    </form>
</body>
</html>
