using System;

namespace RogueInterface.Events

{
    class EasyEnemySpawnEvent : IEnemySpawnEvent
    {
        void IEnemySpawnEvent.DoStuff()
        {
            Console.WriteLine("Easy Enemy Spawn");
        }
    }
}
