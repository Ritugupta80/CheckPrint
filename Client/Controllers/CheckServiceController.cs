using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class CheckServiceController : Controller
    {
        // GET: CheckService
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult UpdateResults(double id)
        {
            ConvertoWords.ConvertNumberToWordsClient service = new ConvertoWords.ConvertNumberToWordsClient();
            string result=service.ConvertToWords(id);
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}