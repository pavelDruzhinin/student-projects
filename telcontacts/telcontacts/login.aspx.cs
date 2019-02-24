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
using System.Data.SqlClient;

namespace telcontacts
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nameUser"] != null)
            {
                string url = "Default.aspx";
                Response.Redirect(url);
            }
        }

        SqlConnection conn = null;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=JOKER\SQLEXPRESS;Initial Catalog=telCatalog;Integrated Security=True;Pooling=False";
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "prcLogin";
            string Login1Parameter = Convert.ToString(Login1.Text);
            string PasswordParameter = Convert.ToString(Password.Text);
            myCommand.Parameters.Add("@login", SqlDbType.NVarChar, 32);
            myCommand.Parameters["@login"].Value = Login1Parameter;
            myCommand.Parameters.Add("@password", SqlDbType.NVarChar,32);
            myCommand.Parameters["@password"].Value = PasswordParameter;
            myCommand.Parameters.Add("@nameUser", SqlDbType.NVarChar,64);
            myCommand.Parameters["@nameUser"].Direction = ParameterDirection.Output;
            myCommand.Parameters.Add("@nameGroup", SqlDbType.NVarChar, 64);
            myCommand.Parameters["@nameGroup"].Direction = ParameterDirection.Output;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            
            while (dataReader.Read())
            {
                string nameUser = dataReader.GetString(0);
                string login = dataReader.GetString(1);
                if (nameUser != "")
                {
                    Session["nameUser"] = nameUser;
                    Session["login"] =  login;
                }
            }
            dataReader.NextResult();
            while (dataReader.Read())
            {
                string nameGroup = dataReader.GetString(0);
                if (nameGroup != "")
                {
                    Session["nameGroup"] = nameGroup;
                    string url = "Default.aspx";
                    Response.Redirect(url);
                }
            }
            dataReader.Close();
            conn.Close();
        }
    }
}
