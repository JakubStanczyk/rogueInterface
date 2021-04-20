using RogueInterface.Prototype;

namespace RogueInterface.Events
{

    public interface IEnemySpawnEvent : IPrototype<IEnemySpawnEvent>
    {
        public void CreateEnemy();
        
    }
}
