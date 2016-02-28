using System;

namespace BerlinClock
{
	public class FormatDefault:TimeFormatInterface
	{
		//Default Input Format not Implemented or if not Input Format not Recognized, Throws Application Exception
		public Time SetInput(String time)
		{
			 throw new ApplicationException(string.Format("Input Time Format not Supported Yet!"));
		}

		//Default Output Format not Implemented or if not Input Format not Recognized, Throws Application Exception
		public String GetOutput(Time time)
		{
			throw new ApplicationException(string.Format("Ouptut Time Format not Supported Yet!"));
		}
	}
}

