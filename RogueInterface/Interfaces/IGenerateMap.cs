
using System.Collections.Generic;
namespace RogueInterface.Generation

{
     interface IGenerateMap 
    {
        public List<List<int>> drawRoom(MapBuilder mapbuilder);
        public List<List<int>> connectRoomWithCorridor(List<List<int>> room1, List<List<int>> room2, int room2Y, int spaceBetweenRooms);
    }
}
