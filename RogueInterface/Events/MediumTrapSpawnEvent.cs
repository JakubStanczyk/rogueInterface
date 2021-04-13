using System;

namespace RogueInterface.Events
{
    class MediumTrapSpawnEvent : ITrapSpawnEvent
    {

        void ITrapSpawnEvent.CreateTrap()
        {
            Console.WriteLine("A medium trap has been generated");
        }


    }
}
