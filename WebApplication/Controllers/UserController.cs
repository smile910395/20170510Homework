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
        public ActionResult Login(LogonViewModel pageData)
        {
            var status = "";
            if (pageData.Account == "skill" && pageData.Password == "tree")
            {
                pageData.Message = $"您使用{pageData.Account}登入成功。";
                status = "alert-success";
                //pageData.Status = $"alert-success";
            }
            else
            {
                pageData.Message = $"您使用{pageData.Account}登入失敗。";
                status = "alert-danger";
                //pageData.Status = $"alert-danger";
            }
            ViewData["Status"] = string.Format("<div class=\"alert {0} \">{1}</div>", status, pageData.Message);
            return View(pageData);
        }
    }
}