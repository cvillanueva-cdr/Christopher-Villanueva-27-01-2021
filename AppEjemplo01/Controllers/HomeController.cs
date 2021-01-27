using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace AppEjemplo01
{
public class HomeController : AsyncController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        } 

    }
}