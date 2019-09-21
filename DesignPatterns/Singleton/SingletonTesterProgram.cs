namespace DesignPatterns.Singleton
{
    class SingletonTesterProgram
    {
        public static void RunTest()
        {
            Singleton.Whatever a = new Singleton.Whatever();
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From student");
        }
    }
}