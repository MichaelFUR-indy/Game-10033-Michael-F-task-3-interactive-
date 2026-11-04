using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Sun
    {
        float y;
        float speed = 50;
        public void Setup()
        { 
            
        }

        public void Update()
        {

            //sun that follows the mouse 
            y += Time.DeltaTime * speed;
            Draw.FillColor = Color.Yellow;
            Draw.LineSize = 4;
            Draw.LineColor = Color.Yellow;

            //gets mouse postion for sun and moon
            Draw.Circle(200, y, 50);
        }
        
        //comment//
    }
}
