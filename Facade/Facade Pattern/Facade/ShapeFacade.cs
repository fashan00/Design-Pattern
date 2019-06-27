using Facade_Pattern.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Facade
{
    public class ShapeFacade
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

        public ShapeFacade()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
        public void DrawAll()
        {
            circle.Draw();
            rectangle.Draw();
            square.Draw();
        }
    }
}
