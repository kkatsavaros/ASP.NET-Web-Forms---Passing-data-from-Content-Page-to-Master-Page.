using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;   // Data Object Provider.
using System.Configuration;    // Για σύνδεση με το Web.config.
using System.Data;             // Για το CommandType, DataSet
using System.Web.Security;     // Για το Hash Password.


namespace _46.MasterPages
{
    public partial class WebForm3 : System.Web.UI.Page

    {

        protected void Page_Init(object sender, EventArgs e)
        {
            Master.MySearchbutton.Click += new EventHandler(SearchButton_Click);
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            GetData(Master.MySearchTerm);
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData(null);
            }
        }

        private void GetData(string searchTerm)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spSearch";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter searchParameter = new SqlParameter("@SearchTerm", searchTerm ?? string.Empty);
                cmd.Parameters.Add(searchParameter);

                con.Open();

                GridView1.DataSource = cmd.ExecuteReader();

                //GridView1.DataTextField = "UserName";
                //GridView1.DataValueField = "Email";

                GridView1.DataBind();
            }
        }

    }
}