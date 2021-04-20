using System;

namespace RogueInterface.Events
{
    public class EasyEnemySpawnEvent : IEnemySpawnEvent
    {
        public IEnemySpawnEvent createCopy()
        {
            return (EasyEnemySpawnEvent)MemberwiseClone();
        }
        void IEnemySpawnEvent.CreateEnemy()
        {
            Console.WriteLine("a easy enemy has been generated");
        }
    }
}
