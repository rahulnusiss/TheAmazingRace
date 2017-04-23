using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ACETreasureHunt.DAL;
using ACETreasureHunt.Models;
using System.Data.Entity.Validation;

namespace ACETreasureHunt.Controllers
{
    public class StaffController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new ACEContext());
        // GET: Staff
        public ActionResult Index()
        {
            IEnumerable<Staff> GameStaffs = unitOfWork.Staffs.GetAll();
            return View(GameStaffs);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            Staff staff = new Staff();
            return View(staff);
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            try
            {
                // TODO: Add insert logic here
                // TODO: Add insert logic here
                unitOfWork.Staffs.Add(staff);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                if (e.GetType() != typeof(DbEntityValidationException))
                {
                    if (this.HttpContext.IsDebuggingEnabled)
                    {
                        ModelState.AddModelError(string.Empty, e.ToString());
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Some technical error happened.");
                    }
                }
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
