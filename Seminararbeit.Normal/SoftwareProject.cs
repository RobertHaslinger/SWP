using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seminararbeit.Normal.Developer;

namespace Seminararbeit.Normal
{
    public class SoftwareProject
    {
        private List<JavaDeveloper> _javaDevelopers;
        private List<JavaScriptDeveloper> _javaScriptDevelopers;
        private List<PhpDeveloper> _phpDevelopers;

        public SoftwareProject(List<JavaDeveloper> javaDevelopers, List<JavaScriptDeveloper> javaScriptDevelopers, List<PhpDeveloper> phpDevelopers)
        {
            _javaDevelopers = javaDevelopers;
            _javaScriptDevelopers = javaScriptDevelopers;
            _phpDevelopers = phpDevelopers;
        }

        public void DoImplementation()
        {
            _javaDevelopers.ForEach(dev => dev.WriteJavaCode());
            _javaScriptDevelopers.ForEach(dev => dev.DoJavaScriptCode());
            _phpDevelopers.ForEach(dev => dev.WritePhpCode());
        }
    }
}
