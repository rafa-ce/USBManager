using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBManager.Core
{
    public class UsbStateChangedEventArgs : EventArgs
    {
        public UsbDisk Disk { get; private set; }
        public UsbStateChange State { get; private set; }

        public UsbStateChangedEventArgs(UsbStateChange state, UsbDisk disk)
        {
            this.State = state;
            this.Disk = disk;
        }
    }
}
