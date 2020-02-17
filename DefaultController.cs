using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserData.Entity;
using Respository.respository;


namespace MyApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        UserRespository userRespository;
       
        public  DefaultController()
        {
             userRespository = new UserRespository();
        }
        public ActionResult Index()
        {
            IEnumerable<UsersData>  usersData = userRespository.GetUserDetails();
            ViewData["UserDetails"] = usersData;
            ViewBag.User = usersData;
            TempData["Users"] = usersData;
           //return View();
           return RedirectToAction("GetUsers");
            
        }
        
        public ActionResult GetUsers()
        {
            //usersData = userRespository.GetUserDetails();

            ////IEnumerable<UsersData> usersData = userRespository.GetUserDetails();
            //ViewData["UserDetails"] = usersData;
            //ViewBag.User = usersData;


            //TempData["Users"] = usersData;
            return View();
        }
        
    }
}