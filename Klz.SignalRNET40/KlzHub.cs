﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klz.SignalRNET40
{
    public class KlzHub:Microsoft.AspNet.SignalR.Hub
    {
        public override System.Threading.Tasks.Task OnConnected()
        {
            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnDisconnected()
        {
            return base.OnDisconnected();
        }
    }
}