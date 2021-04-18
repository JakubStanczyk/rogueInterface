using System;
using System.Collections.Generic;
using System.Text;
using static SDL2.SDL;
using static SDL2.SDL_ttf;

namespace RogueInterface.Drawing
{
    public class Tile
    {
        private IntPtr texture;
        private SDL_Rect sourceRect;
        private int  width;
        private int height;

        public void Render(IntPtr renderer, int x, int y)
        {
            SDL_Rect rect = new SDL_Rect()
            {
                x = x,
                y = y,
                w = width,
                h = height
            };

            SDL_RenderCopy(renderer, texture, ref sourceRect, ref rect);
        }
        
        public static Tile createTile(String s, IntPtr renderer,IntPtr font,SDL_Color colour, int fontSize) 
        {
            Tile tile = new Tile();

            
            IntPtr textSurface = TTF_RenderText_Solid(font, s, colour);
            if (textSurface == null)
            {
                Console.WriteLine("Failed to render font surface");
                return null;
            }

            IntPtr texture = SDL_CreateTextureFromSurface(renderer, textSurface);
            if (texture == null)
            {
                Console.WriteLine("Failed to render surface to texture");
                return null;
            }
            
            SDL_FreeSurface(textSurface);
            tile.texture = texture;
            tile.width = fontSize + 2;
            tile.height = fontSize + 2; 
            tile.sourceRect = new SDL_Rect()
            {
                x = 0,
                y = 0,
                w = fontSize + 2,
                h = fontSize + 2,
            };
            


            return tile;
        }
    }
}
