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

		//Accepts Time Object to Output Berlin Clock Format String - L to R
		public String GetOutput(Time time){
			return getSeconds (time.getSeconds ()) + " " + getHours (time.getHours ()) + " " + getMinutes (time.getMinutes ());
		}

		//Converts Hours - Second and Third Rows
		private String getHours(int hours)
		{
			return getLampState(4, (hours - (hours % 5)) / 5) + " " + getLampState(4, hours % 5);
		}

		//Converts Minutes - Bottom Two Rows
		private String getMinutes(int minutes) 
		{
			return Regex.Replace(getLampState(11, (minutes - (minutes % 5)) / 5, color1),color1+color1+color1,color1+color1+color2) + " " +
				getLampState(4, minutes % 5, color1);
		}

		//Converts Seconds - Top Row
		private String getSeconds(int seconds) 
		{
			if (seconds % 2 == 0) 
				return color1;
			else 
				return colorOff;
		}

		//Checks Whether the Lamp is On/Off
		private String getLampState(int lamps, int onLight) 
		{
			return getLampState(lamps, onLight, color2);
		}

		//Checks Whether the Lamp is On/Off
		private String getLampState(int lamps, int onLights, String onLight) 
		{
			String output = "";
			for (int i = 0; i < onLights; i++) 
			{
				output += onLight;
			}
			for (int i = 0; i < (lamps - onLights); i++) 
			{
				output += colorOff;
			}
			return output;
		}
			
	}
}

