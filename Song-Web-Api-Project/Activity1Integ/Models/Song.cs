using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Integ.Models
{
    public class Song
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Artist { get; set; }
		public string Genre { get; set; }
		public string Duration { get; set; }
		public int ReleaseYear { get; set; }
		public string RecordLabel { get; set; }
		public int PeakChartPosition { get; set; }
	}

}
