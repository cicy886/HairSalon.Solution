using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HairSalonContext _db;

        public ClientsController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Client> model = _db.Clients.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add (client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Client thisClient =
                _db.Clinets.FirstOrDefault(client => client.ClientId == id);
            return View(thisClient);
        }

        public ActionResult Edit(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
            return View(thisClient);
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            _db.Entry(client).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
