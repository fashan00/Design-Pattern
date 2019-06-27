﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Subsystems
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
}