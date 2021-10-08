using System;

namespace BridgePatternExample.Objects
{
    public abstract class EntertainmentDevice
    {
        public int DeviceState;
        public int MaxSetting;
        public int volumeLevel = 0;

        public abstract void ButtonFivePressed();
        public abstract void ButtonSixPressed();

        public void DeviceFeedback()
        {
            if (DeviceState > MaxSetting || DeviceState < 0)
            {
                DeviceState = 0;
            }

            Console.WriteLine("On channel " + DeviceState);
        }

        public void ButtonSevenPressed()
        {
            volumeLevel += 1;
            Console.WriteLine("Volume at " + volumeLevel);
        }
        
        public void ButtonEightPressed()
        {
            volumeLevel -= 1;
            Console.WriteLine("Volume at " + volumeLevel);
        }
    }
}