using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using AdvancedDataGridView;

namespace ChannelThis
{
  public partial class mainForm : Form
  {
    XmlDocument doc;
    UInt16 channel_rows = 0;
    Stream myStream = null;
    ChannelGroup all_channels = new ChannelGroup();

    public mainForm()
    {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
      RibbonProfessionalRenderer rend = new RibbonProfessionalRenderer();
      BackColor = rend.ColorTable.RibbonBackground;
      //ChangeTheme();
    }

    private void ChangeTheme()
    {
      (ribbon1.Renderer as RibbonProfessionalRenderer).ColorTable =
          new RibbonProfesionalRendererColorTableBlack();
      ribbon1.Refresh();
    }

    private void cmdNew_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Button \"New\" Clicked.");
    }

    private void cmdOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      openFileDialog1.InitialDirectory = "c:\\";
      openFileDialog1.Filter = "LCC files (*.lcc)|*.lcc|All files (*.*)|*.*";
      openFileDialog1.FilterIndex = 2;
      openFileDialog1.RestoreDirectory = true;

      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if ((myStream = openFileDialog1.OpenFile()) != null)
          {
            txtFileName.Text = openFileDialog1.FileName;
            using (myStream)
            {
              doc = new XmlDocument();
              doc.Load(myStream);
              parse_xml_document();
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
      openFileDialog1.Dispose();
    }

    private void parse_xml_document()
    {
      XmlNodeList channel_list = doc.GetElementsByTagName("channel");
      lbl_channel_count.Text = "0";
      foreach (XmlNode node in channel_list)
      {
        Channel new_channel = all_channels.Add(node);
        if (new_channel != null)
        {
          channel_grid.Rows.Add();
          channel_grid.Rows[channel_rows].Cells["channel_name"].Value = new_channel.Name;
          channel_grid.Rows[channel_rows].Cells["Index"].Value = new_channel.SavedIndex;
          channel_grid.Rows[channel_rows].Cells["Color"].Value = new_channel.Color;
          channel_grid.Rows[channel_rows].Cells["DeviceType"].Value = new_channel.DeviceType;
          channel_grid.Rows[channel_rows].Cells["Unit"].Value = new_channel.Unit;
          channel_grid.Rows[channel_rows].Cells["Circuit"].Value = new_channel.Circuit;
          channel_grid.Rows[channel_rows].Cells["Network"].Value = new_channel.Network;
          channel_rows++;
          if (channel_rows % 10 == 0)
          {
            lbl_channel_count.Text = channel_rows.ToString();
          }

          add_channel(new_channel);
        }
        lbl_channel_count.Text = channel_rows.ToString();
      }
    }

    private void add_channel(Channel channel)
    {
      Int32 num_nodes = device_grid.RowCount;
      Boolean found = false;
      for (Int32 i = 0; i < num_nodes; ++i)
      {
        if (device_grid.Nodes[i].Cells["device_name"].Value.ToString() == "Unit " + channel.Unit)
        {
          device_grid.Nodes[i].Nodes.Add(null, channel.Name, channel.SavedIndex, channel.Network, channel.Circuit);
          found = true;
          break;
        }
      }
      if (!found)
      {
        TreeGridNode node = device_grid.Nodes.Add(null, "Unit " + channel.Unit, "", "", "");
        node.Nodes.Add(null, channel.Name, channel.SavedIndex, channel.Network, channel.Circuit);
      }
    }

    private void menu_exit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnNumberUniverse_Click(object sender, EventArgs e)
    {
      Int32 selectedRowCount = channel_grid.Rows.GetRowCount(DataGridViewElementStates.Selected);
      if (selectedRowCount > 0)
      {
        for (int i = 0; i < selectedRowCount; i++)
        {
          String name = channel_grid.SelectedRows[i].Cells["channel_name"].Value.ToString();
          String index = channel_grid.SelectedRows[i].Cells["Index"].Value.ToString();

          XmlNodeList channel_list = doc.GetElementsByTagName("channel");
          foreach (XmlNode node in channel_list)
          {
            if( node.Attributes["savedIndex"].Value == index )
            {
              if( channel_grid.SelectedRows[i].Cells["Network"].Value.ToString() == "" )
              {
                XmlAttribute attrib = node.OwnerDocument.CreateAttribute("network");
                attrib.Value = txtUniverse.Text;
                node.Attributes.Append(attrib);
              }
              else
              {
                node.Attributes["network"].Value = txtUniverse.Text;
              }
              node.Attributes["deviceType"].Value = "DMX Universe";
              break;
            }
          }
          channel_grid.SelectedRows[i].Cells["Network"].Value = txtUniverse.Text;
          channel_grid.SelectedRows[i].Cells["DeviceType"].Value = "DMX Universe";
        }
      }
    }

    private void cmdSave_Click(object sender, EventArgs e)
    {
      doc.Save(@"C:\Users\Gil\Documents\test.lcc");
    }

    private void btnRenumberCircuits_Click(object sender, EventArgs e)
    {
      UInt32 circuit = Convert.ToUInt32(txtCircuitStart.Text);

      List<DataGridViewRow> dgList = new List<DataGridViewRow>();
      foreach (DataGridViewRow r in channel_grid.SelectedRows)
      {
        dgList.Insert(0, r);
      }
      foreach (DataGridViewRow r in dgList)
      {
        int selectedIndex = r.Index;
        String name = channel_grid.Rows[selectedIndex].Cells["channel_name"].Value.ToString();
        String index = channel_grid.Rows[selectedIndex].Cells["Index"].Value.ToString();
        XmlNodeList channel_list = doc.GetElementsByTagName("channel");
        foreach (XmlNode node in channel_list)
        {

          if (node.Attributes["savedIndex"].Value == index)
          {
            node.Attributes["circuit"].Value = circuit.ToString();
            channel_grid.Rows[selectedIndex].Cells["Circuit"].Value = circuit.ToString();
            circuit++;
            break;
          }
        }
      }
    }

  }
}
