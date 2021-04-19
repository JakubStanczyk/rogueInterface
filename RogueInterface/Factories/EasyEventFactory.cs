using System;

namespace RogueInterface.Events
{
    public class EasyEventFactory : IEventFactory
    {
        public IEnemySpawnEvent CreateEnemySpawn()
        {
            return new EasyEnemySpawnEvent();
        }

        public ITrapSpawnEvent CreateTrapSpawn()
        {
            return new EasyTrapSpawnEvent();
        }
    }
}
