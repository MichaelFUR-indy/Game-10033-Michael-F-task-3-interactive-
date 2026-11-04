// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("loop circles");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            Draw.FillColor = new Color("#9ab1d6");

            for (int i = 0; i < 10; i++)
            {
                int x = i * 40;

                Draw.Circle(new Vector2(x, Window.Height / 2.0f), 10f);

                

            }
        }
    }

}
