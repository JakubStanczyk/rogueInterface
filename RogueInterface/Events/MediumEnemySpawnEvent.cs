using System;

namespace RogueInterface.Events
{
    public class MediumEnemySpawnEvent : IEnemySpawnEvent
    {
        public void CreateEnemy()
        {
            Console.WriteLine("A medium difficulty enemy has been generated");
        }
    }
}
