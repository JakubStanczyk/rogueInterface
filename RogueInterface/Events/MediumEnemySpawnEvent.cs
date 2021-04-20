using System;

namespace RogueInterface.Events
{
    public class MediumEnemySpawnEvent : IEnemySpawnEvent
    {
        public IEnemySpawnEvent createCopy()
        {
            return (MediumEnemySpawnEvent)MemberwiseClone();
        }

        public void CreateEnemy()
        {
            Console.WriteLine("A medium difficulty enemy has been generated");
        }
    }
}
