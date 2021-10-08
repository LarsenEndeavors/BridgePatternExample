using System;

namespace BridgePatternExample.Objects
{
    public class TvRemote : RemoteButton
    {
        public TvRemote(EntertainmentDevice entertainmentDevice) : base(entertainmentDevice)
        {
        }

        public override void ButtonNinePressed()
        {
            Console.WriteLine("Tv was muted.");
        }
    }
}