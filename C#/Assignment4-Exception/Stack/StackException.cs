﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class StackException : Exception
    {
        public StackException(string message) : base(message)
        {

        }
    }
}
