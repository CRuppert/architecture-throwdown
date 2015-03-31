using System;
using System.Collections.Generic;
using System.Linq;

namespace architecture_throwdown.Models
{
	public class HomePageViewModel
	{
		public HomePageViewModel(IEnumerable<SlamViewModel> slams)
		{
			this.Slams = slams.ToArray();

			if (Slams == null) { Slams = new SlamViewModel[] { }; }
		}
		public SlamViewModel[] Slams { get; set; }
	}

    public class SlamViewModel
    {
		public SlamViewModel(string text)
		{
			Text = text;
		}
		//public string Id { get; set; }
		public string Text { get; set; }
    }
}