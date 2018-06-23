using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelasRegionales.Models;
using System.Data.SqlClient;
using System.Data.Entity;

namespace TelasRegionales.Controllers
{
    public class PortfolioController : Controller
    {

       // private TelasSurEntities db = new TelasSurEntities();

        public ActionResult Index()
        {
            using (var db = new TelasSurEntities())
            {
                var telas = db.Telas.Include(x => x.TipoTela).ToList();
                return View(telas);
            }
        }

    }
}