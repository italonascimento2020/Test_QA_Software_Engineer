using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wex_QA_Test_API.Models;

namespace Wex_QA_Test_API.Services
{
    public class WexProjectService
    {
        public WexProjectService()
        {

        }

        public List<WexProjectModel> MockList()
        {
            List<WexProjectModel> _wexProjectModels = new List<WexProjectModel>();

            WexProjectModel wexProject = new WexProjectModel { Codigo = 1, DescricaoProjeto = "Project 1", DataInicio = DateTime.Now };

            _wexProjectModels.Add(wexProject);

            wexProject = new WexProjectModel { Codigo = 2, DescricaoProjeto = "Project 2", DataInicio = DateTime.Now.AddDays(2) };

            _wexProjectModels.Add(wexProject);

            return _wexProjectModels;
        }
    }
}