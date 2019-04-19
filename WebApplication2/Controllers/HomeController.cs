using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formFields)

        {

            string Fieldvalue1 = formFields.Get("Description");
            char[] charArray = Fieldvalue1.ToCharArray();
            Array.Reverse(charArray);


            var reversedWords = string.Join(" ", Fieldvalue1.Split(' ').Select(x => new String(x.Reverse().ToArray())).ToArray());

            ViewData["reversedString"] = new string(charArray);
            ViewData["reversedWords"] = reversedWords;
            return View();

        }


    }
}