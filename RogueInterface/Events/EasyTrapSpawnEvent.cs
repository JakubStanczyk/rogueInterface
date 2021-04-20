using System;

namespace RogueInterface.Events
{
    public class EasyTrapSpawnEvent : ITrapSpawnEvent
    {
        public ITrapSpawnEvent createCopy()
        {
            return (EasyTrapSpawnEvent)MemberwiseClone();
        }

        void ITrapSpawnEvent.CreateTrap()
        {
            Console.WriteLine("a easy trap has been generated");
        }
    }
}
