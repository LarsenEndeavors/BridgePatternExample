namespace BridgePatternExample.Objects
{
    public abstract class RemoteButton
    {
        private EntertainmentDevice EntertainmentDevice { get; set; }

        protected RemoteButton(EntertainmentDevice entertainmentDevice)
        {
            EntertainmentDevice = entertainmentDevice;
        }
        
        public void ButtonFivePressed()
        {
            EntertainmentDevice.ButtonFivePressed();
        }

        public void ButtonSixPressed()
        {
            EntertainmentDevice.ButtonSixPressed();
        }

        public void DeviceFeedback()
        {
            EntertainmentDevice.DeviceFeedback();
        }

        public abstract void ButtonNinePressed();
    }
}