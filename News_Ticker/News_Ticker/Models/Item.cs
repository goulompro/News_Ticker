using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace News_Ticker.Models 
{
	class Item : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string title;
		private string date_of_publication;
		private string description;
		private string link_to_feed;
		private string guid;
		private string source;
		private bool read;

		public string Title { get => title; set => title = value; }
		public string Date_of_publication { get => date_of_publication; set => date_of_publication = value; }
		public string Link_to_feed { get => link_to_feed; set => link_to_feed = value; }
		public string Guid { get => guid; set => guid = value; }
		public string Source { get => source; set => source = value; }
		public bool Read { get => read; set => read = value; }
		public string Description { get => description; set => description = value; }
	}
}
