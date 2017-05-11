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
                pageData.Message = $"您使用{pageData.Email}登入失敗。(帳號不得包含skilltree、demo、twMVC等字串)";
            }
            else
            {
                pageData.Message = $"您使用{pageData.Email}登入成功。";
            }
            return View(pageData);
        }
    }
}