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
	public partial class OpenPortDialog : Form
	{
		private Timer timer;

		public string PortName { get; private set; }

		public OpenPortDialog() {
			InitializeComponent();

			timer = new Timer();
			timer.Interval = 5000;
			timer.Tick += Timer_Tick;
			timer.Enabled = true;

			UpdateList();

			Ports.Focus();
		}

		private void UpdateList() {
			string current = Ports.SelectedValue as string;

			string[] devices = SerialPort.GetPortNames();
			Ports.Items.Clear();
			Ports.Items.AddRange(devices);
			if (devices.Contains(current)) {
				Ports.SelectedItem = current;
			} else if (Ports.Items.Count > 0) {
				if (Ports.SelectedIndex < 0)
					Ports.SelectedIndex = 0;
			} else {
				ButtonOpen.Enabled = false;
			}
		}

		private void Timer_Tick(object sender, EventArgs e) {
			UpdateList();
		}

		private void Ports_SelectedIndexChanged(object sender, EventArgs e) {
			PortName = Ports.SelectedItem as string;
			ButtonOpen.Enabled = Ports.SelectedIndex >= 0;
		}

		private void ButtonOpen_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void OpenForm_FormClosing(object sender, FormClosingEventArgs e) {
			timer.Enabled = false;
		}
	}
}
