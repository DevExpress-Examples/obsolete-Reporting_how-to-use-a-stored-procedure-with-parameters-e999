<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E999)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to use a stored procedure with parameters as a data source in a Web application


<p><strong>This approach is actual prior to version 14.1. Starting with version 14.1, use the approach illustrated in the <a href="https://www.devexpress.com/Support/Center/p/T227403">How to bind a report to a stored procedure provided by the SQL Data Source in an ASP.NET Web Forms application</a> </strong><strong>example.</strong></p>
<p><br />To allow passing a procedure parameter to an XtraReport descendant class (XtraReport1), it's updated with an argument which is used while populating the DataSet instance.<br /> On the web page, a DropDownList control is placed, which is populated with the list of parameters.<br /> In the example, the "CustOrdersOrders" stored procedure (Northwind database) with the "CustomerID" parameter is used, so the DropDownList contains every CustomerID from the Customers table.</p>
<p>Within the Page_Load event handler, the ReportViewer.Report property is updated using a newly created report instance.</p>

<br/>


