using System;

namespace ConsoleApp16
{
    class HDD : Storage
    {
        private float SpeedHDD {get; set;}
        private int CountOfSection {get; set;}
        private float SectionVolume {get; set;}

        public HDD(float speedHDD, int countofSection, float sectionVolume)
        {
            SpeedHDD = speedHDD;
            CountOfSection = countofSection;
            SectionVolume = sectionVolume;
        }

        public override float SetStorageVolumeMB()
        {
            return CountOfSection * SectionVolume;
        }

        public override float TransferData(float FileSize)
        {
            return FileSize / SpeedHDD;
        }

        public override void PrintDeviceVolumeMB(float DeviceVolumeMB){}
    }
}
 