using System;

namespace RogueInterface.Events
{
    class EasyEventFactory : IEventFactory
    {
        IEnemySpawnEvent IEventFactory.CreateEnemySpawn()
        {
            return new EasyEnemySpawnEvent();
        }

        ITrapSpawnEvent IEventFactory.CreateTrapSpawn()
        {
            return new EasyTrapSpawnEvent();
        }
    }
}
