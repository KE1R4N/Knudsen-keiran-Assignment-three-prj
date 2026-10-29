using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Ship
    {

        public void Setup()
        {

        }

        public void Update()
        {
            //Draw hull
            Draw.SetLineSize(0);
            Draw.SetFillColor("#7a6548");
            Draw.Ellipse(200, 400, 300, 200);
            //Shape hull
            Draw.SetFillColor("#bce9f7");
            Draw.Rectangle(120, 400, 170, 10);
            Draw.Rectangle(0, 0, 800, 400);
            //Bow, Stern
            Draw.SetFillColor("#7a6548");
            Draw.Triangle(390, 390, 340, 435, 320, 405);
            Draw.Quad(50, 380, 120, 390, 120, 410, 50, 400);
            Draw.Circle(80, 450, 20);


            Draw.SetFillColor("#1e1f1f");
            for (int i = 0; i < 4; i++)
            {
                
                int x = i * 40;
                Draw.Circle(new Vector2(x, 430), 5); 
                
            }

            //Masts, sails
            //black flag, with if for movement

        }

    }
}
