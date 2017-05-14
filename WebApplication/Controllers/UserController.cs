using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.ViewModels;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Logon()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Logon(LogonViewModel pageData)
        {
            if (pageData.Email.Contains("skilltree") || pageData.Email.Contains("demo") || pageData.Email.Contains("twMVC") )
            {
                if (pageData.Email.Contains("skilltree"))
                {
                    ModelState.AddModelError("Email", "帳號不得包含skilltree的字串");
                }else if (pageData.Email.Contains("demo"))
                {
                    ModelState.AddModelError("Email", "帳號不得包含demo的字串");
                }
                else if (pageData.Email.Contains("twMVC"))
                {
                    ModelState.AddModelError("Email", "帳號不得包含twMVC的字串");
                }
                ViewData["alert"] = "alert-danger";
               
            }
            else
            {
                pageData.Message = $"您使用{pageData.Email}登入成功。";
                ViewData["alert"] = "alert-success";
            }
            return View(pageData);
        }
    }
}