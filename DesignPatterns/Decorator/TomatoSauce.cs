namespace DesignPatterns.Decorator
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza _tempPizza) : base(_tempPizza) { }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + " ,Tomato Sauce";
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.5;
        }
    }
}
