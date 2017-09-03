using ProcgEnemies.Models;
using ProcgEnemies.Service;
using System;
using System.Web.Mvc;

namespace ProcgEnemies.Controllers
{
    public class HomeController : Controller
    {
        AttributeService _service = new AttributeService();

        public ActionResult Index()
        {
            var rng = new Random();

            var enemy = new Enemy
            {
                Movement = _service.GetAttributeFrom(StaticData.MOVEMENT_ATTRS),
                Passive = _service.GetAttributeFrom(StaticData.MOVEMENT_ATTRS),
                Ability = _service.GetAttributeFrom(StaticData.MOVEMENT_ATTRS),
                Trigger = _service.GetAttributeFrom(StaticData.MOVEMENT_ATTRS),
            };

            return View(enemy);
        }
    }
}