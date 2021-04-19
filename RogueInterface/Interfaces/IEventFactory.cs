namespace RogueInterface.Events
{
    public interface IEventFactory
    {
        public IEnemySpawnEvent CreateEnemySpawn();
        public ITrapSpawnEvent CreateTrapSpawn();
    }
}
