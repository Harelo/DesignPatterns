using DesignPatterns.AbstractFactory.AbstractProduct;
using static DesignPatterns.AbstractFactory.Enumerations;

namespace DesignPatterns.AbstractFactory.ConceretProduct
{
    public class N45 : IEngine
    {
        public string GetEngine() => Engine.N45.ToString();
    }

    public class N55 : IEngine
    {
        public string GetEngine() => Engine.N55.ToString();
    }

    public class N65 : IEngine
    {
        public string GetEngine() => Engine.N65.ToString();
    }
}
