using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminararbeit.DIP.Developer;

namespace Seminararbeit.DIP.Developer
{
    public class PhpDeveloper : IDeveloper
    {
        public string Name { get; set; }

        public void WritePhpCode()
        {
            Console.WriteLine($"{Name} is writing some php stuff...");
        }

        public void WriteCode()
        {
            WritePhpCode();
        }
    }
}
