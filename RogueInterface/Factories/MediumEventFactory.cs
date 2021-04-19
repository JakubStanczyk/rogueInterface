using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class MediumEventFactory : IEventFactory
    {
        public IEnemySpawnEvent CreateEnemySpawn()
        {
            return new MediumEnemySpawnEvent();
        }

        public ITrapSpawnEvent CreateTrapSpawn()
        {
            return new MediumTrapSpawnEvent();
        }
    }
}
