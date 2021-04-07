using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminararbeit.DIP.Developer
{
    public class JavaDeveloper : IDeveloper
    {
        public string Name { get; set; }

        public void WriteJavaCode()
        {
            Console.WriteLine($"{Name} is writing a lot of java code....");
        }

        public void WriteCode()
        {
            WriteJavaCode();
        }
    }
}
