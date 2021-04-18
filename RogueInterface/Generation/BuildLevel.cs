using System;
using RogueInterface.Prototype;

namespace RogueInterface.Generation
{
    public class BuildLevel : IGenerateMap, IPrototype<BuildLevel>
    {
        /* public void connectRoomWithCorridor()
         {
             throw new NotImplementedException();
         } */

        public string[,] drawRoom(int heightOfRoom, int widthOfRoom)
        {
            return null;
        }
        public BuildLevel createClone() {

            return null;
        }
        
        public BuildLevel createCopy() 
        {

            return null;
        
        }

    }

      /*  public void selectRoom(string roomSize)
        {
            throw new NotImplementedException();
        }*/
    }
