﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VocaDbContracts {
	public class SongForApiContract {
		public string name { get; set; }
		public LyricsForSongContract[] lyrics { get; set; }
	}
}
