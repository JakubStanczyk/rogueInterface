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
            string printWidth = "";
            string printHeight = "";
            int height = heightOfRoom;
            int width = widthOfRoom;

            for(int i = 0; i <= width + 1; i++)
            {
                printWidth += "*";
            }
            Console.WriteLine(printWidth);

            if (height == 7)
            {
                printHeight = "*       *";
                for (int i = 0; i <= height; i++)
                { 
                    Console.WriteLine(printHeight);
                }
            }

            else if(height == 12)
            {
                printHeight = "*            *";
                for (int i = 0; i <= height; i++)
                {
                    Console.WriteLine(printHeight);
                }
            }

            else if(height == 17)
            {
                printHeight = "*                 *";
                for (int i = 0; i <= height; i++)
                {
                    Console.WriteLine(printHeight);
                }
            }
            Console.WriteLine(printWidth);
        }

      /*  public void selectRoom(string roomSize)
        {
            throw new NotImplementedException();
        }*/
    }
}