using Kontur.Services;

var times = new List<DateTime>
{
    new(2019, 03, 09),
    new(1990, 06, 11),
    new(2019, 09, 03),
    new(2018, 12, 31),
    new(2017, 05, 09),
};

var helper = new DateTimeCollectionHelper();
Console.WriteLine(helper.GetCount(times));
Console.WriteLine(string.Join(", ", helper.GetStringDate(times, "Ru")));
Console.WriteLine(string.Join(", ", helper.GetTicks(times)));