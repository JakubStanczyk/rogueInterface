using System;

namespace RogueInterface.Events
{
    class EasyTrapSpawnEvent : ITrapSpawnEvent
    {
        void ITrapSpawnEvent.DoStuff()
        {
            Console.WriteLine("Easy Trap Spawn");
        }
    }
}
