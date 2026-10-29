using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Cannon
    {

        public void Setup()
        {

        }

        public void Update()
        {
            Draw.SetFillColor("#1e1f1f");
            Draw.Rectangle(340, 420, 40, 15);

            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {
                Draw.SetFillColor("#1e1f1f");
                Draw.Circle(30, 30, 60);

            }

        }

        
    }
}