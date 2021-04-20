using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class MediumEventFactory : IEventFactory
    {
        public String EnemyName
        {
            get;
            private set;
        }

        public String TrapName
        {
            get;
            private set;
        }

        public MediumEventFactory() : this("Orc", "Bomb") { }
        public MediumEventFactory(String enemy, String trap)
        {
            EnemyName = enemy;
            TrapName = trap;
        }

        public IEnemySpawnEvent CreateEnemySpawn()
        {
            return new MediumEnemySpawnEvent();
        }

        public ITrapSpawnEvent CreateTrapSpawn()
        {
            return new MediumTrapSpawnEvent();
        }

        public string GetEnemyName()
        {
            return EnemyName;
        }

        public string GetTrapName()
        {
            return TrapName;
        }
    }
}
