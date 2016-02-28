using System;

namespace BerlinClock
{
	//Time Object Class
	public class Time
	{
		private int hours;
		private int minutes;
		private int seconds;

		//Getter Hours
		public int getHours()
		{
			return hours;
		}

		//Setter Hours
		public void setHours(int hours)
		{
			this.hours = hours;
		}

		//Getter Minutes
		public int getMinutes()
		{
			return minutes;
		}

		//Setter Minutes
		public void setMinutes(int minutes)
		{
			this.minutes = minutes;
		}

		//Getter Seconds
		public int getSeconds()
		{
			return seconds;
		}

		//Setter Seconds
		public void setSeconds(int seconds)
		{
			this.seconds = seconds;
		}
	}
}

