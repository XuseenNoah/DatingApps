using System;

namespace API.Extensions
{
    public static class DateTimeExtentions
    {
        public static int CalCulateAGe(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (today.Date > dob.Date.AddYears(-age)) return age--;
            return age;
        }
    }
}