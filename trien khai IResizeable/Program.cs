using System;

namespace trien_khai_IResizeable
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(100);
            shapes[1] = new Rectangle(10, 32);
            shapes[2] = new Square(50);

            Console.WriteLine("Size cua cac hinh truoc khi resize");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine("--------------------------------");
            foreach(Shape shape in shapes)
            {
                shape.Resize((double)50 / 100);
            }
            Console.WriteLine("Size cua cac hinh sau khi resize 50/100 la");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
