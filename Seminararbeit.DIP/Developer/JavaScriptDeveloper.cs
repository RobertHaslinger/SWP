using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminararbeit.DIP.Developer
{
    public class JavaScriptDeveloper : IDeveloper
    {
        public string Name { get; set; }

        public void DoJavaScriptCode()
        {
            Console.WriteLine($"{Name} is writing a lot of buggy javascript");
        }

        public void WriteCode()
        {
            DoJavaScriptCode();
        }
    }
}
