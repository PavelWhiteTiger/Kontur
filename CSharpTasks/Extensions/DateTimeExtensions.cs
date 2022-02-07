using System.Globalization;

namespace Kontur.Extensions
{
    public static class DateTimeExtensions
    {
        public static string GetStringDate(this DateTime dateTime, string cultureInfo)
        {
            return dateTime.ToString("dd MMMM yyyy года", new CultureInfo(cultureInfo));
        }
    }
}