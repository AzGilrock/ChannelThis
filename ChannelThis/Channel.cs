using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelThis
{
  class Channel : GenericChannel
  {
    public String Color { get; set; }
    public String DeviceType { get; set; }
    public String Unit { get; set; }
    public String Circuit { get; set; }
    public String Network { get; set; }
  }
}
