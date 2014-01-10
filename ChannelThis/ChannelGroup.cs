using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ChannelThis
{
  class ChannelGroup : GenericChannel
  {
    private List<Channel> channel_list;

    public ChannelGroup()
    {
      channel_list = new List<Channel>();
    }

    public Channel Add(XmlNode node)
    {
      try
      {
        if (node.Attributes["name"] != null)
        {

          Channel new_channel = new Channel();
          new_channel.Name = AddStringAttribute(node, "name");
          new_channel.Color = AddStringAttribute(node, "color");
          new_channel.SavedIndex = AddStringAttribute(node, "savedIndex");
          new_channel.DeviceType = AddStringAttribute(node, "deviceType");
          new_channel.Unit = AddStringAttribute(node, "unit");
          new_channel.Network = AddStringAttribute(node, "network");
          new_channel.Circuit = AddStringAttribute(node, "circuit");
          channel_list.Add(new_channel);
          return new_channel;
        }
        else
        {
          return null;
        }
      }
      catch
      {
        return null;
      }
    }

    private String AddStringAttribute(XmlNode node, String Attribute)
    {
      try
      {
        return node.Attributes[Attribute].Value;
      }
      catch
      {
        return "";
      }
    }

  }
}
