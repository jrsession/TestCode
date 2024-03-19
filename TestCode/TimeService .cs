using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{



    public class TimeService : ITimeService
    {
        public LocalDate Today() => LocalDate.FromDateTime(DateTime.UtcNow);

        public LocalDateTime NowInZone(DateTimeZone zone) => SystemClock.Instance.GetCurrentInstant().InZone(zone).LocalDateTime;

        public Duration DurationBetween(LocalDateTime start, LocalDateTime end, DateTimeZone myzone) => end.InZoneLeniently(myzone) - start.InZoneLeniently(myzone);
    }
}
