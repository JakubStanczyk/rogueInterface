using System;
using System.Collections.Generic;
using System.Text;

//The interface for the concrete object, that the Interceptor will intercept. We're doing it for Event generation and the Abstract Factory method
namespace RogueInterface.Generation
{
    public interface IBuildRequest
    {
        public int getNumberOfRooms();
        public int getDoorsAttachedToRooms();
        public int getHeightOfRoom();
        public int getGameLevel();
        public int getWidthOfRoom();
        public void setNumberOfRooms(int val);
        public void setDoorsAttachedToRooms(int val);
        public void setHeightOfRoom(int val);
        public void setGameLevel(int val);
        public void setWidthOfRoom(int val);
    }
}
