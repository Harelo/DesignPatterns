using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class VisitorTesterProgram
    {
        public static void RunTest()
        {
            ObjectStructure os = new ObjectStructure();
            os.Attach(new Cow() { name = "John" });
            os.Attach(new Dog() { name = "Bafi" });

            MakeSoundVisitor msVisitor = new MakeSoundVisitor();
            os.Accept(msVisitor);
        }
    }
}
