// See https://aka.ms/new-console-template for more information




using NodaTime;
using Microsoft.Extensions.DependencyInjection;

using System.Threading.Tasks;





var easternZone = DateTimeZoneProviders.Tzdb["America/New_York"];
var nowInEasternTime = SystemClock.Instance.GetCurrentInstant().InZone(easternZone);
Console.WriteLine($"Current Eastern Time: {nowInEasternTime}");


var start = SystemClock.Instance.GetCurrentInstant();
// Simulate some processing
var end = start.Plus(Duration.FromMinutes(30));
var duration = end - start;
Console.WriteLine($"Duration: {duration}");


var startDate = new LocalDate(2024, 1, 1);
var endDate = new LocalDate(2024, 12, 31);
var period = Period.Between(startDate, endDate);
Console.WriteLine($"Period between {startDate} and {endDate}: {period.Months} months and {period.Days} days");

// Example: Calculate the last day of March, 2024
var year = 2024;
var month = 3;
var lastDayOfMonth = GetLastDayOfMonth(year, month);

Console.WriteLine($"Last day of {month}/{year} is: {lastDayOfMonth}");

 static DateTime GetLastDayOfMonth(int year, int month)
{
    // Move to the first day of the next month
    var firstDayOfNextMonth = new DateTime(year, month, 1).AddMonths(1);
    // Subtract one day to get the last day of the original month
    return firstDayOfNextMonth.AddDays(-1);
}


// Example start date and period
// Obtain the system's default time zone
DateTimeZone localZone = DateTimeZoneProviders.Tzdb.GetSystemDefault();
Instant now = SystemClock.Instance.GetCurrentInstant();
LocalDate startDate1 = now.InZone(localZone).LocalDateTime.Date;
Period period1 = Period.FromYears(1) + Period.FromMonths(2) + Period.FromDays(10);

LocalDate endDate1 = AddPeriod(startDate1, period1);
Console.WriteLine($"Starting Date: {startDate}");
Console.WriteLine($"Period: {period}");
Console.WriteLine($"End Date: {endDate1}");


static LocalDate AddPeriod(LocalDate startDate, Period period)
{
    return startDate.Plus(period);
}




Console.WriteLine("Hello, World!");
