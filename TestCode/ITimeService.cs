using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public interface ITimeService
    {
        LocalDate Today();
        LocalDateTime NowInZone(DateTimeZone zone);
        Duration DurationBetween(LocalDateTime start, LocalDateTime end, DateTimeZone myzone);
    }
}