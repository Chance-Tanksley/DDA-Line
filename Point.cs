using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DDA
{
    public class Point
    {
        //FIELDS
        protected int _x, _y = 0;
        
        //end fields


        //PROPERTIES
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
            }
        }//end property
        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }//end property



        //CONSTRUCTORS
        public Point(int startX, int startY)
        {
            SetPosition(startX, startY);
        }//end constructor 

        public Point()
        {
            SetPosition(0, 0);
        }//end constructor

        //METHODS
        public void SetPosition(int newX, int newY)
        {
            _x = newX;
            _y = newY;
        }//end method
        public void Dot()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");

        }//end method
        public void DrawLine()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("*");

        }//end method

    }//end class
}