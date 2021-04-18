using RogueInterface.Command;
using RogueInterface.Events;
using RogueInterface.Generation;
using RogueInterface.Drawing;

using System;
using System.Collections.Generic;

using SDL2;
using static SDL2.SDL;
using static SDL2.SDL_ttf;

namespace RogueInterface
{
    class ExampleCommand : IKeyboardCommand
    {
        public void OnKey(KeyboardEventType type, SDL_Keycode keycode)
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
            /*
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
            */
            int wallIndex = 0;
            int floorIndex = 1;
            int playerIndex = 2;
            String[] arr =
            {
                "#", ".", "@"
            };
            List<String> tileChars = new List<String>(arr);
            ExampleCommand command = new ExampleCommand();

            KeyboardController.Init();
            KeyboardController.AddCommand(command);

            // ####################################################
            // Setup SDL
            if (SDL_Init(SDL.SDL_INIT_EVERYTHING) != 0)
            {
                Console.WriteLine("Failed to start SDL");
                return;
            }

            IntPtr window = SDL_CreateWindow("Rogue Interface", 100, 100, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            if (window == null)
            {
                Console.WriteLine("Failed to create window");
                return;
            }

            // #####################################################
            // Create renderer
            IntPtr renderer = SDL_CreateRenderer(window, -1, SDL_RendererFlags.SDL_RENDERER_ACCELERATED | SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
            if (renderer == null)
            {
                Console.WriteLine("Failed to create renderer");
                return;
            }

            SDL_SetRenderDrawColor(renderer, 0x0, 0x0, 0x0, 0xFF);

            // ####################################################
            // Set up TTF
            if (TTF_Init() == -1)
            {
                Console.WriteLine("Failed to init TTF module");
                return;
            }

            SDL_Color textColour = new SDL_Color();
            textColour.r = 255;
            textColour.g = 255;
            textColour.b = 255;
            
            IntPtr font = TTF_OpenFont("sansserif.ttf", 20);
            if (font == null)
            {
                Console.WriteLine("Failed to create font");
                return;
            }

            IntPtr textSurface = TTF_RenderText_Solid(font, "I hate this module", textColour);
            if (textSurface == null)
            {
                Console.WriteLine("Failed to render font surface");
                return;
            }

            IntPtr texture = SDL_CreateTextureFromSurface(renderer, textSurface);
            if (texture == null)
            {
                Console.WriteLine("Failed to render surface to texture");
                return;
            }

            int width = 18 * 20;
            int height = 22;

            SDL_FreeSurface(textSurface);

            SDL_Rect sourceRect = new SDL_Rect()
            {
                x = 0,
                y = 0,
                w = width,
                h = height
            };

            SDL_Rect renderQuad = new SDL_Rect();
            renderQuad.x = 10;
            renderQuad.y = 10;
            renderQuad.w = width;
            renderQuad.h = height;

            List<Tile> tiles = new List<Tile>();

            foreach (var s in tileChars)
            {
                tiles.Add(Tile.createTile(s, renderer, font, textColour, 20));
            }

            int[,] map =
            {
                { 0, 0, 0, 0, 0 },
                { 0, 1, 2, 1, 0 },
                { 0, 1, 1, 1, 0 },
                { 0, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0 }
            };

            while (!KeyboardController.ShouldQuit)
            {
                KeyboardController.PollKeyboardEvents();

                SDL_RenderClear(renderer);

                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        tiles[map[y,x]].Render(renderer, x * 30, y * 30);
                    }
                }

                SDL_RenderPresent(renderer);
            }

            TTF_CloseFont(font);
            SDL_DestroyRenderer(renderer);
            SDL_DestroyWindow(window);
            TTF_Quit();
            SDL_Quit();
        }
    }
}
