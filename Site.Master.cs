using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _46.MasterPages
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox MyTextBoxOnMasterPage
        {
            get
            {
                return this.txtOnMasterPage; // Είναι το id του TextBox στην Master Page.
            }
        }

        // Η property MySearchPanel επίστρέφει έναν αντικείμενο "Panel".
        public Panel MySearchPanel
        {
            get
            {
                return this.panelSearch;
            }
        }

        //2.
        public Button MySearchbutton
        {
            get
            {
                return this.btnSearch;
            }
        }

        //3.
        public String MySearchTerm
        {
            get
            {
                return this.txtSearch.Text;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}