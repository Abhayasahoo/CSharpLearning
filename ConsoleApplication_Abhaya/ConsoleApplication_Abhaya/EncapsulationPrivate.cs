using System;

namespace RectangleApplication1
{
    class Rectangle
    {
        //member variables
        private double length;
        private double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        
        // new method created and marked public so that main() can access it and retreive the length and width. Length and width are declared as private and can't be accessed from main() method.
        
        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main_EncapsulationPrivate(string[] args)
        {
            Rectangle r = new Rectangle();
            //can't access length, width and methods because all are declared private
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}