using System;

namespace ConsoleApp16
{
    class USB : Storage
    {
        private float SpeedUSB {get; set;}
        private float Volume {get; set;}

        public USB(float speedUSB, float memory)
        {
            SpeedUSB = speedUSB;
            Volume = memory;
        }

        public override float SetStorageVolumeMB()
        {
            return Volume;
        }

        public override float TransferData(float SizeFile)
        {
            return SizeFile / SpeedUSB;
        }

        public override void PrintDeviceVolumeMB(float DeviceVolumeMB){}
    }
}
