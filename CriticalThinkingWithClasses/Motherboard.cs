using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWithClasses
{
    class Motherboard
    {
        // MEMBER VARIABLES ( HAS A)

        public string Manufacturer;
        public CPU Processor;
        public RAM TemporaryMemory;
        public HardDrive Storage;
        public GPU Graphics;

        // CONSTRUCTOR (SPAWNER)

        public Motherboard(string manufacturer, CPU processor, RAM temporaryMemory, HardDrive storage, GPU graphics)
        {
            Manufacturer = manufacturer;
            Processor = processor;
            TemporaryMemory = temporaryMemory;
            Storage = storage;
            Graphics = graphics;
        }


        //MEMBER METHODS (CAN DO)

        public void InstallApplication(Applications application)
        {
            Storage.ApplicationsInHardDrive.Add(application);
        }
    }
}
