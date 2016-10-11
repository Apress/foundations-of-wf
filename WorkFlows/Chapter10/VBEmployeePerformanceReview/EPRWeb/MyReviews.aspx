<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MyReviews.aspx.vb" Inherits="MyReviews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="DGReviews" runat="server" AutoGenerateColumns="False" DataSourceID="EmployeeReviews"
            Style="z-index: 100; left: 173px; position: absolute; top: 64px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="intreviewid" HeaderText="Review ID" InsertVisible="False"
                    ReadOnly="True" SortExpression="intreviewid" />
                <asp:BoundField DataField="SupervisorName" HeaderText="Supervisor Name" ReadOnly="True"
                    SortExpression="SupervisorName" />
                <asp:BoundField DataField="DteDateCreated" HeaderText="Date Created" SortExpression="DteDateCreated" />
                <asp:BoundField DataField="dteDateCompleted" HeaderText="Date Completed" SortExpression="dteDateCompleted" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="EmployeeReviews" runat="server" ConnectionString="<%$ ConnectionStrings:local %>"
            SelectCommand="usp_RetrieveReviewsForEmployee" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtEmployeeID" Name="IntEmployeeID" PropertyName="Text"
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:TextBox ID="txtEmployeeID" runat="server" Style="z-index: 102; left: 725px;
            position: absolute; top: 33px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
