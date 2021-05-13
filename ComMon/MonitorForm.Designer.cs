
namespace ComMon
{
	partial class MonitorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorForm));
			this.ToolBar = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.HexToggle = new System.Windows.Forms.ToolStripButton();
			this.Status = new System.Windows.Forms.StatusStrip();
			this.BaudStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.DataStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.StopStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ParityStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.HexView = new System.Windows.Forms.RichTextBox();
			this.TextView = new System.Windows.Forms.RichTextBox();
			this.ViewPanel = new System.Windows.Forms.Panel();
			this.ToolBar.SuspendLayout();
			this.Status.SuspendLayout();
			this.ViewPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ToolBar
			// 
			this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.HexToggle});
			this.ToolBar.Location = new System.Drawing.Point(0, 0);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Size = new System.Drawing.Size(759, 25);
			this.ToolBar.TabIndex = 0;
			this.ToolBar.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
			this.toolStripLabel1.Text = "COM1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
			this.toolStripButton1.Text = "Start";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(51, 22);
			this.toolStripButton2.Text = "Stop";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(54, 22);
			this.toolStripButton3.Text = "Clear";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(55, 22);
			this.toolStripButton4.Text = "Write";
			// 
			// HexToggle
			// 
			this.HexToggle.Checked = true;
			this.HexToggle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HexToggle.Image = ((System.Drawing.Image)(resources.GetObject("HexToggle.Image")));
			this.HexToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.HexToggle.Name = "HexToggle";
			this.HexToggle.Size = new System.Drawing.Size(48, 22);
			this.HexToggle.Text = "Hex";
			// 
			// Status
			// 
			this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaudStatusLabel,
            this.DataStatusLabel,
            this.StopStatusLabel,
            this.ParityStatusLabel});
			this.Status.Location = new System.Drawing.Point(0, 509);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(759, 24);
			this.Status.TabIndex = 2;
			this.Status.Text = "statusStrip1";
			// 
			// BaudStatusLabel
			// 
			this.BaudStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.BaudStatusLabel.Name = "BaudStatusLabel";
			this.BaudStatusLabel.Size = new System.Drawing.Size(80, 19);
			this.BaudStatusLabel.Text = "Baud: 115200";
			// 
			// DataStatusLabel
			// 
			this.DataStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.DataStatusLabel.Name = "DataStatusLabel";
			this.DataStatusLabel.Size = new System.Drawing.Size(47, 19);
			this.DataStatusLabel.Text = "Data: 8";
			// 
			// StopStatusLabel
			// 
			this.StopStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.StopStatusLabel.Name = "StopStatusLabel";
			this.StopStatusLabel.Size = new System.Drawing.Size(56, 19);
			this.StopStatusLabel.Text = "Stop: 1,5";
			// 
			// ParityStatusLabel
			// 
			this.ParityStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.ParityStatusLabel.Name = "ParityStatusLabel";
			this.ParityStatusLabel.Size = new System.Drawing.Size(72, 19);
			this.ParityStatusLabel.Text = "Parity: Even";
			// 
			// HexView
			// 
			this.HexView.Location = new System.Drawing.Point(3, 3);
			this.HexView.Name = "HexView";
			this.HexView.Size = new System.Drawing.Size(100, 96);
			this.HexView.TabIndex = 3;
			this.HexView.Text = "Hex";
			this.HexView.VisibleChanged += new System.EventHandler(this.HexView_VisibleChanged);
			// 
			// TextView
			// 
			this.TextView.Location = new System.Drawing.Point(109, 3);
			this.TextView.Name = "TextView";
			this.TextView.Size = new System.Drawing.Size(100, 96);
			this.TextView.TabIndex = 4;
			this.TextView.Text = "Text";
			// 
			// ViewPanel
			// 
			this.ViewPanel.Controls.Add(this.TextView);
			this.ViewPanel.Controls.Add(this.HexView);
			this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ViewPanel.Location = new System.Drawing.Point(0, 25);
			this.ViewPanel.Name = "ViewPanel";
			this.ViewPanel.Size = new System.Drawing.Size(759, 484);
			this.ViewPanel.TabIndex = 6;
			this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
			// 
			// MonitorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 533);
			this.Controls.Add(this.ViewPanel);
			this.Controls.Add(this.Status);
			this.Controls.Add(this.ToolBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MonitorForm";
			this.Text = "MonitorForm";
			this.ToolBar.ResumeLayout(false);
			this.ToolBar.PerformLayout();
			this.Status.ResumeLayout(false);
			this.Status.PerformLayout();
			this.ViewPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip ToolBar;
		private System.Windows.Forms.StatusStrip Status;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel BaudStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel DataStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel StopStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel ParityStatusLabel;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton HexToggle;
		private System.Windows.Forms.RichTextBox HexView;
		private System.Windows.Forms.RichTextBox TextView;
		private System.Windows.Forms.Panel ViewPanel;
	}
}