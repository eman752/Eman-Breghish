using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eman_Breghish
{
    public partial class Session_state2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["clicks"] == null)
                {
                    Session["clicks"] = 0;
                }
                TextBox1.Text = Session["clicks"].ToString();
            }
        }

       
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        
        {
            int count = (int)Session["clicks"] + 1;
            TextBox1.Text = count.ToString();
            Session["clicks"] = count;
        }
    }
}