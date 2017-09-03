using ProcgEnemies.Models;
using System;

namespace ProcgEnemies.Service
{
    public class AttributeService
    {
        private Random _rng;

        public AttributeService()
        {
            _rng = new Random();
        }

        public EnemyAttribute GetAttributeFrom(EnemyAttribute[] attributes)
        {
            return RandomChoice(attributes);
        }

        private EnemyAttribute RandomChoice(EnemyAttribute[] list)
        {
            var count = list.Length;
            var index = _rng.Next(count);

            return list[index];
        }
    }
}