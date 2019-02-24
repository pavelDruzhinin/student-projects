using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace telcontacts
{
    public partial class editusers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nameUser"] == null)
            {
                string url = "login.aspx";
                Response.Redirect(url);
            }
            else
            {
                lblNameUser.Text = Convert.ToString(Session["nameUser"]);
                lblNameGroup.Text = Convert.ToString(Session["nameGroup"]);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            string url = "login.aspx";
            Response.Redirect(url);
        }
        protected void btnViewUsers_Click(object sender, EventArgs e)
        {
            string url = "Default.aspx";
            Response.Redirect(url);
        }
    }
}
