using SDL2;

namespace RogueInterface.Command
{
    public enum KeyboardEventType
    {
        UP,
        DOWN
    }

    public interface IKeyboardCommand
	{
		void OnKey(KeyboardEventType type, SDL.SDL_Keycode keycode);
	}
}