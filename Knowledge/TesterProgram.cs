namespace Knowledge
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From student");
        }
    }
}