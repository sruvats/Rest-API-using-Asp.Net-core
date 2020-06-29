using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace webapi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public void onclickme()
        {
            DownloadHTML("https://en.wikipedia.org/wiki/Main_Page");
        }
        public async Task DownloadHTML(string url)
        {
            var webclient = new System.Net.WebClient();
            var html= await webclient.DownloadStringTaskAsync(url);
            

            using (var streamwriter=new StreamWriter("C://Users//sruth//source//repos//webapi//async.txt"))
            {
            //  streamwriter.WriteLine(html);
                MessageBox.Show(html);
            }
                
        }
    }
}
