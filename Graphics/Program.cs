using System;
using Raylib_cs;

namespace Graphics
{
  class Program
  {
    static void Main(string[] args)
    {

      Raylib.InitWindow(800, 600, "Test med TE19A");

      float x = 0;

      while (!Raylib.WindowShouldClose())
      {

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
          x += 0.1f;
        }
        


        Raylib.BeginDrawing();

        //Color myNewColor = new Color(124, 255, 12, 255);

        Raylib.ClearBackground(Color.WHITE);

        Raylib.DrawRectangle((int) x, 0, 30, 30, Color.PINK);

        

        Raylib.EndDrawing();
      }

    }
  }
}
