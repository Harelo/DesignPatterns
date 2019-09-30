﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class Sheep : AnimalPrototype
    {
        public override AnimalPrototype Clone()
        {
            return (Sheep)DeepClone(this);
        }
    }

    [Serializable]
    public class Cow : AnimalPrototype
    {
        public override AnimalPrototype Clone()
        {
            return (Cow)DeepClone(this);
        }
    }
}