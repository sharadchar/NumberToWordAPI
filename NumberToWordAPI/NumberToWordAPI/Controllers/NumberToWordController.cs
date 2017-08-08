using NumberToWordLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberToWordAPI.Controllers
{
    public class NumberToWordController : Controller
    {
        //
        // GET: /NumberToWord/

        public ActionResult Index()
        {
            return View();
        }
        public string GetNumberToWord(double number)
        {
            return NumberToWordConvertor.ConvertNumberToWord(number);            
        }

    }
}
