
namespace ComMon
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.SaveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ShutdownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.XMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FormContainer = new System.Windows.Forms.Panel();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.AboutMenuItem,
            this.XMenuItem,
            this.WMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(604, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.CloseMenuItem,
            this.toolStripSeparator1,
            this.SaveAllMenuItem,
            this.CloseAllMenuItem,
            this.toolStripSeparator2,
            this.ShutdownMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileMenuItem.Text = "File";
			// 
			// OpenMenuItem
			// 
			this.OpenMenuItem.Name = "OpenMenuItem";
			this.OpenMenuItem.Size = new System.Drawing.Size(120, 22);
			this.OpenMenuItem.Text = "Open";
			// 
			// SaveMenuItem
			// 
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.Size = new System.Drawing.Size(120, 22);
			this.SaveMenuItem.Text = "Save";
			// 
			// CloseMenuItem
			// 
			this.CloseMenuItem.Name = "CloseMenuItem";
			this.CloseMenuItem.Size = new System.Drawing.Size(120, 22);
			this.CloseMenuItem.Text = "Close";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
			// 
			// SaveAllMenuItem
			// 
			this.SaveAllMenuItem.Name = "SaveAllMenuItem";
			this.SaveAllMenuItem.Size = new System.Drawing.Size(120, 22);
			this.SaveAllMenuItem.Text = "Save All";
			// 
			// CloseAllMenuItem
			// 
			this.CloseAllMenuItem.Name = "CloseAllMenuItem";
			this.CloseAllMenuItem.Size = new System.Drawing.Size(120, 22);
			this.CloseAllMenuItem.Text = "Close All";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
			// 
			// ShutdownMenuItem
			// 
			this.ShutdownMenuItem.Name = "ShutdownMenuItem";
			this.ShutdownMenuItem.Size = new System.Drawing.Size(120, 22);
			this.ShutdownMenuItem.Text = "Close";
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(52, 20);
			this.AboutMenuItem.Text = "About";
			// 
			// XMenuItem
			// 
			this.XMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.XMenuItem.Checked = true;
			this.XMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.XMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.XMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("XMenuItem.Image")));
			this.XMenuItem.Name = "XMenuItem";
			this.XMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.XMenuItem.Size = new System.Drawing.Size(20, 20);
			this.XMenuItem.Text = "X";
			// 
			// WMenuItem
			// 
			this.WMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.WMenuItem.Checked = true;
			this.WMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.WMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.WMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("WMenuItem.Image")));
			this.WMenuItem.Name = "WMenuItem";
			this.WMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.WMenuItem.Size = new System.Drawing.Size(20, 20);
			this.WMenuItem.Text = "N";
			// 
			// FormContainer
			// 
			this.FormContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormContainer.Location = new System.Drawing.Point(0, 24);
			this.FormContainer.Name = "FormContainer";
			this.FormContainer.Size = new System.Drawing.Size(604, 637);
			this.FormContainer.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 661);
			this.Controls.Add(this.FormContainer);
			this.Controls.Add(this.MainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MinimumSize = new System.Drawing.Size(450, 260);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "COM Monitor";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem SaveAllMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseAllMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ShutdownMenuItem;
		private System.Windows.Forms.ToolStripMenuItem XMenuItem;
		private System.Windows.Forms.ToolStripMenuItem WMenuItem;
		private System.Windows.Forms.Panel FormContainer;
	}
}

