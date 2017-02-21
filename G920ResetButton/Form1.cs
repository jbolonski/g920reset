using System;
using System.Windows.Forms;

namespace G920ResetButton
{
    // Logitech   = 046D
    // G920 Wheel = C262
    public partial class Form1 : Form
    {
        private readonly string USB_DEVICE_ID = @"USB\VID_046D&PID_C262";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USBHardware.DisableHardware.ResetDevice(n => n.ToUpperInvariant().Contains(USB_DEVICE_ID));
            Application.Exit();
        }
    }
}