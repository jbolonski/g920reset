namespace G920Reset
{
    internal class Program
    {
        // Logitech   = 046D
        // G920 Wheel = C262
        private static readonly string USB_DEVICE_ID = @"USB\VID_046D&PID_C262";

        private static void Main(string[] args)
        {
            ResetDevice(USB_DEVICE_ID);
        }

        private static void ResetDevice(string usbDeviceID)
        {
            USBHardware.DisableHardware.ResetDevice(n => n.ToUpperInvariant().Contains(usbDeviceID));
        }
    }
}