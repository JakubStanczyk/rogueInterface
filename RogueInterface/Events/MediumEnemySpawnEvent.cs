using System;

namespace RogueInterface.Events
{
    public class MediumEnemySpawnEvent : IEnemySpawnEvent
    {
        public String Name
        {
            get;
            private set;
        }

        public MediumEnemySpawnEvent() : this("Orc") { }
        public MediumEnemySpawnEvent(String enemy)
        {
            Name = enemy;
        }
        public IEnemySpawnEvent createCopy()
        {
            return (MediumEnemySpawnEvent)MemberwiseClone();
        }

        public void CreateEnemy()
        {
            Console.WriteLine("A medium difficulty enemy has been generated");
        }

        public string GetEnemyName()
        {
            return Name;
        }
    }
}
