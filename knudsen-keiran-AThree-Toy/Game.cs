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
        Ship ship = new Ship();
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("The Kraken");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground("#bce9f7");
            ship.Update();

            Draw.SetFillColor("#5fb1b3");
            Draw.Rectangle(0, 450, 800, 150);

        }
    }

}
