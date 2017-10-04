using System;
using System.Globalization;

public class DateModifier
    {
        public static void CalculateDifference(string firsDate, string secondDate)
        {
            var fDate = DateTime.ParseExact(firsDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var seDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan span = seDate.Subtract(fDate);
            Console.WriteLine(Math.Abs(span.Days));
        }
    }

