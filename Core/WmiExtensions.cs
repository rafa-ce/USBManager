using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace USBManager.Core
{
    public static class WmiExtensions
    {
        public static ManagementObject First(this ManagementObjectSearcher searcher)
        {
            ManagementObject result = null;
            foreach (ManagementObject item in searcher.Get())
            {
                result = item;
                break;
            }
            return result;
        }
    }
}
