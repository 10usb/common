﻿using System;
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
	public partial class MonitorForm : Form
	{
		public MonitorForm(string portName) {
			InitializeComponent();
			HexToggle.Click += HexToggle_Click;
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
