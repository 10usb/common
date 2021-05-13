
namespace ComMon
{
	partial class PortSettingsDialog
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ApplySetting = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.ParityReplace = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.DiscardNull = new ComMon.YesNo();
			this.RtsEnable = new ComMon.YesNo();
			this.DtrEnable = new ComMon.YesNo();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.StopBits = new System.Windows.Forms.ComboBox();
			this.Parity = new System.Windows.Forms.ComboBox();
			this.DataBits = new System.Windows.Forms.ComboBox();
			this.Handshake = new System.Windows.Forms.ComboBox();
			this.Baudrate = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 320);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ButtonCancel);
			this.panel1.Controls.Add(this.ApplySetting);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 283);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 34);
			this.panel1.TabIndex = 1;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.Location = new System.Drawing.Point(84, 3);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 1;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// ApplySetting
			// 
			this.ApplySetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ApplySetting.Location = new System.Drawing.Point(165, 3);
			this.ApplySetting.Name = "ApplySetting";
			this.ApplySetting.Size = new System.Drawing.Size(75, 23);
			this.ApplySetting.TabIndex = 0;
			this.ApplySetting.Text = "Apply";
			this.ApplySetting.UseVisualStyleBackColor = true;
			this.ApplySetting.Click += new System.EventHandler(this.ButtonOpen_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.ParityReplace);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.DiscardNull);
			this.panel2.Controls.Add(this.RtsEnable);
			this.panel2.Controls.Add(this.DtrEnable);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.StopBits);
			this.panel2.Controls.Add(this.Parity);
			this.panel2.Controls.Add(this.DataBits);
			this.panel2.Controls.Add(this.Handshake);
			this.panel2.Controls.Add(this.Baudrate);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(249, 274);
			this.panel2.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 15);
			this.label9.TabIndex = 24;
			this.label9.Text = "Replace byte";
			// 
			// ParityReplace
			// 
			this.ParityReplace.Location = new System.Drawing.Point(119, 126);
			this.ParityReplace.Name = "ParityReplace";
			this.ParityReplace.Size = new System.Drawing.Size(40, 23);
			this.ParityReplace.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 235);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 15);
			this.label8.TabIndex = 22;
			this.label8.Text = "Discard NULL";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 210);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 15);
			this.label7.TabIndex = 21;
			this.label7.Text = "RTS";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 15);
			this.label6.TabIndex = 20;
			this.label6.Text = "DTR";
			// 
			// DiscardNull
			// 
			this.DiscardNull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DiscardNull.Location = new System.Drawing.Point(119, 235);
			this.DiscardNull.Name = "DiscardNull";
			this.DiscardNull.Size = new System.Drawing.Size(90, 19);
			this.DiscardNull.TabIndex = 19;
			this.DiscardNull.Value = false;
			// 
			// RtsEnable
			// 
			this.RtsEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RtsEnable.Location = new System.Drawing.Point(119, 210);
			this.RtsEnable.Name = "RtsEnable";
			this.RtsEnable.Size = new System.Drawing.Size(90, 19);
			this.RtsEnable.TabIndex = 17;
			this.RtsEnable.Value = false;
			// 
			// DtrEnable
			// 
			this.DtrEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DtrEnable.Location = new System.Drawing.Point(119, 185);
			this.DtrEnable.Name = "DtrEnable";
			this.DtrEnable.Size = new System.Drawing.Size(90, 19);
			this.DtrEnable.TabIndex = 16;
			this.DtrEnable.Value = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "StopBits";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Parity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Data bits";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Handshake";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Baud rate";
			// 
			// StopBits
			// 
			this.StopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StopBits.FormattingEnabled = true;
			this.StopBits.Location = new System.Drawing.Point(119, 155);
			this.StopBits.Name = "StopBits";
			this.StopBits.Size = new System.Drawing.Size(121, 23);
			this.StopBits.TabIndex = 4;
			// 
			// Parity
			// 
			this.Parity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Parity.FormattingEnabled = true;
			this.Parity.Location = new System.Drawing.Point(119, 96);
			this.Parity.Name = "Parity";
			this.Parity.Size = new System.Drawing.Size(121, 23);
			this.Parity.TabIndex = 3;
			// 
			// DataBits
			// 
			this.DataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DataBits.FormattingEnabled = true;
			this.DataBits.Location = new System.Drawing.Point(119, 67);
			this.DataBits.Name = "DataBits";
			this.DataBits.Size = new System.Drawing.Size(121, 23);
			this.DataBits.TabIndex = 2;
			// 
			// Handshake
			// 
			this.Handshake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Handshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Handshake.FormattingEnabled = true;
			this.Handshake.Location = new System.Drawing.Point(119, 38);
			this.Handshake.Name = "Handshake";
			this.Handshake.Size = new System.Drawing.Size(121, 23);
			this.Handshake.TabIndex = 1;
			// 
			// Baudrate
			// 
			this.Baudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Baudrate.FormattingEnabled = true;
			this.Baudrate.Location = new System.Drawing.Point(119, 9);
			this.Baudrate.Name = "Baudrate";
			this.Baudrate.Size = new System.Drawing.Size(121, 23);
			this.Baudrate.TabIndex = 0;
			// 
			// PortSettings
			// 
			this.AcceptButton = this.ApplySetting;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonCancel;
			this.ClientSize = new System.Drawing.Size(255, 320);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PortSettings";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ApplySetting;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox StopBits;
		private System.Windows.Forms.ComboBox Parity;
		private System.Windows.Forms.ComboBox DataBits;
		private System.Windows.Forms.ComboBox Handshake;
		private System.Windows.Forms.ComboBox Baudrate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private YesNo RtsEnable;
		private YesNo DtrEnable;
		private YesNo DiscardNull;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox ParityReplace;
		private System.Windows.Forms.Label label9;
	}
}