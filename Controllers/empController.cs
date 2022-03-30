using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myAPI.Controllers
{
    public class empController : ApiController
    {
      [HttpGet]
      public List<string>getemp()
        {
            List<string> obj = new List<string>()
            {


                "akshay saini",
                "ashi saini",
                "saini sarkar"


            };
            return obj;
        }

        [HttpPost]
        public List<string>save()
        {
            List<string> sobj = new List<string>();
            return sobj;
        }
    }
}