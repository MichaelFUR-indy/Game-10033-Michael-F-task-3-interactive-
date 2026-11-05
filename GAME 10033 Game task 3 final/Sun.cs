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

            //sun// 
            y += Time.DeltaTime * speed;
            Draw.FillColor = Color.Yellow;
            Draw.LineSize = 4;
            Draw.LineColor = Color.Yellow;

            //start postion for sun and moon//
            Draw.Circle(250, y, 50);

            float sunY = 400 - Input.GetMouseY();

           



        }
        
        //comment//
    }
}
