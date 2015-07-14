using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClient.MyServiceReference;

namespace MyClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyServiceClient svcClient = new MyServiceClient();

            DropDownList1.DataSource = svcClient.GetAllCountries();
            DropDownList1.DataValueField = "CountryId";
            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataBind();

        }
    }
}