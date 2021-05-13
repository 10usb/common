
namespace ComMon
{
	partial class YesNo
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Yes = new System.Windows.Forms.RadioButton();
			this.No = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// Yes
			// 
			this.Yes.AutoSize = true;
			this.Yes.Location = new System.Drawing.Point(0, 0);
			this.Yes.Name = "Yes";
			this.Yes.Size = new System.Drawing.Size(42, 19);
			this.Yes.TabIndex = 0;
			this.Yes.TabStop = true;
			this.Yes.Text = "Yes";
			this.Yes.UseVisualStyleBackColor = true;
			// 
			// No
			// 
			this.No.AutoSize = true;
			this.No.Location = new System.Drawing.Point(48, 0);
			this.No.Name = "No";
			this.No.Size = new System.Drawing.Size(41, 19);
			this.No.TabIndex = 1;
			this.No.TabStop = true;
			this.No.Text = "No";
			this.No.UseVisualStyleBackColor = true;
			// 
			// YesNo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.No);
			this.Controls.Add(this.Yes);
			this.Name = "YesNo";
			this.Size = new System.Drawing.Size(90, 19);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton Yes;
		private System.Windows.Forms.RadioButton No;
	}
}
