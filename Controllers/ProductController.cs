﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Models.BL;
using CoreMVC.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ProductController : BaseController<Product>
    {
        public ProductController()
        {
            bl = new BLProduct();
        }
    }
}