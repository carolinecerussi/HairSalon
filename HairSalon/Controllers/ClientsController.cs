
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext  _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      ViewBag.PageTitle = "View All Clients";
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.StylistId=  new SelectList(_db.Stylists, "StylistId","Name","DateHired" );
      return View();
    }
    [HttpPost]
    public ActionResult Create (Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Client clientFound = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.Stylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == clientFound.StylistId);
      return View(clientFound);
    }
    public ActionResult Edit(int id)
    {
Client clientFound = _db.Clients.FirstOrDefault(client => client.ClientId == id );
ViewBag.StylistId = new SelectList (_db.Stylists, "StylistId", "Name");
return View(clientFound);
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
    