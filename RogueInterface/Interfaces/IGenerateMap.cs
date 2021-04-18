
using System.Collections.Generic;
namespace RogueInterface.Generation

{
     interface IGenerateMap 
    {
        public List<List<int>> drawRoom(MapBuilder mapbuilder);
        //public void connectRoomWithCorridor();
    }
}
