<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.1.Web, Version=13.1.14.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>

		<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
			DataSourceID="SqlDataSource1" DataTextField="ContactName" 
			DataValueField="CustomerID" >
		</asp:DropDownList>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
			ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
			SelectCommand="SELECT [CustomerID], [ContactName] FROM Customers">
		</asp:SqlDataSource>
		<dxxr:ReportViewer ID="ReportViewer1" runat="server">
		</dxxr:ReportViewer>

	</div>
	</form>
</body>
</html>
