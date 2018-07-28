using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Klz.SignalRNET40
{
    public partial class Index :PageKlz
    {
        protected override void OnLoad(EventArgs e)
        {
            string op = this.Request["op"];
            if (op != "msg")
                return;
            string msg = this.Request["msg"];
            var hubcontext= Microsoft.AspNet.SignalR.GlobalHost.ConnectionManager.GetHubContext<KlzHub>();
            var all= hubcontext.Clients.All;
            all.refresh(this.Session["userInfo"] as string,msg);
            this.Response.End();
        }
    }
}