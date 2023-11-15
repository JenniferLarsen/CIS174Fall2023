﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ToDoList.Models;
using ToDoList.Repository;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private TicketContext context;
        private ILogger<HomeController> object1;
        private ITicketRepository<Ticket> object2;

        public HomeController(ILogger<HomeController> @object, TicketContext ctx) => context = ctx;

        public HomeController(ILogger<HomeController> object1, ITicketRepository<Ticket> object2)
        {
            this.object1 = object1;
            this.object2 = object2;
        }

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            //ViewBag.Statuses = context.Statuses.ToList(); // Remove this line

            IQueryable<Ticket> query = context.Tickets
                .Include(t => t.Status);
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusID == filters.StatusID);
            }
            var tasks = query.OrderBy(t => t.StatusID).ToList();
            return View(tasks);
        }


        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Statuses = context.Statuses.ToList();
            var task = new Ticket { StatusID = "todo" };
            return View(task);

        }
        [HttpPost]
        public IActionResult Add(Ticket task)
        {
            if (ModelState.IsValid)
            {
                context.Tickets.Add(task);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Statuses = context.Statuses.ToList();
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Filter(string filter)
        {
            // Redirect to the Index action with the selected filter
            return RedirectToAction("Index", new { id = filter });
        }
        [HttpPost]
        public IActionResult MarkDone([FromRoute] string id, Ticket selected)
        {
            selected = context.Tickets.Find(selected.TicketID)!;
            if (selected != null)
            {
                selected.StatusID = "done";
                context.SaveChanges();

            }
            return RedirectToAction("Index", new { ID = id });
        }


        [HttpPost]
        public IActionResult MarkInProgress([FromRoute] string id, int TicketID)
        {
            var selected = context.Tickets.Find(TicketID);
            if (selected != null)
            {
                selected.StatusID = "inprogress";
                context.SaveChanges();
            }

            return RedirectToAction("Index", new { id });
        }

        [HttpPost]
        public IActionResult MarkQA([FromRoute] string id, int TicketID)
        {
            var selected = context.Tickets.Find(TicketID);
            if (selected != null)
            {
                selected.StatusID = "qa";
                context.SaveChanges();
            }

            return RedirectToAction("Index", new { id });
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id)
        {
            var toDelete = context.Tickets
                .Where(t => t.StatusID == "done").ToList();

            foreach (var task in toDelete)
            {
                context.Tickets.Remove(task);
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}