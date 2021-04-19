using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

using RogueInterface.Events;

namespace RogueInterfaceTests
{
    class TestAbstractFactory
    {
        IEventFactory easyEventFactory;
        IEventFactory mediumEventFactory;
        IEnemySpawnEvent easyEnemySpawnEvent;
        IEnemySpawnEvent mediumEnemySpawnEvent;
        ITrapSpawnEvent easyTrapSpawnEvent;
        ITrapSpawnEvent mediumTrapSpawnEvent;

        [SetUp]
        public void Setup()
        {
            easyEventFactory = EventFactory.GetEasySpawn();
            mediumEventFactory = EventFactory.GetMediumSpawn();

            easyEnemySpawnEvent = easyEventFactory.CreateEnemySpawn();
            easyTrapSpawnEvent = easyEventFactory.CreateTrapSpawn();

            mediumEnemySpawnEvent = mediumEventFactory.CreateEnemySpawn();
            mediumTrapSpawnEvent = mediumEventFactory.CreateTrapSpawn();
        }

        [Test]
        public void TestEasySpawn()
        {
            Assert.IsInstanceOf(typeof(IEventFactory), easyEventFactory);
            Assert.IsInstanceOf(typeof(EasyEventFactory), easyEventFactory);
            Assert.IsInstanceOf(typeof(IEnemySpawnEvent), easyEnemySpawnEvent);
            Assert.IsInstanceOf(typeof(EasyEnemySpawnEvent), easyEnemySpawnEvent);
            Assert.IsInstanceOf(typeof(ITrapSpawnEvent), easyTrapSpawnEvent);
            Assert.IsInstanceOf(typeof(EasyTrapSpawnEvent), easyTrapSpawnEvent);
        }

        [Test]
        public void TestMediumSpawn()
        {
            Assert.IsInstanceOf(typeof(IEventFactory), mediumEventFactory);
            Assert.IsInstanceOf(typeof(MediumEventFactory), mediumEventFactory);
            Assert.IsInstanceOf(typeof(IEnemySpawnEvent), mediumEnemySpawnEvent);
            Assert.IsInstanceOf(typeof(MediumEnemySpawnEvent), mediumEnemySpawnEvent);
            Assert.IsInstanceOf(typeof(ITrapSpawnEvent), mediumTrapSpawnEvent);
            Assert.IsInstanceOf(typeof(MediumTrapSpawnEvent), mediumTrapSpawnEvent);
        }
    }
}
