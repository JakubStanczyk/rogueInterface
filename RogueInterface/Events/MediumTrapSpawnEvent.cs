using System;

namespace RogueInterface.Events
{
    class MediumTrapSpawnEvent : ITrapSpawnEvent
    {
        void ITrapSpawnEvent.DoStuff()
        {
            Console.WriteLine("Medium Trap Spawn");
        }
    }
}
