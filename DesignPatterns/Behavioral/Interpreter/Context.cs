using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    public class Context
    {
        public string input { get; set; }
        public int output { get; set; }

        public Context(string newInput)
        {
            input = newInput;
        }
    }
}
