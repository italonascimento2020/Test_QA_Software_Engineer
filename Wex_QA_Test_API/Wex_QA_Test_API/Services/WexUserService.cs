using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wex_QA_Test_API.Models;

namespace Wex_QA_Test_API.Services
{
    public class WexUserService
    {
        public WexUserService()
        {

        }

        public List<WexUserModel> MockList()
        {
            List<WexUserModel> _wexUserModels = new List<WexUserModel>();

            WexUserModel wexUser = new WexUserModel{ Codigo = 1, Login = "Joao2020", Nome="João"};

            _wexUserModels.Add(wexUser);

            wexUser = new WexUserModel { Codigo = 2, Login = "Maria2020", Nome = "Maria" };

            _wexUserModels.Add(wexUser);

            return _wexUserModels;
        }
    }
}