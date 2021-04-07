using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminararbeit.DIP.Developer;

namespace Seminararbeit.DIP
{
    public class SoftwareProject
    {
        private List<IDeveloper> _developers;

        public SoftwareProject(List<IDeveloper> developers)
        {
            _developers = developers;
        }

        public void DoImplementation()
        {
            _developers.ForEach(dev => dev.WriteCode());
        }
    }
}
