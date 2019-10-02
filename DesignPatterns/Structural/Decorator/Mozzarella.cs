namespace DesignPatterns.Decorator
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza _tempPizza) : base(_tempPizza) { }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + " ,Mozazarella";
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.3;
        }
    }
}
