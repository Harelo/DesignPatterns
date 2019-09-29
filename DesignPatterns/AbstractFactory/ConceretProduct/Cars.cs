using DesignPatterns.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;
using static DesignPatterns.AbstractFactory.Enumerations;

namespace DesignPatterns.AbstractFactory.ConceretProduct
{
    public class Mazda : ICar
    {
        public string GetCar() => Car.Mazda.ToString();
    }

    public class Kia : ICar
    {
        public string GetCar() => Car.Kia.ToString();
    }
}
