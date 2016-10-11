<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PerformanceCriteria.aspx.vb" Inherits="PerformanceCriteria" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblCriteriaHeader" runat="server" Font-Bold="True" Font-Names="Arial"
            Style="z-index: 100; left: 301px; position: absolute; top: 13px" Text="Part III: Performance Criteria"
            Width="304px"></asp:Label>
        <asp:Label ID="lblFullMeets" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"
            Style="z-index: 101; left: 143px; position: absolute; top: 114px" Text="•&#9;Fully Meets Expectations – Job performance consistently and clearly met expectations.  Employees receiving this rating have made significant contributions to the organization.  "
            Width="629px"></asp:Label>
        <asp:Label ID="lblPartiallyMeets" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 102; left: 145px; position: absolute; top: 159px"
            Text="•&#9;Partially Meets Expectations – Job performance sometimes met and sometimes fell short of expectations.  Employees receiving this rating need coaching to bring performance up to standard.    "
            Width="629px"></asp:Label>
        <asp:Label ID="lblFailsToMeet" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 103; left: 139px; position: absolute; top: 204px"
            Text="•&#9;Fails to Meet Expectations – Job performance consistently fell short of expectations.  Employees receiving this rating must be placed on formal performance improvement plans."
            Width="629px"></asp:Label>
        <asp:Label ID="lblExceedsExpectations" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 104; left: 145px; position: absolute; top: 38px"
            Text="•&#9;Exceeds Expectations – Job performance consistently and clearly exceeded expectations.  Employees receiving this rating are easily recognized as top performers for this assessment period.  To receive this rating employees must receive a rating of Exceeded Expectations in at least 7 elements and must not have received any ratings below Met Expectations.  "
            Width="629px"></asp:Label>
        <asp:Label ID="lblUseDefinitions" runat="server" Font-Bold="True" Font-Names="Arial"
            Font-Size="Small" Style="z-index: 105; left: 110px; position: absolute; top: 249px"
            Text="Please use the Definitions located at the end of this document to assist you in completing the following analysis"
            Width="711px"></asp:Label>
        <asp:GridView ID="DGQuestions" runat="server" AutoGenerateColumns="False" Style="z-index: 106;
            left: 29px; position: absolute; top: 449px" Width="897px" DataSourceID="Performance">
            <Columns>
                <asp:CommandField SelectText="Edit Comments" ShowSelectButton="True">
                    <ItemStyle Width="100px" />
                </asp:CommandField>
                <asp:BoundField DataField="IntReviewID" HeaderText="IntReviewID" SortExpression="IntReviewID"
                    Visible="False" />
                <asp:BoundField DataField="IntQuestionID" HeaderText="IntQuestionID" SortExpression="IntQuestionID"
                    Visible="False" />
                <asp:TemplateField HeaderText="Exceeds Expectations" SortExpression="blnResponse1">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("blnResponse1") %>' />
                    </EditItemTemplate>
                    <ItemStyle Width="10px" />
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("blnResponse1") %>'
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fully Meets Expectations" SortExpression="blnResponse2">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("blnResponse2") %>' />
                    </EditItemTemplate>
                    <ItemStyle Width="10px" />
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("blnResponse2") %>'
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Partially Meets Expectations" SortExpression="blnResponse3">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("blnResponse3") %>' />
                    </EditItemTemplate>
                    <ItemStyle Width="10px" />
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("blnResponse3") %>'
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fails to Meet Expectations" SortExpression="blnResponse4">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%# Bind("blnResponse4") %>' />
                    </EditItemTemplate>
                    <ItemStyle Width="10px" />
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%# Bind("blnResponse4") %>'
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="StrComments" HeaderText="Comments" SortExpression="StrComments">
                    <ItemStyle Width="200px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Performance" runat="server" ConnectionString="<%$ ConnectionStrings:local %>"
            SelectCommand="usp_RetrieveReviewQuestions" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtReviewID" Name="IntReviewID" PropertyName="Text"
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:TextBox ID="txtReviewID" runat="server" Style="z-index: 107; left: 34px; position: absolute;
            top: 252px" Width="59px" Visible="False"></asp:TextBox>
        <asp:Button ID="btnReturn" runat="server" Style="z-index: 108; left: 274px; position: absolute;
            top: 273px" Text="Return to Review" Width="171px" />
        <asp:TextBox ID="txtEmployeeID" runat="server" Style="z-index: 109; left: 33px; position: absolute;
            top: 281px" Width="61px" Visible="False"></asp:TextBox>
        &nbsp;
        <asp:TextBox ID="txtComments" runat="server" Height="85px" Style="z-index: 110; left: 137px;
            position: absolute; top: 349px" Visible="False" Width="639px"></asp:TextBox>
        <asp:Label ID="lblcomments" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"
            Style="z-index: 111; left: 142px; position: absolute; top: 315px" Text="List Specific Examples to Support This Rating.  Highlight Strengths and Note Opportunities and Methods for Improvement"
            Visible="False" Width="629px"></asp:Label>
        <asp:TextBox ID="txtQuestionID" runat="server" Style="z-index: 112; left: 36px; position: absolute;
            top: 220px" Width="59px" Visible="False"></asp:TextBox>
        <asp:Button ID="btnSaveComments" runat="server" Style="z-index: 113; left: 466px; position: absolute;
            top: 271px" Text="Save Comments" Width="171px" Visible="False" />
    
    </div>
    </form>
</body>
</html>
