using System;

namespace RogueInterface.Events
{
    public class MediumTrapSpawnEvent : ITrapSpawnEvent
    {
        public String Name
        {
            get;
            private set;
        }

        public MediumTrapSpawnEvent() : this("Bomb") { }
        public MediumTrapSpawnEvent(String trap)
        {
            Name = trap;
        }

        public ITrapSpawnEvent createCopy()
        {
            return (MediumTrapSpawnEvent)MemberwiseClone();
        }

        public void CreateTrap()
        {
            Console.WriteLine("A medium trap has been generated");
        }

        public string GetTrapName()
        {
            return Name;
        }
    }
}
