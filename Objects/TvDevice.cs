using System;

namespace BridgePatternExample.Objects
{
    public class TvDevice : EntertainmentDevice
    {
        public TvDevice(int newDeviceState, int newMaxSetting)
        {
            DeviceState = newDeviceState;
            MaxSetting = newMaxSetting;
        }

        public override void ButtonFivePressed()
        {
            DeviceState += 1;
            Console.WriteLine("Channel now " + DeviceState);
        }

        public override void ButtonSixPressed()
        {
            DeviceState -= 1;
            Console.WriteLine("Channel now " + DeviceState);
        }
    }
}