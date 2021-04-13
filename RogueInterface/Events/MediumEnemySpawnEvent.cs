using System;

namespace RogueInterface.Events
{
    class MediumEnemySpawnEvent : IEnemySpawnEvent
    {
        void IEnemySpawnEvent.CreateEnemy()
        {
            Console.WriteLine("A medium difficulty enemy has been generated");

        }
    }
}
