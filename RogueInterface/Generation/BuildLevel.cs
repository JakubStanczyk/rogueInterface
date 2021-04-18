using System;
using System.Collections.Generic;
using RogueInterface.Prototype;

namespace RogueInterface.Generation
{
    public class BuildLevel : IGenerateMap, IPrototype<BuildLevel>
    {
        /* public void connectRoomWithCorridor()
         {
             throw new NotImplementedException();
         } */

        public List<List<int>> drawRoom(MapBuilder mapbuilder)
        {

            List<List<int>> lists = new List<List<int>>();
            

            for (int i = 0; i < mapbuilder.getHeightOfRoom(); i++)
            {
                List<int> list = new List<int>();
                
                for (int j = 0; j < mapbuilder.getWidthOfRoom(); j++)
                {
                    list.Add(0);
                }
                lists.Add(list);
            }
           



            return lists;
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
