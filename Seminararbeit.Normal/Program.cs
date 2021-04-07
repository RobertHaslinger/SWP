using System;
using System.Collections.Generic;
using Seminararbeit.Normal.Developer;

namespace Seminararbeit.Normal
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareProject softwareParadigmen = new SoftwareProject(new List<JavaDeveloper>()
            {
                new JavaDeveloper()
                {
                    Name = "Paul Kaufmann"
                }
            }, new List<JavaScriptDeveloper>()
            {
                new JavaScriptDeveloper()
                {
                    Name= "Lukas Hofbauer"
                }
            }, new List<PhpDeveloper>()
            {
                new PhpDeveloper()
                {
                    Name = "Robert Haslinger"
                }
            });

            softwareParadigmen.DoImplementation();
        }
    }
}
