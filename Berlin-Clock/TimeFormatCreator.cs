using System;

namespace BerlinClock
{
	public abstract class TimeFormatCreator
	{
		//Gets the Input Time Format
		public abstract TimeFormatInterface SetTimeFormat(string format);

		//Gets the Output Time Format
		public abstract TimeFormatInterface GetTimeFormat(string format);
	}
}

