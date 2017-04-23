using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ACETreasureHunt.Models;
using ACETreasureHunt.DAL;
using System.Data.Entity.Validation;

namespace ACETreasureHunt.Controllers
{
    public class EventController : Controller
    {

        IUnitOfWork unitOfWork = new UnitOfWork(new ACEContext());
        // GET: Event
        public ActionResult Index()
        {
            IEnumerable<Event> GameEvents = unitOfWork.Events.GetAllEvents();            
            return View(GameEvents);
        }

        // GET: Event/Details/5
        public ActionResult Details(Event aceEvent)
        {
            ViewBag.MyList = unitOfWork.Teams.GetAll();
            ViewBag.MyList2 = unitOfWork.Events.GetAll();
            //IEnumerable<Event> GameEvents = unitOfWork.Events.GetAllEvents();
            IEnumerable<Team> Teams = unitOfWork.Teams.GetAll();
            List<Team> ThisEventTeams = new List<Team>();
            foreach ( var item in Teams)
            {
                if ( aceEvent.Id == item.EventID)
                {
                    ThisEventTeams.Add(item);
                }
            }
            //Event GameEvent = unitOfWork.Events.Get(id);
            return View(ThisEventTeams);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            Event GameEvent = new Event();
            return View(GameEvent);
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(Event aceEvent)
        {
            try
            {
                // TODO: Add insert logic here
                unitOfWork.Events.Add(aceEvent);
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

        // GET: Event/Edit/5
        public ActionResult Edit(Event aceEvent)
        {
            Team EventTeam = new Team();            
            return View(EventTeam);
        }

        // POST: Event/Edit/5
        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Edit(Event ACEEvent,Team ACETeam)
        {
            try
            {
                // TODO: Add update logic here
                ACETeam.EventID = ACEEvent.Id;
                unitOfWork.Teams.Add(ACETeam);
                unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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
