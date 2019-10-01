using System;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public abstract class Prototype : DeepCloneable<Prototype>
    {
        public abstract Prototype Clone();
    }
}
