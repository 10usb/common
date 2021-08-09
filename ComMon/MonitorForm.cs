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
		private Timer timer;

		public MonitorForm(string portName) {
			InitializeComponent();

			port = new SerialPort(portName);
			port.DataReceived += Port_DataReceived;

			Text = string.Format("Monitor: {0}", portName);

			StartButton.Enabled = !port.IsOpen;
			StopButton.Enabled = port.IsOpen;

			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;

			HexToggle.Click += HexToggle_Click;
			OpenSettings.Click += OpenSettings_Click;
			StartButton.Click += StartButton_Click;
			StopButton.Click += StopButton_Click;
			ClearButton.Click += ClearButton_Click;
		}

		private void Timer_Tick(object sender, EventArgs e) {
			StartButton.Enabled = !port.IsOpen;
			StopButton.Enabled = port.IsOpen;
			timer.Enabled = port.IsOpen;
		}

		private void StartButton_Click(object sender, EventArgs e) {
			try {
				port.Open();
				StartButton.Enabled = !port.IsOpen;
				StopButton.Enabled = port.IsOpen;
				timer.Enabled = port.IsOpen;
			} catch {

			}
		}
		private void StopButton_Click(object sender, EventArgs e) {
			port.Close();
			StartButton.Enabled = !port.IsOpen;
			StopButton.Enabled = port.IsOpen;
		}
		private void ClearButton_Click(object sender, EventArgs e) {
			TextView.Text = string.Empty;
			HexView.Text = string.Empty;
		}

		private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			if (e.EventType == SerialData.Chars) {
				byte[] buffer = new byte[1024];
				int read = port.Read(buffer, 0, buffer.Length);
				if (read > 0) {
					Invoke(new Action<byte[], int>(Append), buffer, read);
				}
			}
		}

		private void Append(byte[] buffer, int count) {
			string text = Encoding.ASCII.GetString(buffer, 0, count);
			TextView.SelectionStart = TextView.TextLength;
			TextView.SelectionLength = 0;
			TextView.SelectionColor = Color.Red;
			TextView.AppendText(text);
			TextView.ScrollToCaret();

			StringBuilder builder = new StringBuilder();
			for (int index = 0; index < count; index++) {
				builder.AppendFormat("{0:X2} ", buffer[index]);
			}
			HexView.SelectionStart = HexView.TextLength;
			HexView.SelectionLength = 0;
			HexView.SelectionColor = Color.Red;
			HexView.AppendText(builder.ToString());
			HexView.ScrollToCaret();
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
