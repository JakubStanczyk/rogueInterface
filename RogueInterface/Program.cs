using RogueInterface.Command;
using RogueInterface.Events;

using System;

using SDL2;


namespace RogueInterface
{
    class ExampleCommand : IKeyboardCommand
    {
        public void OnKey(KeyboardEventType type, SDL.SDL_Keycode keycode)
        {
            switch (type)
            {
                case KeyboardEventType.UP:
                    Console.WriteLine("Key up: " + keycode.ToString());
                    break;
                case KeyboardEventType.DOWN:
                    Console.WriteLine("Key down: " + keycode.ToString());
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING) != 0)
            {
                Console.WriteLine("Failed to start SDL");
                return;
            }

            IntPtr window = SDL.SDL_CreateWindow("Rogue Interface", 100, 100, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            if (window == null)
            {
                Console.WriteLine("Failed to create window");
                return;
            }

            bool quit = false;

            ExampleCommand command = new ExampleCommand();

            KeyboardController.Init();
            KeyboardController.AddCommand(command);

            while (!KeyboardController.ShouldQuit)
            {
                KeyboardController.PollKeyboardEvents();
            }

            SDL.SDL_DestroyWindow(window);
            SDL.SDL_Quit();

            /*
            MapBuilder map = new MapBuilder(0, null, 0, null);
            IEventFactory eve = EventFactory.GetEasySpawn();
            IEnemySpawnEvent enemySpawnEvent = eve.CreateEnemySpawn();
            enemySpawnEvent.DoStuff();


            for (int i = 0; i < 4;){
                if(i==0){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 1 - 10?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.RoomNumber(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 1 - 10? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.RoomSize(roomSize);
                    if(roomSize == "small"){
                        map.DoorNumber(2);
                    }
                    else if(roomSize == "medium"){
                        map.DoorNumber(3);
                    }
                     else
                    {
                        map.DoorNumber(4);
                    }
                    map.LevelRange("1- 10");
                    map.buildRooms();
                    i++;
                }

                else if(i==1){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 11 - 20?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.RoomNumber(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 11 - 20? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.RoomSize(roomSize);
                    if(roomSize == "small"){
                        map.DoorNumber(2);
                    }
                    else if(roomSize == "medium"){
                        map.DoorNumber(3);
                    }
                    else
                    {
                         map.DoorNumber(4);
                    }
                    map.LevelRange("11 - 20");
                    map.buildRooms();
                    i++;
                }

                else if(i==2){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 21 - 30?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.RoomNumber(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 21 - 30? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.RoomSize(roomSize);
                    if(roomSize == "small"){
                        map.DoorNumber(2);
                    }
                    else if(roomSize == "medium"){
                     map.DoorNumber(3);
                    }
                    else
                    {
                        map.DoorNumber(4);
                    }
                    map.LevelRange("21 - 30");
                    map.buildRooms();
                    i++;
                }

                else if(i==3){
                    Console.WriteLine("How many rooms do you want to generate between 1 to 5? for levels 31 - 40?");
                    int roomInput = Convert.ToInt32(Console.ReadLine());
                    map.RoomNumber(roomInput);

                    Console.WriteLine("What size of rooms do you want to be generated for levels 31 - 40? (small, medium, large) ");
                    string roomSize = Console.ReadLine();
                    map.RoomSize(roomSize);
                    if(roomSize == "small"){
                        map.DoorNumber(2);
                    }
                    else if(roomSize == "medium"){
                        map.DoorNumber(3);
                    }
                    else
                    {
                        map.DoorNumber(4);
                    }
                    map.LevelRange("31 - 40");
                    map.buildRooms();
                    i++;
                }
            }
            */
        }
    }
}
