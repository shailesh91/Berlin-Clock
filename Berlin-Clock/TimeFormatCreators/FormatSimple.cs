using System;

namespace BerlinClock
{
	public class FormatSimple:TimeFormatInterface
	{
		//Accepts String to convert Simple Input Format hh:mm:ss to Time Object, Throws Application Exception for wrong format
		public Time SetInput(String time)
		{
			string[] timeValues =time.Split(new string[] {":"},StringSplitOptions.None);
			Time t = new Time ();
			t.setHours (Int32.Parse(timeValues[0]));
			t.setMinutes (Int32.Parse(timeValues[1]));
			t.setSeconds (Int32.Parse(timeValues[2]));
			return t;
		}

		//Accepts Time Object to Output Simple Format hh:mm:ss as a String
		public String GetOutput(Time time)
		{
			return time.getHours() +":"+time.getMinutes()+":"+time.getSeconds();
		}
	}
}

