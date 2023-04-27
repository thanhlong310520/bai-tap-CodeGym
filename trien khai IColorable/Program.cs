using System;
using System.Collections.Generic;

namespace trien_khai_IColorable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            for(int i = 1; i <= 10; i++)
            {
                list.Add(AddShapeToList());
            }
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.ToString());
                if((shape as IColorable)!= null)
                {
                    IColorable temp = shape as IColorable;
                    Console.WriteLine(temp.HowToColor());
                }
            }

        }

        private static Shape AddShapeToList()
        {
            Shape temp;
            int x = new Random().Next(1, 4);
            switch (x)
            {
                case 1:
                    {
                        temp = new Square(new Random().Next(1, 50));
                        break;
                    }
                case 2:
                    {
                        temp = new Rectangle(new Random().Next(1, 40), new Random().Next(1, 30));
                        break;
                    }
                case 3:
                    {
                        temp = new Circle(new Random().Next(1, 40));
                        break;
                    }
                default:
                    {
                        temp = new Square(new Random().Next(1, 50));
                        break;
                    }
            }

            return temp;
        }
    }
}
