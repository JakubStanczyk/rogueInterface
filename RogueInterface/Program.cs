using RogueInterface.Command;
using RogueInterface.Events;
using RogueInterface.Generation;

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

    class ClientInterceptor : IBuildRequestInterceptor
    {
        public void onPostBuildRequest(IBuildRequest context)
        {
            Console.WriteLine(context.getNumberOfRooms() + " rooms created");
            Console.WriteLine(context.getDoorsAttachedToRooms() + " doors per room");
            Console.WriteLine("area = " + context.getWidthOfRoom() + " x " + context.getHeightOfRoom());
            Console.WriteLine("level = " + context.getGameLevel());
        }

        public void onPreBuildRequest(IBuildRequest context)
        {
            context.setNumberOfRooms(2);
            context.setDoorsAttachedToRooms(2);
            context.setWidthOfRoom(5);
            context.setHeightOfRoom(5);
            context.setGameLevel(1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClientInterceptor ci = new ClientInterceptor();
            MapBuilder mapB = new MapBuilder(0, 0, 0, 0, 0);
            mapB.registerBuildRequestInterceptor(ci);
            mapB.buildRooms();


            MapBuilder mapInformation = new MapBuilder(0, 0, 0, 0, 0);
            MapBuilder prototypeTest = new MapBuilder(1, 2, 3, 4, 5);
            MapBuilder prototypeTestClone = prototypeTest.createCopy();

            IEventFactory easyEvent1 = EventFactory.GetEasySpawn();
            IEventFactory easyEvent2 = EventFactory.GetEasySpawn();
            IEventFactory mediumEvent1 = EventFactory.GetMediumSpawn();
            IEventFactory mediumEvent2 = EventFactory.GetMediumSpawn();
            IEnemySpawnEvent enemySpawnEvent1 = easyEvent1.CreateEnemySpawn();
            IEnemySpawnEvent enemySpawnEvent2 = mediumEvent1.CreateEnemySpawn();
            ITrapSpawnEvent enemyTrapEvent1 = easyEvent2.CreateTrapSpawn();
            ITrapSpawnEvent enemyTrapEvent2 = mediumEvent2.CreateTrapSpawn();
            ModifyEnemyEvent orcEnemy = new ImplementModifyEnemyEvents(new RenameMonster());
            ModifyEnemyEvent goblinEnemy = new ImplementModifyEnemyEvents(new RenameMonster());
            ModifyTrapEvent pitfallTrap = new ImplementModifyTrapEvent(new RenameTraps());
            ModifyTrapEvent tripwireTrap = new ImplementModifyTrapEvent(new RenameTraps());
            enemySpawnEvent1.CreateEnemy();
            enemySpawnEvent2.CreateEnemy();
            enemyTrapEvent1.CreateTrap();
            enemyTrapEvent2.CreateTrap();


            Console.WriteLine(prototypeTestClone.getNumberOfRooms());
            BuildLevel buildItem = new BuildLevel();
            BuildLevel buildItemTwo = buildItem.createCopy();

            Console.WriteLine("How many rooms do you want to generate between 1 to 4 for level 1?");
            int roomInput = Convert.ToInt32(Console.ReadLine());
            mapInformation.NumberOfRooms(roomInput);

            Console.WriteLine("What size of rooms do you want to be generated for level 1? (small, medium, large)");
            string sizeOfRooms = Console.ReadLine();
            if (sizeOfRooms == "small")
            {
                mapInformation.DoorAttachedToRooms(2);
                mapInformation.HeightOfRoom(7);
                mapInformation.WidthOfRoom(7);

            }
            else if (sizeOfRooms == "medium")
            {
                mapInformation.DoorAttachedToRooms(3);
                mapInformation.HeightOfRoom(12);
                mapInformation.WidthOfRoom(12);
            }
            else
            {
                mapInformation.DoorAttachedToRooms(4);
                mapInformation.HeightOfRoom(17);
                mapInformation.WidthOfRoom(17);
            }
            mapInformation.GameLevel(1);
            mapInformation.buildRooms();
            Console.WriteLine("Level 1 will have " + mapInformation.getNumberOfRooms() + " rooms, with " + mapInformation.getDoorsAttachedToRooms() + "doors attached to them. The rooms dimenstions are " + mapInformation.getHeightOfRoom() + "units in height and " + mapInformation.getWidthOfRoom() + "units in width");
            
            buildItem.drawRoom(mapInformation.getHeightOfRoom(), mapInformation.getWidthOfRoom());

            Console.WriteLine("Should a easy enemy be a goblin?");
            string specifiedEnemyEvent1 = Console.ReadLine();
            if(specifiedEnemyEvent1 == "goblin")
            {
                goblinEnemy.renameToGoblin();
            }
            

            Console.WriteLine("Should a medium enemy be a orc?");
            string specifiedEnemy2 = Console.ReadLine();
            if(specifiedEnemy2 == "orc")
            {
                orcEnemy.renameToOrc();
            }

            Console.WriteLine("Shoul a easy trap be a trip wire");
            string specifiedTrap1 = Console.ReadLine();
            if(specifiedTrap1 == "trip wire")
            {
                tripwireTrap.renameToTripwire();
            }

            Console.WriteLine("Should a medium trap be a pit fall?");
            string specifiedTrap2 = Console.ReadLine();
            if (specifiedTrap2 == "pit fall")
            {
                pitfallTrap.renameToPitfall();
            }
        

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


            /*for (int i = 0; i < 4;){
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
            }
            */
        }
    }
}
