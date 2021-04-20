using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RogueInterface.Events;
using RogueInterface.Generation;

namespace RogueInterfaceTests
{
    public class TestsPrototype
    {
        private MapBuilder mapBuilder;

        IEventFactory easyEventFactory;
        IEventFactory mediumEventFactory;
        IEnemySpawnEvent easyEnemySpawnEvent;
        IEnemySpawnEvent mediumEnemySpawnEvent;
        ITrapSpawnEvent easyTrapSpawnEvent;
        ITrapSpawnEvent mediumTrapSpawnEvent;

        [SetUp]

        public void Setup()
        {
            mapBuilder = new MapBuilder(1, 1, 1, 1, 1);

            easyEventFactory = EventFactory.GetEasySpawn();
            mediumEventFactory = EventFactory.GetMediumSpawn();

            easyEnemySpawnEvent = easyEventFactory.CreateEnemySpawn();
            easyTrapSpawnEvent = easyEventFactory.CreateTrapSpawn();

            mediumEnemySpawnEvent = mediumEventFactory.CreateEnemySpawn();
            mediumTrapSpawnEvent = mediumEventFactory.CreateTrapSpawn();
        }
        [Test]
        public void TestPrototype()
        {
            Assert.AreEqual(mapBuilder, mapBuilder.createCopy());
        }

        [Test]
        public void TestAbstractFactoryClone()
        {
            IEnemySpawnEvent easyEnemyCopy = easyEnemySpawnEvent.createCopy();
            ITrapSpawnEvent easyTrapCopy = easyTrapSpawnEvent.createCopy();
            IEnemySpawnEvent mediumEnemyCopy = mediumEnemySpawnEvent.createCopy();
            ITrapSpawnEvent mediumTrapCopy = mediumTrapSpawnEvent.createCopy();

            Assert.AreEqual(easyEnemySpawnEvent.GetEnemyName(), easyEnemyCopy.GetEnemyName());
            Assert.AreEqual(easyTrapSpawnEvent.GetTrapName(), easyTrapCopy.GetTrapName());
            Assert.AreEqual(mediumEnemySpawnEvent.GetEnemyName(), mediumEnemyCopy.GetEnemyName());
            Assert.AreEqual(mediumTrapSpawnEvent.GetTrapName(), mediumTrapCopy.GetTrapName());
        }
    }
}
