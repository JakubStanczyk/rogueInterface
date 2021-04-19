using System;

namespace RogueInterface.Events
{
    public class MediumTrapSpawnEvent : ITrapSpawnEvent
    {
        public void CreateTrap()
        {
            Console.WriteLine("A medium trap has been generated");
        }
    }
}
