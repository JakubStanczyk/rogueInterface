namespace RogueInterface.Events
{
    interface IEventFactory
    {
        IEnemySpawnEvent CreateEnemySpawn();
        ITrapSpawnEvent CreateTrapSpawn();
    }
}
