using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klz.API
{
    [System.ServiceModel.ServiceContract]
    public interface IUserInfoAPI:ICrossDomainEnable
    {
       
        [System.ServiceModel.OperationContract]
        [System.ComponentModel.Description("新增员工信息")]
        UserInfo Add(UserInfo model);

        [System.ServiceModel.OperationContract]
        [System.ComponentModel.Description("获取所有员工信息")]
        List<UserInfo> GetList(UserInfo predicate);
    }
}
