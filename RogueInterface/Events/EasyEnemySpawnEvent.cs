using System;

namespace RogueInterface
{
    class EasyEnemySpawnEvent : IEnemySpawnEvent
    {
        void IEnemySpawnEvent.DoStuff()
        {
            Console.WriteLine("Easy Enemy Spawn");
        }
    }
}
