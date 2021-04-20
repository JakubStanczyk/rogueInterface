using System;

namespace RogueInterface.Events
{
    public class EasyEnemySpawnEvent : IEnemySpawnEvent
    {
        public String Name
        {
            get;
            private set;
        }

        public EasyEnemySpawnEvent() : this("Goblin") { }
        public EasyEnemySpawnEvent(String enemy)
        {
            Name = enemy;
        }

        public IEnemySpawnEvent createCopy()
        {
            return (EasyEnemySpawnEvent)MemberwiseClone();
        }

        public string GetEnemyName()
        {
            return Name;
        }

        void IEnemySpawnEvent.CreateEnemy()
        {
            Console.WriteLine("a easy enemy has been generated");
        }
    }
}
