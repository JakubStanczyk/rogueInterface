using System;

namespace RogueInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MapBuilder map = new MapBuilder(0, null, 0, 0, 0, 0, 0);

            Console.WriteLine("How many rooms do you want to generate between 1 to 4 in level 1");
            int roomInput = Convert.ToInt32(Console.ReadLine());
            map.NumberOfRooms(roomInput);

            Console.WriteLine("What size of rooms do you want to be generated for levels 1 (small, medium, large)");
            string sizeOfRooms = Console.ReadLine();
            map.SizeOfRooms(sizeOfRooms);
            if (sizeOfRooms == "small")
            {
                map.DoorAttachedToRooms(2);
                map.HeightOfRoom(7);
                map.WidthOfRoom(7);
            }
            else if (sizeOfRooms == "medium")
            {
                map.DoorAttachedToRooms(3);
                map.HeightOfRoom(12);
                map.WidthOfRoom(12);
            }
            else
            {
                map.DoorAttachedToRooms(4);
                map.HeightOfRoom(17);
                map.WidthOfRoom(17);
            }
            map.GameLevel(1);
            map.buildRooms();

            int heightOfRoom = map.getHeightOfRoom();
            int widthOfRoom = map.getWidthOfRoom();

           // drawRoom(heightOfRoom, widthOfRoom);

            //commenting out for now the old implementation of main method, will be removed later
            /*for(int i = 0; i < 4;){
                if(i==0){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 1 - 10?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.NumberOfRooms(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 1 - 10? (small, medium, large) ");
                    string sizeOfRooms = Console.ReadLine();
                    map.SizeOfRooms(sizeOfRooms);
                    if(sizeOfRooms == "small"){
                        map.DoorAttachedToRooms(2);
                    }
                    else if(sizeOfRooms == "medium"){
                        map.DoorAttachedToRooms(3);
                    }
                     else
                    {
                        map.DoorAttachedToRooms(4);
                    }
                    map.RangeOfLevel("1- 10");
                    map.buildRooms();
                    i++;
                }

                else if(i==1){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 11 - 20?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.NumberOfRooms(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 11 - 20? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.SizeOfRooms(roomSize);
                    if(roomSize == "small"){
                        map.DoorAttachedToRooms(2);
                    }
                    else if(roomSize == "medium"){
                        map.DoorAttachedToRooms(3);
                    }
                    else
                    {
                         map.DoorAttachedToRooms(4);
                    }
                    map.RangeOfLevel("11 - 20");
                    map.buildRooms();
                    i++;
                }

                else if(i==2){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 21 - 30?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.NumberOfRooms(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 21 - 30? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.SizeOfRooms(roomSize);
                    if(roomSize == "small"){
                        map.DoorAttachedToRooms(2);
                    }
                    else if(roomSize == "medium"){
                     map.DoorAttachedToRooms(3);
                    }
                    else
                    {
                        map.DoorAttachedToRooms(4);
                    }
                    map.RangeOfLevel("21 - 30");
                    map.buildRooms();
                    i++;
                }

                else if(i==3){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 31 - 40?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.NumberOfRooms(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 31 - 40? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.SizeOfRooms(roomSize);
                    if(roomSize == "small"){
                        map.DoorAttachedToRooms(2);
                    }
                    else if(roomSize == "medium"){
                        map.DoorAttachedToRooms(3);
                    }
                    else
                    {
                        map.DoorAttachedToRooms(4);
                    }
                    map.RangeOfLevel("31 - 40");
                    map.buildRooms();
                    i++;
                }
            }*/
        }
    }
}
