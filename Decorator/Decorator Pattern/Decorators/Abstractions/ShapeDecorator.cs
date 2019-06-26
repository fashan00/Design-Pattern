using Decorator_Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorators
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
