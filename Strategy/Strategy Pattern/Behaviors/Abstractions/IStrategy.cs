﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}
