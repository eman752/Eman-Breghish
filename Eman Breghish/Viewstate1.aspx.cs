using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eman_Breghish
{
    public partial class Viewstate1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["clicks"] == null)
                {
                    ViewState["clicks"] = 0;
                }
                TextBox1.Text = ViewState["clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = (int)ViewState["clicks"] + 1;
            TextBox1.Text = count.ToString();
            ViewState["clicks"] = count;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}