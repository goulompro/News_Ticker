using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using News_Ticker.Parser;
using News_Ticker.Models;

namespace News_Ticker
{
	public partial class NewsTicker : Form
	{
		public NewsTicker()
		{
			InitializeComponent();
		}
		List<List<Panel>> panellistlist = new List<List<Panel>>();

		private void NewsTicker_Load(object sender, EventArgs e)
		{
			int news_index = 0;

			for (int i = 0; i < 6; i++)
			{
				List<Panel> panellist = new List<Panel>();
				for (int j = 0; j < 2; j++)
				{
					Panel panel = new Panel();
					panel.Size = new System.Drawing.Size(420, 110);
					panel.Location = new Point(panel.Size.Width * j, panel.Size.Height * i);
					panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

					List<news_element> new_news = new List<news_element>();
					new_news = get_news_Elements();
					
					panellist.Add(panel);
					panellist[j].Controls.Add(new_news[news_index]);
					news_index++;
				}	
				panellistlist.Add(panellist);
			}
			

				for (int i = 0; i < 4; i++)
				{		
					List<news_element> new_news = new List<news_element>();
					new_news = get_news_Elements();
					for (int j = 0; j < 2; j++)
					{
						panellistlist[i][j].Controls.Add(new_news[j]);
					}
				}

			for (int i = 0; i < 4; i++)
			{		
				List<Panel> panellist = panellistlist[i];
				for (int j = 0; j < 2; j++)
				{
					Controls.Add(panellist[j]);
				}
			}
		}

		List<news_element> get_news_Elements()
		{
			List<news_element> news = new List<news_element>();


			List<Item> new_items = new List<Item>();
			RSS_parser RSS_parser = new RSS_parser();

			new_items = RSS_parser.Parse("http://rss.sueddeutsche.de/rss/Eilmeldungen");

			foreach(Item item in new_items)
			{
				news_element single_news = new news_element(item.Title, item.Description, item.Link_to_feed, item.Source);
				news.Add(single_news); 
			}
				
			return news;
		}
	}
}
