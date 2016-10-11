<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Goals.aspx.vb" Inherits="Goals" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblGoals" runat="server" Font-Bold="True" Font-Names="Arial" Style="z-index: 100;
            left: 243px; position: absolute; top: 28px" Text="Part IV:  Goals (Individual and Business)"
            Width="304px"></asp:Label>
        <asp:Label ID="lblGoalsInstructions" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 101; left: 87px; position: absolute; top: 99px"
            Text="Document goals and objectives for the next appraisal period.  Consider Strategic Goals which move the business forward; Operational Goals to improve known metrics, systems, and procedures; and People Development Goals which broaden knowledge and prepare employees for higher levels of achievement in their current position or in potential future assignments.  Development Goals may be accomplished through project assignments, committee assignments, educational experiences, cross-training, networking, professional memberships, etc.  Goals should be specific and measurable.  "
            Width="689px"></asp:Label>
        <asp:GridView ID="DGGoals" runat="server" AutoGenerateColumns="False" DataSourceID="ReviewGoals"
            Style="z-index: 102; left: 84px; position: absolute; top: 397px" Width="697px">
            <Columns>
                <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
                <asp:BoundField DataField="IntGoalID" HeaderText="Goal ID" InsertVisible="False"
                    SortExpression="IntGoalID" />
                <asp:BoundField DataField="StrGoal" HeaderText="Goal" SortExpression="StrGoal" />
                <asp:BoundField DataField="StrActionPlan" HeaderText="Action Plan" SortExpression="StrActionPlan" />
                <asp:BoundField DataField="StrTargetCompletionDate" HeaderText="Target Completion Date"
                    SortExpression="StrTargetCompletionDate" />
                <asp:BoundField DataField="StrPriority" HeaderText="Priority" SortExpression="StrPriority" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="ReviewGoals" runat="server" ConnectionString="<%$ ConnectionStrings:local %>"
            SelectCommand="usp_RetrieveGoalsForReview" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtReviewID" Name="IntReviewID" PropertyName="Text"
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Button ID="btnAddGoal" runat="server" Style="z-index: 103; left: 289px; position: absolute;
            top: 204px" Text="Add Goal" Width="99px" />
        &nbsp;&nbsp;
        <asp:TextBox ID="txtReviewID" runat="server" Style="z-index: 104; left: 651px; position: absolute;
            top: 31px" Width="62px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="txtGoal" runat="server" Style="z-index: 105; left: 111px; position: absolute;
            top: 229px" TextMode="MultiLine" Visible="False" Width="643px"></asp:TextBox>
        <asp:Label ID="lblGoal" runat="server" Style="z-index: 106; left: 40px; position: absolute;
            top: 231px" Text="Goal:" Visible="False" Width="52px"></asp:Label>
        <asp:TextBox ID="txtGoalID" runat="server" Style="z-index: 107; left: 653px; position: absolute;
            top: 57px" Visible="False" Width="62px"></asp:TextBox>
        <asp:Label ID="lblActionPlan" runat="server" Style="z-index: 108; left: 28px; position: absolute;
            top: 296px" Text="Action Plan:" Visible="False" Width="85px"></asp:Label>
        <asp:TextBox ID="txtActionPlan" runat="server" Style="z-index: 109; left: 111px;
            position: absolute; top: 291px" TextMode="MultiLine" Visible="False" Width="642px"></asp:TextBox>
        <asp:TextBox ID="txtTargetCompletionDate" runat="server" Style="z-index: 110; left: 185px;
            position: absolute; top: 353px" Visible="False" Width="159px"></asp:TextBox>
        <asp:Label ID="lblTargetCompletionDate" runat="server" Style="z-index: 111; left: 29px;
            position: absolute; top: 353px" Text="Target Completion Date" Visible="False"
            Width="154px"></asp:Label>
        <asp:TextBox ID="txtPriority" runat="server" Style="z-index: 112; left: 545px; position: absolute;
            top: 354px" Visible="False" Width="159px"></asp:TextBox>
        <asp:Label ID="lblPriority" runat="server" Style="z-index: 113; left: 473px; position: absolute;
            top: 355px" Text="Priority" Visible="False" Width="62px"></asp:Label>
        <asp:Button ID="btnSaveGoal" runat="server" Style="z-index: 115; left: 446px; position: absolute;
            top: 203px" Text="Save Goal" Width="99px" /></div>
    </form>
</body>
</html>
