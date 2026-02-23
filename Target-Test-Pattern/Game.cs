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
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Target Pattern");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            Draw.FillColor = Color.Red;
            for (int count = 0; count < 10; count ++)
            {
                bool isEven = count % 2 == 0;
                if (isEven == true)
                    Draw.FillColor = Color.Red;
                else Draw.FillColor = Color.White;

                
                float radius = 150 * (10 - count) / 10f;
                Draw.Circle(200, 200, radius);
            }
        }
    }

}
