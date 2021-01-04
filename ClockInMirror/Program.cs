using System;

namespace ClockInMirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WhatIsTheTime("05:25"));
        }

        public static string WhatIsTheTime(string timeInMirror)
        {
            var mirrorHours = Int32.Parse((timeInMirror.Split(":"))[0]);
            var mirrorMinutes = Int32.Parse((timeInMirror.Split(":"))[1]);

            if (mirrorHours == 12) mirrorHours = 0;

            var actualHours = Math.Abs(mirrorHours-12);
            
            if (mirrorMinutes != 0)
            {
                actualHours -= 1;
            }

            var actualMinutes = 60 - mirrorMinutes;
            if (actualMinutes == 60) actualMinutes = 0;
            if (actualHours == 0) actualHours = 12;

            var actualHoursString = actualHours.ToString();
            if (actualHours < 10)
            {
                actualHoursString = "0" + actualHoursString;
            }

            var actualMinutesString = actualMinutes.ToString();
            if (actualMinutes < 10)
            {
                actualMinutesString = "0" + actualMinutesString;
            }

            return actualHoursString+":"+actualMinutesString;
        }
    }
}