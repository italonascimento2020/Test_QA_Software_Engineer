using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wex_QA_Test_API.Models;
using Wex_QA_Test_API.Services;

namespace Wex_QA_Test_API.Controllers
{
    public class WexProjectController : ApiController
    {
        WexProjectService service = new WexProjectService();

        public List<WexProjectModel> Get()
        {
            return service.MockList();
        }
    }
}
