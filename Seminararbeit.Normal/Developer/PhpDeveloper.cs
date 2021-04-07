using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminararbeit.Normal.Developer
{
    public class PhpDeveloper
    {
        public string Name { get; set; }

        public void WritePhpCode()
        {
            Console.WriteLine($"{Name} is writing some php stuff...");
        }
    }
}
