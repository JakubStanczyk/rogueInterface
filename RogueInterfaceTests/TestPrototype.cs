using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RogueInterface.Generation;

namespace RogueInterfaceTests
{
     public class TestsPrototype
    {
        private MapBuilder mapBuilder;
       

        [SetUp]

        public void Setup()
        {
            mapBuilder = new MapBuilder(1, 1, 1, 1, 1);
            


        }
        [Test]
        public void TestPrototype()
        {
            Assert.AreEqual(mapBuilder, mapBuilder.createCopy());
           
        }
    }
}
