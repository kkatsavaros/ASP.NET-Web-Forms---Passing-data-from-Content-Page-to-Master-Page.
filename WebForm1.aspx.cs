using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _46.MasterPages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // The master property returns Master Page Object and we explicity typecasting it to the actual master page

            // ((Site)Master).MyTextBoxOnMasterPage.Text = TextBox1.Text;  // TextBox1 είναι της WebForm1.
                        
            
            Master.MyTextBoxOnMasterPage.Text = TextBox1.Text;            


        }
    }
}