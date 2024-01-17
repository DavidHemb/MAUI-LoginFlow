using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLoginFlow.Models
{
    public class BluetoothDeviceInfo
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
