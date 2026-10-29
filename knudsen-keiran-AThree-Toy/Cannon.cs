using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Cannon
    {
        float x = 370;
        float speed = 0;
        public void Setup()
        {

        }

        public void Update()
        {
            Draw.SetFillColor("#1e1f1f");
            Draw.Rectangle(340, 420, 40, 15);

            if (Input.IsKeyboardKeyPressed(KeyboardKey.Space) == true)
            {
                speed = 40;

            }

            x += Time.DeltaTime * speed;

            Draw.SetFillColor("#1e1f1f");
            Draw.Circle(x, 428, 6);

            

        }

        
    }
}