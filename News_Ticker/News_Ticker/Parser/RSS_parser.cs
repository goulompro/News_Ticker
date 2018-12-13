using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News_Ticker.Models;
using System.Xml.Linq;

namespace News_Ticker.Parser
{
	class RSS_parser : Item
	{
		public List<Item> Parse(string url)
		{
			try
			{
				XDocument feed = XDocument.Load(url);

				if (feed.Elements().Count() == 0) return null;

				XNamespace ns = "http://purl.org/rss/1.0/modules/slash/";

				string source = (from ele in feed.Descendants("channel").Elements("title") select ele.Value).Single();

				List<Item> items = (from item in feed.Descendants("item")
										select new Item
										{
											Title = item.Element("title").Value,
											Date_of_publication = (item.Element("pubDate").Value ?? ""),
											Link_to_feed = item.Element("link").Value,
											Description = (item.Element("description").Value ?? ""),
											Guid = (item.Element("guid") != null ? item.Element("guid").Value : item.Element("link").Value),
											Source = source
										}).ToList();

				return items;
			}
			catch
			{
				return null;
			}
		}
	}
}
