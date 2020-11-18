using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eman_Breghish
{
    public partial class Cookie_state_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //عم خزنها بمتحول كمان من نوع كوكي  UserInfo اللي اسمها cookie  عم قلو استقبل البيانات من ال 
            HttpCookie cookie =Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                TextBox1.Text = cookie["Name"];
                TextBox2.Text = cookie["Email"];
            }


        }
    }
}