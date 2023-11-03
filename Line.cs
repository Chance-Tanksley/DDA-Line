using DDA;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDA_Line
{
    class Line
    {
        //FIELDS
        private Point _p0;
        private Point _p1;
        private double slope = 0;
        private Point midPoint = new Point();
        //end fields

        //PROPERTIES
        public double Slope
        {
            get 
            {
                double dx = _p1.X - _p0.X;
                double dy = _p1.Y - _p0.Y;
                slope = dy / dx; 
                return slope; 
            }
        }
        public Point Midpoint
        {
            get
            {
                
                midPoint.X = (_p0.X + _p1.X) / 2;
                midPoint.Y = (_p0.Y + _p1.Y) / 2; 
                return midPoint;
            }
        }




        //CONSTUCTORS
        public Line (int startX, int startY, int endX, int endY)
        {
            _p0 = new Point (startX, startY);
            _p1 = new Point (endX, endY);
            
        }//end constructors

        

        //METHODS
        public void Draw()
        {
           
            double dx = _p1.X - _p0.X;
            double dy = _p1.Y - _p0.Y;

            double step;

            if(Math.Abs(dx) > Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }

            //CALCULATING X_INCREMENT AND Y_INCREMENT FOR EACH STEP
            double x_incr = dx / step;
            double y_incr = dy / step;

            //INITIAL POINTS
            double x = _p0.X;
            double y = _p0.Y;
            _p0.Dot();
            _p1.Dot();
            Console.ReadKey();

            Point tempPoint = new Point(); 

            for (int i = 0; i < step; i++)
            {
                tempPoint.SetPosition((int)x, (int)y);
                tempPoint.DrawLine();

                x += x_incr;
                y += y_incr;
            }
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }//end method

        public void Perturb(int minX, int maxX, int minY, int maxY)
        {
            Console.Clear();
            _p0.SetPosition((int)minX, (int)minY);
            _p0.Dot();
            _p1.SetPosition((int)maxX, (int)maxY);
            _p1.Dot();
        }//end method

        public void Collapse()
        {
            Console.Clear();
            int x = Midpoint.X;
            int y = Midpoint.Y;
            Midpoint.SetPosition(x, y);
            Midpoint.Dot();
            Console.ReadKey();
        }

    }//end class
}
