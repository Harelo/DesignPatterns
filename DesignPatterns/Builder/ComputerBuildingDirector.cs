namespace DesignPatterns.Builder
{
    public class ComputerBuildingDirector
    {
        private readonly Computer.ComputerBuilder builder;
        public ComputerBuildingDirector(Computer.ComputerBuilder _builder)
        {
            this.builder = _builder;
        }

        public void buildComputer()
        {
            builder.build();
        }
    }
}
