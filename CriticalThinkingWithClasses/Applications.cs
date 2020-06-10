using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWithClasses
{
    class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRam;
        public double RequiredStorage;
    }



    public Applications()
    {
        ApplicationName = "Slack";
        ApplicationType = "Messaging Service";
        RequiredRam = 4.0; // In Gigabytes
        RequiredStorage = 0.512; //In Gigabytes
    }
}
