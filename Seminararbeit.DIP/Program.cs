using System;
using System.Collections.Generic;
using Seminararbeit.DIP.Developer;

namespace Seminararbeit.DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareProject softwareParadigmen= new SoftwareProject(new List<IDeveloper>()
            {
                new JavaDeveloper()
                {
                    Name = "Paul Kaufmann"
                },
                new JavaScriptDeveloper()
                {
                    Name = "Lukas Hofbauer"
                },
                new PhpDeveloper()
                {
                    Name = "Robert Haslinger"
                }
            });

            softwareParadigmen.DoImplementation();
        }
    }
}
