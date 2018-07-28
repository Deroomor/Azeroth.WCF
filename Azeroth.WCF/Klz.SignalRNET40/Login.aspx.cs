using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Klz.SignalRNET40
{
    public partial class Login : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            string op = this.Request["op"];
            if (op != "submit")
                return;
            string userName = this.Request["UserName"];
            this.Session["userInfo"] = userName;
            this.Response.Redirect("/Index.aspx");
        }
    }
}