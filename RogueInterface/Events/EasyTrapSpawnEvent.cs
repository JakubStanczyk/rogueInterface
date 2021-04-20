using System;

namespace RogueInterface.Events
{
    public class EasyTrapSpawnEvent : ITrapSpawnEvent
    {
        public String Name
        {
            get;
            private set;
        }

        public EasyTrapSpawnEvent() : this("Tripwire") { }
        public EasyTrapSpawnEvent(String trap)
        {
            Name = trap;
        }

        public ITrapSpawnEvent createCopy()
        {
            return (EasyTrapSpawnEvent)MemberwiseClone();
        }

        void ITrapSpawnEvent.CreateTrap()
        {
            Console.WriteLine("a easy trap has been generated");
        }

        public string GetTrapName()
        {
            return Name;
        }
    }
}
