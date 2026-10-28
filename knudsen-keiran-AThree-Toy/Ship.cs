using System;
using System.Collections.Generic;
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
            //Draw.Triangle()
            //draw trapezoid
            //masts, sails
            //black flag, with if for movement

        }

    }
}
