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
	public partial class YesNo : UserControl
	{
		public bool Value {
			get {
				return Yes.Checked;
			}
			set {
				if (value) {
					Yes.Checked = true;
				} else {
					No.Checked = true;
				}
			}
		}

		public YesNo() {
			InitializeComponent();
		}
	}
}
