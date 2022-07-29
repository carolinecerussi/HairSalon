using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController: Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Stylist>model = _db.Stylists.ToList();
      ViewBag.PageTitle = "View All Stylists";
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Stylist";
      //^potentially put on homecontroller page ?//
      return View();
    }
    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Stylist stylistFound = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(stylistFound);
    }
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      //poss also for stylist name?//
    }
    
  }
}