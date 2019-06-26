﻿using Decorator_Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorators
{
    public class RedShapeDecorator : ShapeDecorator
    {

        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {

        }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
