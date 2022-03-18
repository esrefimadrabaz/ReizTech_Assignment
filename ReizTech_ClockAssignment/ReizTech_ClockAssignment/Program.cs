using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_ClockAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string Input;
            int[] hours_minutes;
            while (true)
            {
                Console.WriteLine("Input Hours and Minutes (hour:minute)(in 12 hours format): ");
                Input = Console.ReadLine();
                hours_minutes = program.CheckInputFormat(Input);
                int degree_hour = program.ConvertHoursToDegrees(hours_minutes[0]);
                int degree_min = program.ConvertMinuteToDegrees(hours_minutes[1]);
                int LesserAngle = Math.Abs(degree_hour - degree_min); 
                if (LesserAngle > 180) { LesserAngle = 360 - LesserAngle; }
                Console.WriteLine("Hours to Degrees = " + degree_hour.ToString());
                Console.WriteLine("Minute to Degrees = " + degree_min.ToString());
                Console.WriteLine("Degree of lesser angle between hours and minutes arm: " + LesserAngle.ToString());
                Console.ReadLine();
            }
        }

        private int[] CheckInputFormat(string input)
        {
            if (!input.Contains(":"))
            {
                throw new Exception("Please seperate hour and minutes with ':'.");
            }
            string[] hour_minute = input.Split(':');
            int hour = Convert.ToInt32(hour_minute[0]);
            int minute = Convert.ToInt32(hour_minute[1]);
            if((hour > 12) || (hour < 1))
            {
                throw new Exception("Hour should be in between 1 and 12.");
            }
            if ((minute > 60) || (minute < 1))
            {
                throw new Exception("Minute should be in between 1 and 60.");
            }
            if(minute == 60) { minute = 0; }
            if (hour == 12) { hour = 0; }
            int[] hours_minutes = { hour, minute };
            return hours_minutes;
        }
        private int ConvertHoursToDegrees(int hours)
        {
            decimal degree = hours / 12m * 360m;
            return Convert.ToInt32(degree);
        }
        private int ConvertMinuteToDegrees(int minutes)
        {
            decimal degree = minutes / 60m * 360m;
            return Convert.ToInt32(degree);
        }
    }
}
