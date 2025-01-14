using Inventory_App.Models;
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

        public ActionResult ForgetPassword()
        {
            ViewBag.Message = "";
            return View("ForgetPassword");
        }

        [HttpPost]
        public ActionResult Login(string userNameText, string passwordText)
        {
            Session["UserName"] = "";
            string Message = "Unauthorized";

            BaseAccount baseAccount = new BaseAccount();
            if (baseAccount.VerifyUser(userNameText, passwordText))
            {
                Message = "Authorized";
                Session["UserName"] = userNameText; ; 
                return RedirectToAction("Dashboard", "Inventory");
            }
            ViewBag.Message = Message;
            return View("Login");
        }

        public ActionResult LogOut()
        {
            Session.Remove("UserName");
            return View("Login");
        }

        [HttpPost]
        public ActionResult ForgetPassword(string username, string newPassword, string confirmPassword)
        {
            string Message = "";

            if(newPassword != confirmPassword)
            {
                Message = "Password does not match";
            }
            else
            {
                BaseAccount baseAccount = new BaseAccount();
                if (baseAccount.ResetPassword(username, newPassword))
                {
                    Message = "Password reset succeeded";
                }
                else
                {
                    Message = "Password reset failed";
                }
            }
            ViewBag.Message = Message;
            return View();
        }
    }
}