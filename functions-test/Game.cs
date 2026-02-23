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
            Window.SetTitle("Looking");
            Window.SetSize(800, 800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            DrawEyeball(250, 400);
            DrawEyeball(550, 400);
       
        }

        Color irisColor = new Color();
        void DrawEyeball(int x, int y)
        {
            // Draw eyeball
            Draw.LineSize = 2;                //1px outline
            Draw.LineColor = Color.OffWhite;     // Outline colour
            Draw.FillColor = Color.White;     // Cornea colour
            Draw.Circle(x, y, 100);           // Draw cornea
            Draw.FillColor = Color.Red;     // Pupil colour
            Draw.Circle(x, y, 45);            //Draw pupul
        }
    }
}

