using Decorator_Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorators
{
    public class GreenShapeDecorator : ShapeDecorator
    {

        public GreenShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {

        }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetGreenBackground(decoratedShape);
        }

        private void SetGreenBackground(IShape decoratedShape)
        {
            Console.WriteLine("Background Color: Green");
        }
    }
}
