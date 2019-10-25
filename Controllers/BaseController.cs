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

        #region Views
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            var entities = bl.GetAll();
            return View(entities);
        }

        public IActionResult View(int id)
        {
            var entity = bl.GetByID(id);
            return View(entity);
        }

        public IActionResult Edit(int id)
        {
            var entity = bl.GetByID(id);
            return View(entity);
        }

        #endregion

        #region Functions
        // Thực hiện sửa
        [HttpPost]
        public IActionResult Edit(int id, T entity)
        {
            var success = bl.Update(id, entity);
            if (success)
            {
                return RedirectToAction("List");
            }
            return View("Edit", entity);
        }

        // Thực hiện Xóa
        public IActionResult Delete(int id)
        {
            var success = bl.Delete(id);
            if (success > 0)
            {
                return RedirectToAction("List");
            }
            return View("List");
        }
        #endregion


    }
}

