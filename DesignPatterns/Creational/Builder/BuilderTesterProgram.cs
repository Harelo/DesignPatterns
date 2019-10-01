using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class BuilderTesterProgram
    {
        public static void RunTest()
        {
            string cpu = "testCPU";
            string gpu = "testGPU";
            string ram = "testRAM";
            string ssd = "testSSD";

            Computer.ComputerBuilder builder = new Computer.ComputerBuilder(cpu, gpu, ram, ssd);
            ComputerBuildingDirector director = new ComputerBuildingDirector(builder);
            director.buildComputer();
            Computer myComputer = builder.getComputer();
        }
    }
}
