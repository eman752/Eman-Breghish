using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eman_Breghish
{
    public partial class Cookie_state_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {    // cookie سنستخدم الكلاس الخاص بال 
             //  Name مررتلو باراميتر كاسم لإني عم اتعامل هون مع ال 
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = txtname.Text;
            cookie["Email"] = txtEmail.Text;
            //       value  وعبيت ال  key  هيك أخدت ال  
            // هون رح تتخزن البيانات داخل جهاز العميل 
            Response.Cookies.Add(cookie); // التخزين 
            Response.Redirect("~/Cookie state 2.aspx");
            // هون عملت تحويل مباشر للصفحة التانية

        }
    }
}