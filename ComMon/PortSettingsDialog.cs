using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComMon
{
	public partial class PortSettingsDialog : Form
	{
		private SerialPort port;

		public string PortName { get; private set; }

		public PortSettingsDialog(SerialPort port) {
			InitializeComponent();
			this.port = port;
			Text = string.Format("Settings: {0}", port.PortName);

			Baudrate.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400" });
			DataBits.Items.AddRange(new string[] { "5", "6", "7", "8" });
			Handshake.Items.AddRange(Enum.GetNames(typeof(Handshake)));
			Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
			StopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

			Baudrate.Text = port.BaudRate.ToString();
			DataBits.Text = port.DataBits.ToString();
			Handshake.Text = port.Handshake.ToString();
			Parity.Text = port.Parity.ToString();
			ParityReplace.Text = port.ParityReplace.ToString("X2");
			StopBits.Text = port.StopBits.ToString();

			DtrEnable.Value = port.DtrEnable;
			RtsEnable.Value = port.RtsEnable;
			DiscardNull.Value = port.DiscardNull;

			//port.BreakState;
			//port.Encoding
		}

		private void ButtonOpen_Click(object sender, EventArgs e) {
			Settings settings = GetSettings();
			if (settings != null) {
				port.BaudRate = settings.BaudRate;
				port.DataBits = settings.DataBits;
				port.Handshake = settings.Handshake;
				port.Parity = settings.Parity;
				port.ParityReplace = settings.ParityReplace;
				port.StopBits = settings.StopBits;
				port.DtrEnable = settings.DtrEnable;
				port.RtsEnable = settings.RtsEnable;
				port.DiscardNull = settings.DiscardNull;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private Settings GetSettings() {
			Settings settings = new Settings();

			if (!int.TryParse(Baudrate.Text, out int bautRate))
				return null;

			if (!int.TryParse(DataBits.Text, out int dataBits))
				return null;

			if (!Enum.TryParse(typeof(Handshake), Handshake.Text, out object handshake))
				return null;

			if (!Enum.TryParse(typeof(Parity), Parity.Text, out object parity))
				return null;

			if (!byte.TryParse(ParityReplace.Text, NumberStyles.HexNumber, null, out byte parityReplace))
				return null;

			if (!Enum.TryParse(typeof(StopBits), StopBits.Text, out object stopBits))
				return null;

			settings.BaudRate = bautRate;
			settings.DataBits = dataBits;
			settings.Handshake = (Handshake)handshake;
			settings.Parity = (Parity)parity;
			settings.ParityReplace = parityReplace;
			settings.StopBits = (StopBits)stopBits;
			settings.DtrEnable = DtrEnable.Value;
			settings.RtsEnable = RtsEnable.Value;
			settings.DiscardNull = DiscardNull.Value;
			return settings;
		}

		private class Settings
		{
			public int BaudRate { get; internal set; }
			public int DataBits { get; internal set; }
			public Handshake Handshake { get; internal set; }
			public Parity Parity { get; internal set; }
			public byte ParityReplace { get; internal set; }
			public StopBits StopBits { get; internal set; }
			public bool DtrEnable { get; internal set; }
			public bool RtsEnable { get; internal set; }
			public bool DiscardNull { get; internal set; }
		}
	}
}
