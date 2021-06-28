using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)

        {
            Storage someHDD = new HDD(45, 2, 512000);
            Storage someUSB = new USB(80, 128000);
            Storage someDVD = new DVD(5.28f, true);


            Console.Write("Enter name of type of your storage. \nSelect USB, DVD, or HDD then press the enter key to continue: ");
            string select = Convert.ToString(Console.ReadLine()).ToUpper();

            Console.WriteLine(" Input your storage volume in MB: ");
            int DeviceVolumeMB = int.Parse(Console.ReadLine());

            int AmountOfHDDNeeds = (int)Math.Ceiling(DeviceVolumeMB / someHDD.SetStorageVolumeMB());
            int AmountOfUSBNeeds = (int)Math.Ceiling(DeviceVolumeMB / someUSB.SetStorageVolumeMB());
            int AmountOfDVDNeeds = (int)Math.Ceiling(DeviceVolumeMB / someDVD.SetStorageVolumeMB());

            switch (select)
            {
                case "USB":
                    Console.WriteLine("\nRequired data transfer time: " + someUSB.TransferData(DeviceVolumeMB) + "s ");
                    Console.WriteLine("For transferring you need only: " + AmountOfUSBNeeds + " USBs");
                    break;

                case "HDD":
                    Console.WriteLine("\nRequired data transfer time: " + someHDD.TransferData(DeviceVolumeMB) + "s ");
                    Console.WriteLine("For transferring you need only: " + AmountOfHDDNeeds + " HDDs");
                    break;

                case "DVD":
                    Console.WriteLine("\nRequired data transfer time: " + someDVD.TransferData(DeviceVolumeMB) + "s ");
                    Console.WriteLine("For transferring you need only: " + AmountOfDVDNeeds + " DVDs");
                    break;
                
                default: throw new ArgumentException("Enter Error");
            }
            Console.WriteLine("\nPreste enter key if u want to see total memory of our devices");
            Console.ReadLine();
            

            List<Storage> allStorages = new List<Storage>();
            allStorages.Add(someHDD);
            allStorages.Add(someUSB);
            allStorages.Add(someDVD);

            int elementOfList = 0;
            float sumAllStorageMemory = 0;

            foreach ( var someStorage in allStorages)
            {
                someStorage.PrintDeviceVolumeMB(DeviceVolumeMB);
                sumAllStorageMemory += someStorage.SetStorageVolumeMB();
                elementOfList++;
            }

            Console.WriteLine("\n Total memory of all devices: " + sumAllStorageMemory);
        }
    }
}
