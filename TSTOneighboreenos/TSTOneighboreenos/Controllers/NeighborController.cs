using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSTOneighboreenos.DAL;
using TSTOneighboreenos.Models;

namespace TSTOneighboreenos.Controllers
{
    public class NeighborController : Controller
    {
        private NeighboreenoContext db = new NeighboreenoContext();

        // GET: Neighbor
        public ActionResult Index()
        {
            return View(db.Neighbors.ToList());
        }
    }
}