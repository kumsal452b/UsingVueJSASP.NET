﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vue.DAL;
using Vue.Domain;

namespace UsingVueJSASP.NET.Controllers
{
    public class VueController : Controller
    {
        // GET: Vue
        UnitOfWork theWork;
        VueContext theContext;
        public VueController()
        {
            theContext = new VueContext();
            theWork = new UnitOfWork(theContext);
        }
        public ActionResult Index()
        {
            var getList = theWork.UserRepository.GetAll();
            return View(getList);
        }
      
        [HttpPost]
        public JsonResult GetUserList()
        {
            var getList = theWork.UserRepository.GetAll();
            return Json(getList, JsonRequestBehavior.AllowGet);
        }
  
        public ActionResult SignIn(int id)
        {
            return View(id);
        }
    }
}