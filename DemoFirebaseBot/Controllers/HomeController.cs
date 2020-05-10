using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

namespace DemoFirebaseBot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //get the page
            var web = new HtmlWeb();
            var document = web.Load("https://vnexpress.net/kinh-doanh");
            var page = document.DocumentNode;

            //loop through all div tags with item css class
            foreach (var item in page.QuerySelectorAll("h3.title-news>a"))
            {
                var url = item.GetAttributeValue("href", "");
                Debug.WriteLine(url);
                // var date = DateTime.Parse(item.QuerySelector("span:eq(2)").InnerText);
                // var description = item.QuerySelector("span:has(b)").InnerHtml;
            }

            return View();
        }

        public ActionResult About()
        {
            //get the page
            var web = new HtmlWeb();
            var document = web.Load("https://vnexpress.net/sap-co-lan-song-dich-chuyen-san-xuat-tu-trung-quoc-sang-viet-nam-4096772.html");
            var page = document.DocumentNode;

            var title = page.QuerySelector("div.sidebar-1>h1.title-detail").InnerText;
            var description = page.QuerySelector("div.sidebar-1>p.description").InnerText;
            var paragraphs = page.QuerySelectorAll("article.fck_detail>p.Normal");
            Debug.WriteLine(title);
            Debug.WriteLine(description);

            // selector => <p>
            // selector => <img>
            // html text

            // <p class="sdsadds">
            var abc = "";
            
            foreach (var p in paragraphs)
            {
                
            }

            //loop through all div tags with item css class
            // foreach (var item in page.QuerySelectorAll("h3.title-news>a"))
            // {
            //     var url = item.GetAttributeValue("href", "");
            //     Debug.WriteLine(url);
            //     var date = DateTime.Parse(item.QuerySelector("span:eq(2)").InnerText);
            //     var description = item.QuerySelector("span:has(b)").InnerHtml;
            // }
        
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