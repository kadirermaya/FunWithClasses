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

        public string Manufacturer;
        public string Name;

        // CONSTRUCTOR (SPAWNER)
        //MEMBER METHODS (CAN DO)
    
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
        }
        public void CheckRequirements (Applications app, HardDrive hardDrive, RAM ram)
        {
            if (ram.TotalGigabytes > app.RequiredRam && hardDrive.AvailableStorage > app.RequiredStorage)
            {
                ProcessInstall(app, hardDrive, ram);
            }
            else
            {

            }
        }

        
            //if (TemporaryMemory.TotalGigabytes > application.RequiredRam && Storage.AvailableStorage > application.RequiredStorage)
            //{

            //    Storage.ApplicationsInHardDrive.Add(application);

            //}


            //add applications if requirements as expected!
        


    }
}
