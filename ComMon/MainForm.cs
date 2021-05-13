using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComMon
{
	public partial class MainForm : Form
	{
		private Form current;

		public MainForm() {
			InitializeComponent();
			OpenMenuItem.Click += OpenMenuItem_Click;
			XMenuItem.Click += XMenuItem_Click;
			WMenuItem.Click += WMenuItem_Click;
		}

		private void OpenMenuItem_Click(object sender, EventArgs e) {
			OpenForm form = new OpenForm();
			if (form.ShowDialog(this) == DialogResult.OK) {
				OpenMonitor(form.PortName);
			}
		}

		private void OpenMonitor(string portName) {
			MonitorForm monitor = new MonitorForm(portName) {
				TopLevel = false
			};

			monitor.MinimizeBox = false;
			monitor.Closing += Monitor_Closing;
			monitor.Click += Monitor_Click;
			monitor.Resize += Monitor_Resize;

			PositionForm(monitor);

			FormContainer.Controls.Add(monitor);
			monitor.Show();

			FormContainer.Controls.SetChildIndex(monitor, 0);
			monitor.Activate();
		}

		private void Monitor_Closing(object sender, CancelEventArgs e) {
			Form form = sender as Form;
			form.Click -= Monitor_Click;
			form.Closing -= Monitor_Closing;
			form.Resize -= Monitor_Resize;
			FormContainer.Controls.Remove(form);
		}

		private void Monitor_Click(object sender, EventArgs e) {
			MonitorForm monitor = sender as MonitorForm;
			FormContainer.Controls.SetChildIndex(monitor, 0);
			monitor.Activate();
		}

		private void Monitor_Resize(object sender, EventArgs e) {
			MonitorForm monitor = sender as MonitorForm;
			if (monitor.WindowState == FormWindowState.Maximized) {
				monitor.WindowState = FormWindowState.Normal;
				monitor.FormBorderStyle = FormBorderStyle.None;
				monitor.Dock = DockStyle.Fill;
				current = monitor;
			}
		}
		private void WMenuItem_Click(object sender, EventArgs e) {
			current.FormBorderStyle = FormBorderStyle.Sizable;
			current.Dock = DockStyle.None;
			PositionForm(current);
		}

		private void XMenuItem_Click(object sender, EventArgs e) {
			current.Close();
		}

		private void PositionForm(Form monitor) {
			monitor.Left = FormContainer.Width / 10;
			monitor.Top = FormContainer.Height / 10;
			monitor.Width = FormContainer.Width * 4 / 5;
			monitor.Height = FormContainer.Height * 4 / 5;
		}
	}
}
