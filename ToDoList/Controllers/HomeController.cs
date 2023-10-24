﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
       private TicketContext context;
            public HomeController(TicketContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.Statuses = context.Statuses.ToList();

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
        public IActionResult Filter (string filter)
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult MarkDone([FromRoute]string id, Ticket selected) 
        {
            selected = context.Tickets.Find(selected.TicketID)!;
            if (selected != null)
            {
                selected.StatusID = "done";
                context.SaveChanges();

            }
            return RedirectToAction("Index", new {ID = id});
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id)
        {
            var toDelete = context.Tickets
                .Where(t => t.StatusID == "done").ToList();

            foreach(var task in toDelete)
            {
                context.Tickets.Remove(task);
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult MarkInProgress([FromRoute] string id, Ticket selected)
        {
            selected = context.Tickets.Find(selected.TicketID)!;
            if (selected != null)
            {
                selected.StatusID = "inprogress";
                context.SaveChanges();
            }

            return RedirectToAction("Index", new { ID = id });
        }
        [HttpPost]
        public IActionResult MarkQA([FromRoute] string id, Ticket selected)
        {
            selected = context.Tickets.Find(selected.TicketID)!;
            if (selected != null)
            {
                selected.StatusID = "inprogress";
                context.SaveChanges();
            }

            return RedirectToAction("Index", new { ID = id });
        }

    }
}