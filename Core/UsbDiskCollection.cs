using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBManager.Core
{
    public class UsbDiskCollection : ObservableCollection<UsbDisk>
    {
        public Boolean Contains(String name)
        {
            return this.AsQueryable<UsbDisk>().Any(d => d.Name == name) == true;
        }

        public Boolean Remove(string name)
        {
            UsbDisk disk = (this.AsQueryable<UsbDisk>().Where(d => d.Name == name).Select(d => d)).FirstOrDefault<UsbDisk>();

            if (disk != null)
                return this.Remove(disk);

            return false;
        }
    }
}
