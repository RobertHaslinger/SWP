﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminararbeit.Normal.Developer
{
    public class JavaDeveloper
    {
        public string Name { get; set; }

        public void WriteJavaCode()
        {
            Console.WriteLine($"{Name} is writing a lot of java code....");
        }
    }
}
