// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Ship ship = new Ship();
        Cannon cannon = new Cannon();
        Kraken kraken = new Kraken();
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

            

            cannon.Update();
            

            ship.Update();

            kraken.Update();
            

            Draw.SetFillColor("#5fb1b3");
            Draw.Rectangle(0, 450, 800, 150);

            Draw.SetFillColor(Color.White);
            for (int i = 0; i < 5; i++)
            {

                
                int x = i * 220;
                Draw.Ellipse(x, 50, 80, 40);
                Draw.Ellipse(x + 40, 30, 80, 60);
                Draw.Ellipse(x + 60, 50, 110, 60);

            }

            //for clouds - maybe move them idk thats not priority. keep em here I think

            //call cannon - with if keypress
            //cannon before ship.
            //call kraken first or last dont think it matters. - with if key blink




        }
    }

}
