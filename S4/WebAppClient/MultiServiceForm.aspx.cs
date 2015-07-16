using System;
using WebAppClient.MultiServiceReference;

namespace WebAppClient
{
    public partial class MultiServiceForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallSvc_Click(object sender, EventArgs e)
        {
            MultiSvcClient msc = new MultiSvcClient("BasicHttpBinding_IMultiSvc");

            lblRes.Text = msc.Mul(5, 5).ToString();

        }
    }
}