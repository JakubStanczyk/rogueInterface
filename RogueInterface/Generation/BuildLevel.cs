using System;

namespace RogueInterface.Generation
{
    public class BuildLevel : IGenerateMap
    {
       /* public void connectRoomWithCorridor()
        {
            throw new NotImplementedException();
        } */

        public void drawRoom(int heightOfRoom, int widthOfRoom)
        {
            string printWidth = "|";
            string printHeight = "";
            int height = heightOfRoom;
            int width = widthOfRoom;

            for(int i = 0; i < width; i++)
            {
                printWidth = printWidth + "-";
            }
            Console.WriteLine(printWidth);

            printHeight = printHeight + "{0, width-1}" + "|";
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(printWidth);
        }

      /*  public void selectRoom(string roomSize)
        {
            throw new NotImplementedException();
        }*/
    }
}