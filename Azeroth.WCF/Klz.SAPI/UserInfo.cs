using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Klz.SAPI.Model;

namespace Klz.SAPI
{
    public class UserInfo : IUserInfo
    {
        public Model.UserInfo Add(Model.UserInfo model)
        {
            return model;
        }

        public List<Model.UserInfo> GetList(Model.UserInfo predicate)
        {
            return new List<Model.UserInfo>() { predicate };
        }
    }
}
