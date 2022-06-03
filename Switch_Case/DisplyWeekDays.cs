using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Switch_Case
{
	class DisplyWeekDays
	{
		static void Main(string[] args)
		{

			Console.Write("Input Day No : ");
			int DayNumber = Convert.ToInt32(Console.ReadLine());

			switch (DayNumber)
			{
				case 1:
					Console.Write("Monday \n");
					break;
				case 2:
					Console.Write("Tuesday \n");
					break;
				case 3:
					Console.Write("Wednesday \n");
					break;
				case 4:
					Console.Write("Thursday \n");
					break;
				case 5:
					Console.Write("Friday \n");
					break;
				case 6:
					Console.Write("Saturday \n");
					break;
				case 7:
					Console.Write("Sunday  \n");
					break;
				default:
					Console.Write("Invalid day number. \n");
					break;

			}
		}
	}
}
