using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eman_Breghish
{
    public partial class page1 : System.Web.UI.Page
    {
        static string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    TextBox2.Text = null;
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            str =TextBox2.Text = TextBox1.Text;
                
                TextBox1.Text = null ;
        }
    }
}