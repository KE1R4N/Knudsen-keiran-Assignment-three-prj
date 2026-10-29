using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Kraken
    {


        public void Setup()
        {

        }

        public void Update()
        {

            DrawKraken();

            if (Input.IsKeyboardKeyDown(KeyboardKey.B))
            {
                Draw.SetFillColor("#1b362b");
                Draw.Circle(580, 410, 20);
                Draw.Circle(660, 410, 20);

                Draw.SetFillColor(Color.Black);
                Draw.Rectangle(640, 410, 40, 10);
                Draw.Rectangle(560, 410, 40, 10);
            }

        }


        public void DrawKraken()
        {
            Draw.SetFillColor("#1b362b");
            Draw.Circle(630, 440, 100);

            Draw.SetFillColor("#eddfa1");
            Draw.Circle(580, 410, 20);
            Draw.Circle(660, 410, 20);

            Draw.SetFillColor(Color.Black);
            Draw.Circle(575, 410, 10);
            Draw.Circle(655, 410, 10);

            Draw.SetFillColor("#1b362b");
            Draw.Rectangle(560, 380, 150, 20);
        }
    }
}
