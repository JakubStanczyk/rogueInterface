using System;

namespace RogueInterface.Events

{
    class EasyEnemySpawnEvent : IEnemySpawnEvent
    {
        void IEnemySpawnEvent.CreateEnemy()
        {
            Console.WriteLine("a easy enemy has been generated");
        }
    }
}
