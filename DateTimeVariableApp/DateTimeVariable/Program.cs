using System.Globalization;

//  DateTime Variable

/// DateTime is complicated because it is different for different people according to their locale.
/// DateTime is a complex object that holds the date and time.

// Gets the date and time right now
DateTime today = DateTime.Now;


/// WriteLine automatically applies .ToString
Console.WriteLine(today.ToString());


// Applying format with .ToString
Console.WriteLine(today.ToString("d"));


// Date Complexity
/// In USA date format is:  MM / dd / yyyy  (month / day / year)
/// But in the rest of the world : dd / MM / yyyy
/// You MUST know the locale you're working with.
/// 

/// You need to be carefull, if not you could have bugs. Some of them will crash the app; some will not crash the app, but the behaivour will be different from the expected


// Parse uses the locale where you are
DateTime birthday = DateTime.Parse("6/15/1998");
Console.WriteLine(birthday);


Console.WriteLine("=============");

Console.WriteLine();


// ParseExact you can specify the format, and ignore the locale, and using the format
var birthday2 = DateTime.ParseExact("06/11/1998", "MM/dd/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday2);

Console.WriteLine();

Console.WriteLine("=============");


// Formating with ToString with K - Time zone
Console.WriteLine("With Time Zone: {0}",today.ToString("MMMM dd, yyyy HH:mm K"));

Console.WriteLine();

Console.WriteLine("With AM/PM: {0}", today.ToString("MMMM dd, yyyy HH:mm tt"));

Console.WriteLine();

// Time zone and simplifying interpolation
Console.WriteLine($"With Time Zone {today:MMMM dd, yyyy HH:mm zzz}");

Console.WriteLine();


// Time Complexity
/// People have different time zone according to their location.
/// Even the same country could have different time zones.
/// Even according to the season, the time could change.
/// You MUST know the time zone you're working with.
/// We handle this with the Time Zone



// Using Universal Time Coordinate (00:00:00) Greenwich meridian
/// But you loose all the locales
/// The time will be shown to every one as the UTC
Console.WriteLine($"Using Universal Time Zone (UTC): {DateTime.UtcNow}");





