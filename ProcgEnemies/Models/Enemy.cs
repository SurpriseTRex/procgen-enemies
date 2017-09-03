using ProcgEnemies.Controllers;

namespace ProcgEnemies.Models
{
    public class Enemy
    {
        public EnemyAttribute Movement { get; set; }

        public EnemyAttribute Passive { get; set; }

        public EnemyAttribute Ability { get; set; }

        public EnemyAttribute Trigger { get; set; }
    }
}