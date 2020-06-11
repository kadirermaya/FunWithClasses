using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWithClasses
{
    public class Computer
    {
        // MEMBER VARIABLES ( HAS A)

        public Motherboard motherboard;
        public CPU cpu;
        public GPU gpu;
        public HardDrive hardDrive;
        public RAM ram;

        // CONSTRUCTOR (SPAWNER)

        public Computer()
        {
            hardDrive = new HardDrive(1024, 1024);
            ram = new RAM(32, "Kingston");
            gpu = new GPU("Nvidia", 8.0);
            cpu = new CPU("Intel", "i9");
            motherboard = new Motherboard("MSI Gaming", cpu, ram, hardDrive, gpu);
        }

        //MEMBER METHODS (CAN DO)

        public void Run()
        {
            Console.WriteLine("Your computer created!");
            Console.WriteLine($"Your computer's specs:");
            Console.WriteLine($"Processor:      {cpu.manufacturer} {cpu.name}");
            Console.WriteLine($"Graphics Card:  {gpu.Manufacturer} {gpu.EffectiveMemory} gb");
            Console.WriteLine($"Ram:            {ram.Brand} {ram.TotalGigabytes}");
            Console.WriteLine($"Hard Drive:     {hardDrive.Storage} gb");
            Console.WriteLine($"Motherboard:    {motherboard.Manufacturer}");
        }

        public void AddApplication()
        {
            
        }
        
    }
}
