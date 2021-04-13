using System;

namespace RogueInterface.Events
{
    class EasyTrapSpawnEvent : ITrapSpawnEvent
    {
        void ITrapSpawnEvent.CreateTrap()
        {
            Console.WriteLine("a easy trap has been generated");
        }
    }
}
