using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News_Ticker
{
	public partial class news_element : UserControl
	{
		public news_element()
		{
			this.InitializeComponent();
		}

		public news_element(string lbl_titel, string lbl_description, string lnklbl_go_to_articel, string lbl_source)
		{
			this.InitializeComponent();

			LinkLabel.Link link = new LinkLabel.Link();
			link.LinkData =  lnklbl_go_to_articel;

			this.lbl_titel.Text = lbl_titel;
			this.lbl_description.Text = lbl_description;
			this.lnklbl_go_to_articel.Links.Add(link);
			this.lbl_source.Text = lbl_source;
		}

		private void lnklbl_go_to_articel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData as string);
		}
	}
}
