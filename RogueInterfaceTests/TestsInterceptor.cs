using NUnit.Framework;

using RogueInterface.Drawing;
using RogueInterface.Generation;

namespace RogueInterfaceTests
{
    public class TestsInterceptor
    {
        private MapBuilder mapbuilder;
        private ClientInterceptor clientInterceptor;

        [SetUp]
        public void Setup()
        {
            mapbuilder = new MapBuilder(0, 0, 0, 0, 0);
            clientInterceptor = new ClientInterceptor();
            mapbuilder.registerBuildRequestInterceptor(clientInterceptor);
            mapbuilder.buildRooms();
        }

        [Test]
        public void TestInterceptor()
        {

            Assert.AreEqual(2, mapbuilder.getNumberOfRooms());
            Assert.AreEqual(2, mapbuilder.getDoorsAttachedToRooms());
            Assert.AreEqual(5, mapbuilder.getWidthOfRoom());
            Assert.AreEqual(5, mapbuilder.getHeightOfRoom());
            Assert.AreEqual(1, mapbuilder.getGameLevel());
        }
    }




    public class ClientInterceptor : IBuildRequestInterceptor
    {

        public void onPostBuildRequest(IBuildRequest context)
        {

        }

        public void onPreBuildRequest(IBuildRequest context)
        {
            context.setNumberOfRooms(2);
            context.setDoorsAttachedToRooms(2);
            context.setWidthOfRoom(5);
            context.setHeightOfRoom(5);
            context.setGameLevel(1);
        }

    }
}