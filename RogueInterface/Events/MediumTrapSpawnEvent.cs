using System;

namespace RogueInterface.Events
{
    public class MediumTrapSpawnEvent : ITrapSpawnEvent
    {
        public ITrapSpawnEvent createCopy()
        {
            return (MediumTrapSpawnEvent)MemberwiseClone();
        }

        public void CreateTrap()
        {
            Console.WriteLine("A medium trap has been generated");
        }
    }
}
