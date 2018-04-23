using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{

    string customerID = "ALFKI"; //a default value

    protected void Page_Load(object sender, EventArgs e) {

        if (this.DropDownList1.SelectedValue != string.Empty)
            customerID = this.DropDownList1.SelectedValue;
        XtraReport1 myReport = new XtraReport1(customerID);
        this.ReportViewer1.Report = myReport;
    }
    
}
