
namespace News_Ticker
{
	partial class news_element
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lbl_titel = new System.Windows.Forms.Label();
			this.lnklbl_go_to_articel = new System.Windows.Forms.LinkLabel();
			this.lbl_source = new System.Windows.Forms.Label();
			this.rtxtBox_Description = new System.Windows.Forms.RichTextBox();
			this.tmer_Slider = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lbl_titel
			// 
			this.lbl_titel.AutoSize = true;
			this.lbl_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titel.Location = new System.Drawing.Point(5, 7);
			this.lbl_titel.Name = "lbl_titel";
			this.lbl_titel.Size = new System.Drawing.Size(95, 24);
			this.lbl_titel.TabIndex = 0;
			this.lbl_titel.Text = "Titel fehlt";
			// 
			// lnklbl_go_to_articel
			// 
			this.lnklbl_go_to_articel.AutoSize = true;
			this.lnklbl_go_to_articel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnklbl_go_to_articel.Location = new System.Drawing.Point(286, 86);
			this.lnklbl_go_to_articel.Name = "lnklbl_go_to_articel";
			this.lnklbl_go_to_articel.Size = new System.Drawing.Size(128, 16);
			this.lnklbl_go_to_articel.TabIndex = 2;
			this.lnklbl_go_to_articel.TabStop = true;
			this.lnklbl_go_to_articel.Text = "Weiter zum Artikel ->";
			this.lnklbl_go_to_articel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_go_to_articel_LinkClicked);
			// 
			// lbl_source
			// 
			this.lbl_source.AutoSize = true;
			this.lbl_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_source.Location = new System.Drawing.Point(6, 89);
			this.lbl_source.Name = "lbl_source";
			this.lbl_source.Size = new System.Drawing.Size(69, 15);
			this.lbl_source.TabIndex = 4;
			this.lbl_source.Text = "Quelle fehlt";
			// 
			// rtxtBox_Description
			// 
			this.rtxtBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtxtBox_Description.Location = new System.Drawing.Point(9, 35);
			this.rtxtBox_Description.Name = "rtxtBox_Description";
			this.rtxtBox_Description.Size = new System.Drawing.Size(405, 48);
			this.rtxtBox_Description.TabIndex = 5;
			this.rtxtBox_Description.Text = "";
			// 
			// tmer_Slider
			// 
			this.tmer_Slider.Enabled = true;
			this.tmer_Slider.Interval = 50;
			this.tmer_Slider.Tick += new System.EventHandler(this.tmer_Slider_Tick);
			// 
			// news_element
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.rtxtBox_Description);
			this.Controls.Add(this.lbl_source);
			this.Controls.Add(this.lnklbl_go_to_articel);
			this.Controls.Add(this.lbl_titel);
			this.Name = "news_element";
			this.Size = new System.Drawing.Size(420, 110);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_titel;
		private System.Windows.Forms.LinkLabel lnklbl_go_to_articel;
		private System.Windows.Forms.Label lbl_source;
		private System.Windows.Forms.RichTextBox rtxtBox_Description;
		private System.Windows.Forms.Timer tmer_Slider;
	}
}