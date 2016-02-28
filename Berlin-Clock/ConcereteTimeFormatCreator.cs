using System;

namespace BerlinClock
{
	public class ConcereteTimeFormatCreator:TimeFormatCreator
	{
		//Dependency Injection for Setting the input Time Format
		public override TimeFormatInterface SetTimeFormat(string format)
		{
			switch (format)
			{
				case "1": return new FormatSimple();
				default: return new FormatDefault();
			}
		}

		//Dependency Injection for Setting the output Time Format
		public override TimeFormatInterface GetTimeFormat(string format)
		{
			switch (format)
			{
				case "1": return new FormatSimple();	
				case "2": return new FormatBerlinClock();
				default: return new FormatDefault();
			}
		}
	}
}

