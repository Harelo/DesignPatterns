using System;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public abstract class AnimalPrototype : DeepCloneable<AnimalPrototype>
    {
        public string Name { get; set; }
        public abstract AnimalPrototype makeCopy();
    }
}
