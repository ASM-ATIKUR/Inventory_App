using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Inventory_App.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userNameText, string passwordText)
        {
            string Message = "Unauthorized";
            if(userNameText == "Ost@abc.com" && passwordText == "123")
            {
                return RedirectToAction("Dashboard", "Inventory");
            }
            ViewBag.Message = Message;
            return View();
        }
    }
}