using System;
using System.Text.RegularExpressions;

namespace BerlinClock
{
	public class FormatBerlinClock:TimeFormatInterface
	{
		private String color1 = "Y"; //Yellow Color
		private String color2 = "R"; //Red Color
		private String colorOff = "O"; //Off Color

		//Accepts String to convert Simple Input Format hh:mm:ss to Time Object, not Implemented, Throws Application Exception
		public Time SetInput(String time)
		{
			throw new ApplicationException(string.Format("Input Time Format not Supported Yet!"));
		}

		//Accepts Time Object to Output Berlin Clock Format String
		public String GetOutput(Time time){
			return getSeconds (time.getSeconds ()) + " " + getHours (time.getHours ()) + " " + getMinutes (time.getMinutes ());
		}


		private String getHours(int hours)
		{
			return getOnOff(4, (hours - (hours % 5)) / 5) + " " + getOnOff(4, hours % 5);
		}

		private String getMinutes(int minutes) 
		{
			return Regex.Replace(getOnOff(11, (minutes - (minutes % 5)) / 5, color1),color1+color1+color1,color1+color1+color2) + " " +
				getOnOff(4, minutes % 5, color1);
		}

		private String getSeconds(int seconds) 
		{
			if (seconds % 2 == 0) 
				return color1;
			else 
				return colorOff;
		}

		private String getOnOff(int lamps, int onSigns) 
		{
			return getOnOff(lamps, onSigns, color2);
		}

		private String getOnOff(int lamps, int onSigns, String onSign) 
		{
			String output = "";
			for (int i = 0; i < onSigns; i++) 
			{
				output += onSign;
			}
			for (int i = 0; i < (lamps - onSigns); i++) 
			{
				output += colorOff;
			}
			return output;
		}
			
	}
}

