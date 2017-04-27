using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ACETreasureHunt.DAL;
using ACETreasureHunt.Models;
using System.Data.Entity.Validation;

namespace ACETreasureHunt.Controllers
{
    public class PitStopController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new ACEContext());

        // GET: PitStop
        public ActionResult Index()
        {
            IEnumerable<PitStop> EventPitStops = unitOfWork.PitStops.GetAll();
            return View(EventPitStops);
        }

        // GET: PitStop/Create
        public ActionResult Create()
        {
            IEnumerable<Event> List = unitOfWork.Events.GetAll();
            ViewBag.EventID = new SelectList(List, "Id", "Name");
            PitStop pitstop = new PitStop();
            return View(pitstop);
        }

        // POST: PitStop/Create
        [HttpPost]
        public ActionResult Create(PitStop pitstop)
        {
            try
            {
                unitOfWork.PitStops.Add(pitstop);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            catch (Exception e)
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

        // GET: PitStop/Edit/5
        public ActionResult Edit(PitStop acePitStop)
        {
            IEnumerable<Event> List = unitOfWork.Events.GetAll();
            ViewBag.EventID = new SelectList(List, "Id", "Name");
            PitStop EventPitStop = unitOfWork.PitStops.Get(acePitStop.Id);
            return View(EventPitStop);
        }

        // POST: PitStop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PitStop acePitStop)
        {
            try
            {
                // TODO: Add update logic here
                PitStop pitstop = unitOfWork.PitStops.Get(acePitStop.Id);
                UpdateModel(pitstop);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            catch (Exception e)
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

        // GET: PitStop/Delete/5
        public ActionResult Delete(PitStop acePitStop)
        {
            PitStop EventPitStop = unitOfWork.PitStops.Get(acePitStop.Id);
            return View(EventPitStop);
        }

        // POST: PitStop/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id, PitStop acePitStop)
        {
            try
            {
                PitStop pitstop = unitOfWork.PitStops.Get(acePitStop.Id);
                unitOfWork.PitStops.Remove(pitstop);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            catch (Exception e)
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
    }
}

