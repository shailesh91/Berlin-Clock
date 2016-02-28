using System;

namespace BerlinClock
{
	class MainClass
	{		
		public static void Main (string[] args)
		{
			TimeFormatCreator factory = new ConcereteTimeFormatCreator();

			try
			{
				Console.WriteLine("Input Format Type:\n1. Simple(hh:mm:ss) ");
				String inputTimeFormat = Console.ReadLine();
				TimeFormatInterface inputFormat = factory.SetTimeFormat(inputTimeFormat);
				try
				{
					Console.WriteLine("Enter Time:");
					String t = Console.ReadLine();
					Time inputTime = inputFormat.SetInput(t);
					try
					{
						Console.WriteLine("Output Format Type:\n1. Default \n2. BerlinClock");
						String outputTimeFormat = Console.ReadLine();
						TimeFormatInterface outputFormat = factory.GetTimeFormat(outputTimeFormat);	
						Console.WriteLine("\nOutput Time:");
						Console.WriteLine(outputFormat.GetOutput(inputTime));
					}
					catch(Exception eee)
					{
						Console.WriteLine(eee.Message);
					}
				}
				catch(Exception ee)
				{
					Console.WriteLine(ee.Message);
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
