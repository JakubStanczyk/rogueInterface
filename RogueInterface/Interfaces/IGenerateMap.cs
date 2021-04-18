

namespace RogueInterface.Generation

{
    interface IGenerateMap 
    {
        public string[,] drawRoom(int heightOfRoom, int widthOfRoom);
        //public void connectRoomWithCorridor();
    }
}
