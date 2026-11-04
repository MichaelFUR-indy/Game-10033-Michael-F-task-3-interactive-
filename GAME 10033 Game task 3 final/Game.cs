// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using static MohawkGame2D.Game;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Sun sun = new Sun();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //tiltle and size of game
            Window.SetTitle("sun task 3");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //background color (sky)
            Window.ClearBackground(new Color(0, 0, 255 - 255 * Input.GetMouseY() / 400));

            //reverses the background for moon when space bar is down
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
                Window.ClearBackground(new Color(0, 0, 255 * Input.GetMouseY() / 400));

           sun.Update();

            //turns into the moon when space bar down
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
                Draw.FillColor = Color.White;
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
                Draw.LineColor = Color.White;

            

            //the front hill the sun sets behind
            Draw.FillColor = Color.Green;
            Draw.LineSize = 4;
            Draw.LineColor = Color.Green;
            Draw.Circle(new Vector2(200, 650), 400);


        }


    }

}
