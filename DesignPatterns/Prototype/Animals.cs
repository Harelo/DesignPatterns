using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class Sheep : Prototype
    {
        public string Name { get; set; }

        public override Prototype Clone()
        {
            return (Sheep)DeepClone(this);
        }
    }

    [Serializable]
    public class Cow : Prototype
    {
        public string Name { get; set; }

        public override Prototype Clone()
        {
            return (Cow)DeepClone(this);
        }
    }
}
