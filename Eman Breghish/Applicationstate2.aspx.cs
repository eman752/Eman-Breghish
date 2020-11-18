using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eman_Breghish
{
    public partial class Applicationstate2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["clicks"] == null)
                {
                    Application["clicks"] = 0;
                }
                TextBox1.Text = Application["clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = (int)Application["clicks"] + 1;
            TextBox1.Text = count.ToString();
            Application["clicks"] = count;
        }
    }
}