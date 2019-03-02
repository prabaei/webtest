using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace webtest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://app.avlview.com/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apiKey", "39H2ELVEhYT4AJJwjSen");
            HttpResponseMessage response = client.GetAsync("api/getvehicletypes").Result;
            
            if (response.IsSuccessStatusCode)
            {
                var jsonresultString = response.Content.ReadAsStringAsync().Result;
                Models.JsonModel.vehicletypes tmp = JsonConvert.DeserializeObject<Models.JsonModel.vehicletypes>(jsonresultString);

                //var yourcustomobjects = response.Content.ReadAsAsync<IEnumerable<YourCustomObject>>().Result;
                //foreach (var x in yourcustomobjects)
                //{
                //    //Call your store method and pass in your own object
                //    SaveCustomObjectToDB(x);
                //}
            }
            else
            {
                //Something has gone wrong, handle it here
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}