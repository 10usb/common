using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComMon
{
	public partial class MonitorForm : Form
	{
		private SerialPort port;

		public MonitorForm(string portName) {
			InitializeComponent();
			HexToggle.Click += HexToggle_Click;
			OpenSettings.Click += OpenSettings_Click;

			port = new SerialPort(portName);
		}

		private void OpenSettings_Click(object sender, EventArgs e) {
			PortSettingsDialog form = new PortSettingsDialog(port);
			form.ShowDialog(this);
		}

		private void HexToggle_Click(object sender, EventArgs e) {
			HexView.Visible = !HexView.Visible;
			HexToggle.Checked = HexView.Visible;
		}

		private void ViewPanel_Resize(object sender, EventArgs e) {
			Realign();
		}

		private void HexView_VisibleChanged(object sender, EventArgs e) {
			Realign();
		}

		private void Realign() {

			if (HexView.Visible) {
				int width = ViewPanel.Width - 5 - 6;
				TextView.Width = width / 3;
				HexView.Width = width - TextView.Width;
				TextView.Left = HexView.Width + HexView.Left + 5;
			} else {
				TextView.Width = ViewPanel.Width - 6;
				TextView.Left = 3;
			}
			HexView.Height = TextView.Height = ViewPanel.Height - 6;
		}
	}
}
