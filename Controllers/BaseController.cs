using CoreMVC.Models.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Controllers
{
    public class BaseController<T> : Controller
    {
        protected BLBase<T> bl;
        public BaseController()
        {
        }
    }
}

