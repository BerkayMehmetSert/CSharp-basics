var now = DateTime.Now;
var utcNow = DateTime.UtcNow;
var today = DateTime.Today;
var tomorrow = today.AddDays(1);
var yesterday = today.AddDays(-1);
var dayOfWeek = today.DayOfWeek;
var dayOfYear = today.DayOfYear;
var hour = now.Hour;
var minute = now.Minute;
var second = now.Second;
var millisecond = now.Millisecond;

// Create a DateTime object
var date = new DateTime(2023, 01, 1);
date.AddDays(2);
date.AddMonths(1);
date.AddYears(1);

Console.WriteLine("Now: " + now);
Console.WriteLine("UtcNow: " + utcNow);
Console.WriteLine("Today: " + today);
Console.WriteLine("Tomorrow: " + tomorrow);
Console.WriteLine("Yesterday: " + yesterday);
Console.WriteLine("DayOfWeek: " + dayOfWeek);
Console.WriteLine("DayOfYear: " + dayOfYear);
Console.WriteLine("Hour: " + hour);
Console.WriteLine("Minute: " + minute);
Console.WriteLine("Second: " + second);
Console.WriteLine("Millisecond: " + millisecond);
Console.WriteLine("Date: " + date);
