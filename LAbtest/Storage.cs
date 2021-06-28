using System;

namespace ConsoleApp16
{
    abstract class Storage 
    {

        public abstract float SetStorageVolumeMB();
        public abstract float TransferData(float SizeFileMB);
        public abstract void PrintDeviceVolumeMB(float DeviceVolumeMB);
    }
}
