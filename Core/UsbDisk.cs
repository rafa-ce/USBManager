using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBManager.Core
{
    public class UsbDisk
    {
        private const int KB = 1024;
        private const int MB = KB * 1000;
        private const int GB = MB * 1000;

        public String Name { get; private set; }
        public String Model { get; internal set; }
        public String Volume { get; internal set; }
        public int FreeSpace { get; internal set; }
        public int Size { get; internal set; }
        public String SerialNumber { get; internal set; }

        internal UsbDisk(String name)
        {
            Name = name;
            Model = String.Empty;
            Volume = String.Empty;
            FreeSpace = 0;
            Size = 0;
            SerialNumber = String.Empty;
        }
    }
}
