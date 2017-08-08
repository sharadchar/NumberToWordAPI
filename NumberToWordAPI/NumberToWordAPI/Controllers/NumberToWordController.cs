using NumberToWordLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NumberToWordAPI.Controllers
{
    public class NumberToWordController : ApiController
    {
        //
        // GET: /NumberToWord/

        public string GetNumberToWord(double number)
        {
            return NumberToWordConvertor.ConvertNumberToWord(number);            
        }

    }
}
