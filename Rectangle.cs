using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Generator
{
    class Rectangle
    {

        //Attributes
        double length, breadth;

        //Methods
        public 
            Rectangle()
        {
            this.length = 0;
            this.breadth = 0;
        }
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public string getRectangle()
        {
            return string.Format("Rectangle : {0}' {1} \"", length, breadth);
        }

        //Operator overloading
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle r3 = new Rectangle();
            r3.length = r1.length + r2.length;
            r3.breadth = r1.breadth + r2.breadth;
            return r3;
        }
    }
}
