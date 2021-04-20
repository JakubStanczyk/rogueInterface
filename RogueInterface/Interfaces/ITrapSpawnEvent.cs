using RogueInterface.Prototype;

namespace RogueInterface.Events
{
    public interface ITrapSpawnEvent:IPrototype<ITrapSpawnEvent>
    {
        public void CreateTrap();
        public string GetTrapName();
    }
}
