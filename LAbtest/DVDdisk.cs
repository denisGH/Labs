using System;

namespace ConsoleApp16
{
    class DVD : Storage
    {
        private float Speed {get; set;}
        
        private bool Oneside {get; set;}


        public DVD(float speed, bool oneside)
        {
            Speed = speed;
            Oneside = oneside;
        }

        public override float SetStorageVolumeMB()
        {
            if (Oneside)
                return 4700;
            else
                return 9000;
        }

        public override float TransferData(float SizeFile)
        {
            return SizeFile / Speed;
        }
        public override void PrintDeviceVolumeMB(float DeviceVolumeMB){}
    }
}
