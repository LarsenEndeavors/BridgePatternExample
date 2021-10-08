using System;

namespace BridgePatternExample.Objects
{
    public class DvdRemote : RemoteButton
    {
        public DvdRemote(EntertainmentDevice entertainmentDevice) : base(entertainmentDevice)
        {
        }

        public override void ButtonNinePressed()
        {
            Console.WriteLine("Dvd player paused.");
        }
    }
}