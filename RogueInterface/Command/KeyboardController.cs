using System.Collections.Generic;

using SDL2;

namespace RogueInterface.Command
{
    public static class KeyboardController
    {
        private static List<IKeyboardCommand> _objects;

        public static bool ShouldQuit = false;

        public static void Init()
        {
            _objects = new List<IKeyboardCommand>(10);
        }

        public static void AddCommand(IKeyboardCommand command)
        {
            _objects.Add(command);
        }

        public static void RemoveCommand(IKeyboardCommand command)
        {
            _objects.Remove(command);
        }

        public static void PollKeyboardEvents()
        {
            List<SDL.SDL_Keycode> down = new List<SDL.SDL_Keycode>(10);
            List<SDL.SDL_Keycode> up = new List<SDL.SDL_Keycode>(10);
            SDL.SDL_Event e;
            while (SDL.SDL_PollEvent(out e) != 0)
            {
                switch (e.type)
                {
                    case SDL.SDL_EventType.SDL_KEYDOWN:
                        down.Add(e.key.keysym.sym);
                        break;
                    case SDL.SDL_EventType.SDL_KEYUP:
                        up.Add(e.key.keysym.sym);
                        break;
                    case SDL.SDL_EventType.SDL_QUIT:
                        ShouldQuit = true;
                        break;
                    default:
                        break;
                }
            }

            foreach (IKeyboardCommand obj in _objects)
            {
                foreach (SDL.SDL_Keycode k in down)
                {
                    obj.OnKey(KeyboardEventType.DOWN, k);
                }
                foreach (SDL.SDL_Keycode k in up)
                {
                    obj.OnKey(KeyboardEventType.UP, k);
                }
            }
        }
    }
}
