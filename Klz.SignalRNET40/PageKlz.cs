using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klz.SignalRNET40
{
    public class PageKlz:System.Web.UI.Page
    {
        public override void ProcessRequest(HttpContext context)
        {
            if (context.Session["userInfo"] == null)
                context.Response.Redirect("/Login.aspx");
            base.ProcessRequest(context);
        }

        protected override void OnInit(EventArgs e)
        {
            
            //base.OnInit(e);
        }
    }
}