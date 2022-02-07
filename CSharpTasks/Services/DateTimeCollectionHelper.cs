using Kontur.Extensions;

namespace Kontur.Services;

public class DateTimeCollectionHelper
{
    //Только зачем, если есть встроенные методы... 
    //1 Задание
    public int GetCount(IEnumerable<DateTime> dateTimes) => dateTimes.Count();

    //2 Задание
    public IEnumerable<string> GetStringDate(IEnumerable<DateTime> dateTimes, string cultureInfo)
    {
        return dateTimes
            .Distinct()
            .OrderBy(time => time)
            .Select(time => time.GetStringDate(cultureInfo));
    }
    
    public IEnumerable<long> GetTicks(IEnumerable<DateTime> dateTimes)
    {
        return dateTimes.Select(time => time.Ticks);
    }
}