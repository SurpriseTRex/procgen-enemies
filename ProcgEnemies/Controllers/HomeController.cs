using ProcgEnemies.Models;
using System;
using System.Collections;
using System.Web.Mvc;

namespace ProcgEnemies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var rng = new Random();

            var enemy = new Enemy
            {
                Movement = RandomChoice(StaticData.MOVEMENT_ATTRS, rng),
                Passive = RandomChoice(StaticData.PASSIVE_ATTRS, rng),
                Ability = RandomChoice(StaticData.ABILITY_ATTRS, rng),
                Trigger = RandomChoice(StaticData.TRIGGER_ATTRS, rng)
            };

            return View(enemy);
        }

        private EnemyAttribute RandomChoice(EnemyAttribute[] list, Random rng)
        {
            var count = list.Length;
            var index = rng.Next(count);

            return list[index];
        }
    }

    public class Enemy
    {
        public EnemyAttribute Movement { get; set; }

        public EnemyAttribute Passive { get; set; }

        public EnemyAttribute Ability { get; set; }

        public EnemyAttribute Trigger { get; set; }
    }

    public class EnemyAttribute
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Examples { get; set; }
    }
}