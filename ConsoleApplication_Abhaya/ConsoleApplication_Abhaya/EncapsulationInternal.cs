using System;

namespace RectangleApplication2
{
    class Rectangle
    {
        //member variables
        internal double length;
        internal double width;

        // no access modifier mentioned. THe default is private
        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main_EncapInetrnal(string[] args)
        {
            Rectangle r = new Rectangle();
            //can access length, width and methods because all are declared public
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}