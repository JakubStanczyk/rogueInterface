using System;
using System.Collections.Generic;
using RogueInterface.Prototype;

namespace RogueInterface.Generation
{
    public class BuildLevel : IGenerateMap
    {
        public List<List<int>> drawRoom(MapBuilder mapbuilder)
        {
            List<List<int>> lists = new List<List<int>>();

            int width = mapbuilder.getWidthOfRoom();
            int height = mapbuilder.getHeightOfRoom();

            for (int i = 0; i < height; i++)
            {
                List<int> list = new List<int>();
                
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        list.Add(0);
                    }
                    else
                    {
                        if (j == 0 || j == width - 1)
                        {
                            list.Add(0);
                        }
                        else
                        {
                            list.Add(1);
                        }
                    }
                }
                lists.Add(list);
            }

            return lists;
        }
     
      
        public List<List<int>> connectRoomWithCorridor(List<List<int>> room1, List<List<int>> room2, int room2Y, int spaceBetweenRooms)
        {
            int room1Width = room1[0].Count;
            int room1Height = room1.Count;

            int room2Width = room2[0].Count;
            int room2Height = room2.Count;

            int newRoomWidth = room1Width + room2Width + spaceBetweenRooms;
            int newRoomHeight = Math.Max(room1Height, room2Height + room2Y);

            List<List<int>> map = new List<List<int>>(newRoomHeight);

            for (int y = 0; y < newRoomHeight; y++)
            {
                List<int> row = new List<int>(newRoomWidth);
                for (int x = 0; x < newRoomWidth; x++)
                {
                    if (x < room1Width && y < room1Height)
                    {
                        row.Add(room1[y][x]);
                    }
                    else if (x < room1Width + spaceBetweenRooms)
                    {
                        row.Add(-1);
                    }
                    else if (x >= room1Width + spaceBetweenRooms && y >= room2Y)
                    {
                        row.Add(room2[y - room2Y][x - room1Width - spaceBetweenRooms]);
                    }
                }
                map.Add(row);
            }

            int room1DoorX = room1Width - 1;
            int room1DoorY = room1Height / 2;
            int room2DoorX = room1Width + spaceBetweenRooms;
            int room2DoorY = room2Y + (room2Height / 2);

            map[room1DoorY][room1DoorX] = 1;
            map[room2DoorY][room2DoorX] = 1;

            for (int i = room1DoorX; i < room1DoorX + (spaceBetweenRooms / 2) + 1; i++)
            {
                map[room1DoorY][i] = 1;
            }

            for (int i = room2DoorX - (spaceBetweenRooms / 2); i < room2DoorX; i++)
            {
                map[room2DoorY][i] = 1;
            }

            int middle = newRoomWidth / 2;
            for (int i = room1DoorY; i < room2DoorY + 1; i++)
            {
                map[i][middle] = 1;
            }

            return map;
        }
    }

      /*  public void selectRoom(string roomSize)
        {
            throw new NotImplementedException();
        }*/
    }
