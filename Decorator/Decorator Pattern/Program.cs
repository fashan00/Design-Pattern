using Decorator_Pattern.Components;
using Decorator_Pattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            IShape decoratorCircle = new RedShapeDecorator(new Circle());
            Console.WriteLine("\nCircle of red border");
            decoratorCircle.Draw();


            IShape decoratorRectangle = new RedShapeDecorator(new Rectangle());
            decoratorRectangle = new GreenShapeDecorator(decoratorRectangle);
            Console.WriteLine("\nRectangle of red border and green background");
            decoratorRectangle.Draw();

            Console.ReadLine();
        }
    }
}
