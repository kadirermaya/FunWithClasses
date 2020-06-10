using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWithClasses
{
    class CPU
    {
        // MEMBER VARIABLES ( HAS A)

        public string manufacturer;
        public string name;

        // CONSTRUCTOR (SPAWNER)
        //MEMBER METHODS (CAN DO)

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {



        }

        public void CheckReuqirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (TemporaryMemory.TotalGigabytes > application.RequiredRam && Storage.AvailableStorage > application.RequiredStorage)
            {

            }
    }

        //public void InstallApplication(Applications application)
        //{
        //    if (TemporaryMemory.TotalGigabytes > application.RequiredRam && Storage.AvailableStorage > application.RequiredStorage)
        //    {

        //        Storage.ApplicationsInHardDrive.Add(application);

        //    }


        //    //add applications if requirements as expected!
        //}

    }
}
