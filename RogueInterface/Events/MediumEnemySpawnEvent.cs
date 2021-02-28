using System;

namespace RogueInterface.Events
{
    class MediumEnemySpawnEvent : IEnemySpawnEvent
    {
        void IEnemySpawnEvent.DoStuff()
        {
            Console.WriteLine("Medium Enemy Spawn");
        }
    }
}
