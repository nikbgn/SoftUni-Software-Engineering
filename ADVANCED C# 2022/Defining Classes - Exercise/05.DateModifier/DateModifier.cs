﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int CalculateDifference(string firstDate,string secondDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);

            int result = (int)(first - second).TotalDays;

            return Math.Abs(result);

        }
    }
}
