<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnnualLeave.aspx.cs" Inherits="StaffManagement_AnnualLeave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #btnApply {
            height: 26px;
        }
    </style>
</head>
<body>
    <h1>Annual Leave</h1>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StaffID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="NextAnnualLeave" HeaderText="NextAnnualLeave" SortExpression="NextAnnualLeave" />
                    <asp:BoundField DataField="AnnualLeaveRemainingDays" HeaderText="AnnualLeaveRemainingDays" SortExpression="AnnualLeaveRemainingDays" />
                    <asp:BoundField DataField="StaffID" HeaderText="StaffID" InsertVisible="False" ReadOnly="True" SortExpression="StaffID" />
                    <asp:BoundField DataField="StaffFirstname" HeaderText="StaffFirstname" SortExpression="StaffFirstname" />
                    <asp:BoundField DataField="StaffLastname" HeaderText="StaffLastname" SortExpression="StaffLastname" />
                    <asp:BoundField DataField="StaffRole" HeaderText="StaffRole" SortExpression="StaffRole" />
                    <asp:BoundField DataField="StaffEmail" HeaderText="StaffEmail" SortExpression="StaffEmail" />
                </Columns>
            </asp:GridView>
           
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [tblStaffDetails] WHERE [StaffID] = @original_StaffID AND (([NextAnnualLeave] = @original_NextAnnualLeave) OR ([NextAnnualLeave] IS NULL AND @original_NextAnnualLeave IS NULL)) AND (([AnnualLeaveRemainingDays] = @original_AnnualLeaveRemainingDays) OR ([AnnualLeaveRemainingDays] IS NULL AND @original_AnnualLeaveRemainingDays IS NULL)) AND (([StaffFirstname] = @original_StaffFirstname) OR ([StaffFirstname] IS NULL AND @original_StaffFirstname IS NULL)) AND (([StaffLastname] = @original_StaffLastname) OR ([StaffLastname] IS NULL AND @original_StaffLastname IS NULL)) AND (([StaffRole] = @original_StaffRole) OR ([StaffRole] IS NULL AND @original_StaffRole IS NULL)) AND (([StaffEmail] = @original_StaffEmail) OR ([StaffEmail] IS NULL AND @original_StaffEmail IS NULL))" InsertCommand="INSERT INTO [tblStaffDetails] ([NextAnnualLeave], [AnnualLeaveRemainingDays], [StaffFirstname], [StaffLastname], [StaffRole], [StaffEmail]) VALUES (@NextAnnualLeave, @AnnualLeaveRemainingDays, @StaffFirstname, @StaffLastname, @StaffRole, @StaffEmail)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [NextAnnualLeave], [AnnualLeaveRemainingDays], [StaffID], [StaffFirstname], [StaffLastname], [StaffRole], [StaffEmail] FROM [tblStaffDetails] ORDER BY [NextAnnualLeave]" UpdateCommand="UPDATE [tblStaffDetails] SET [NextAnnualLeave] = @NextAnnualLeave, [AnnualLeaveRemainingDays] = @AnnualLeaveRemainingDays, [StaffFirstname] = @StaffFirstname, [StaffLastname] = @StaffLastname, [StaffRole] = @StaffRole, [StaffEmail] = @StaffEmail WHERE [StaffID] = @original_StaffID AND (([NextAnnualLeave] = @original_NextAnnualLeave) OR ([NextAnnualLeave] IS NULL AND @original_NextAnnualLeave IS NULL)) AND (([AnnualLeaveRemainingDays] = @original_AnnualLeaveRemainingDays) OR ([AnnualLeaveRemainingDays] IS NULL AND @original_AnnualLeaveRemainingDays IS NULL)) AND (([StaffFirstname] = @original_StaffFirstname) OR ([StaffFirstname] IS NULL AND @original_StaffFirstname IS NULL)) AND (([StaffLastname] = @original_StaffLastname) OR ([StaffLastname] IS NULL AND @original_StaffLastname IS NULL)) AND (([StaffRole] = @original_StaffRole) OR ([StaffRole] IS NULL AND @original_StaffRole IS NULL)) AND (([StaffEmail] = @original_StaffEmail) OR ([StaffEmail] IS NULL AND @original_StaffEmail IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_StaffID" Type="Int32" />
                    <asp:Parameter DbType="Date" Name="original_NextAnnualLeave" />
                    <asp:Parameter Name="original_AnnualLeaveRemainingDays" Type="Int32" />
                    <asp:Parameter Name="original_StaffFirstname" Type="String" />
                    <asp:Parameter Name="original_StaffLastname" Type="String" />
                    <asp:Parameter Name="original_StaffRole" Type="String" />
                    <asp:Parameter Name="original_StaffEmail" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter DbType="Date" Name="NextAnnualLeave" />
                    <asp:Parameter Name="AnnualLeaveRemainingDays" Type="Int32" />
                    <asp:Parameter Name="StaffFirstname" Type="String" />
                    <asp:Parameter Name="StaffLastname" Type="String" />
                    <asp:Parameter Name="StaffRole" Type="String" />
                    <asp:Parameter Name="StaffEmail" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter DbType="Date" Name="NextAnnualLeave" />
                    <asp:Parameter Name="AnnualLeaveRemainingDays" Type="Int32" />
                    <asp:Parameter Name="StaffFirstname" Type="String" />
                    <asp:Parameter Name="StaffLastname" Type="String" />
                    <asp:Parameter Name="StaffRole" Type="String" />
                    <asp:Parameter Name="StaffEmail" Type="String" />
                    <asp:Parameter Name="original_StaffID" Type="Int32" />
                    <asp:Parameter DbType="Date" Name="original_NextAnnualLeave" />
                    <asp:Parameter Name="original_AnnualLeaveRemainingDays" Type="Int32" />
                    <asp:Parameter Name="original_StaffFirstname" Type="String" />
                    <asp:Parameter Name="original_StaffLastname" Type="String" />
                    <asp:Parameter Name="original_StaffRole" Type="String" />
                    <asp:Parameter Name="original_StaffEmail" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        <h3>Staff ID</h3>           
        <input id="txtStaffID" type="text" />
        <h3>Duration of annual leave</h3><input id="txtNoDays" type="text" />
        <h3>Start of annual leave</h3><input id="txtStartDate" type="text" /><input id="btnApply" type="button" value="Apply" />
        </div>
    </form>
    
</body>
</html>
