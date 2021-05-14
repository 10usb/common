
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
			this.StartButton = new System.Windows.Forms.ToolStripButton();
			this.StopButton = new System.Windows.Forms.ToolStripButton();
			this.ClearButton = new System.Windows.Forms.ToolStripButton();
			this.WriteButton = new System.Windows.Forms.ToolStripButton();
			this.HexToggle = new System.Windows.Forms.ToolStripButton();
			this.OpenSettings = new System.Windows.Forms.ToolStripButton();
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
            this.StartButton,
            this.StopButton,
            this.ClearButton,
            this.WriteButton,
            this.HexToggle,
            this.OpenSettings});
			this.ToolBar.Location = new System.Drawing.Point(0, 0);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Size = new System.Drawing.Size(759, 25);
			this.ToolBar.TabIndex = 0;
			this.ToolBar.Text = "toolStrip1";
			// 
			// StartButton
			// 
			this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
			this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(23, 22);
			this.StartButton.Text = "Start";
			// 
			// StopButton
			// 
			this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
			this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(23, 22);
			this.StopButton.Text = "Stop";
			// 
			// ClearButton
			// 
			this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
			this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(23, 22);
			this.ClearButton.Text = "Clear";
			// 
			// WriteButton
			// 
			this.WriteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.WriteButton.Image = ((System.Drawing.Image)(resources.GetObject("WriteButton.Image")));
			this.WriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.WriteButton.Name = "WriteButton";
			this.WriteButton.Size = new System.Drawing.Size(23, 22);
			this.WriteButton.Text = "Write";
			// 
			// HexToggle
			// 
			this.HexToggle.Checked = true;
			this.HexToggle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HexToggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.HexToggle.Image = ((System.Drawing.Image)(resources.GetObject("HexToggle.Image")));
			this.HexToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.HexToggle.Name = "HexToggle";
			this.HexToggle.Size = new System.Drawing.Size(23, 22);
			this.HexToggle.Text = "Hex";
			// 
			// OpenSettings
			// 
			this.OpenSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenSettings.Image = ((System.Drawing.Image)(resources.GetObject("OpenSettings.Image")));
			this.OpenSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenSettings.Name = "OpenSettings";
			this.OpenSettings.Size = new System.Drawing.Size(23, 22);
			this.OpenSettings.Text = "Settings";
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
			this.HexView.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.HexView.Location = new System.Drawing.Point(3, 3);
			this.HexView.Name = "HexView";
			this.HexView.Size = new System.Drawing.Size(100, 96);
			this.HexView.TabIndex = 3;
			this.HexView.Text = "";
			this.HexView.VisibleChanged += new System.EventHandler(this.HexView_VisibleChanged);
			// 
			// TextView
			// 
			this.TextView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextView.Location = new System.Drawing.Point(109, 3);
			this.TextView.Name = "TextView";
			this.TextView.Size = new System.Drawing.Size(100, 96);
			this.TextView.TabIndex = 4;
			this.TextView.Text = "";
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
		private System.Windows.Forms.ToolStripStatusLabel BaudStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel DataStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel StopStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel ParityStatusLabel;
		private System.Windows.Forms.ToolStripButton StartButton;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton HexToggle;
		private System.Windows.Forms.RichTextBox HexView;
		private System.Windows.Forms.RichTextBox TextView;
		private System.Windows.Forms.Panel ViewPanel;
		private System.Windows.Forms.ToolStripButton OpenSettings;
		private System.Windows.Forms.ToolStripButton StopButton;
		private System.Windows.Forms.ToolStripButton ClearButton;
		private System.Windows.Forms.ToolStripButton WriteButton;
	}
}