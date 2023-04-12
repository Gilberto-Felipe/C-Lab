using System.Globalization;

// Date Only only workf from .net (Core) 6.0 and up
/// Use case
/// When we need only the Date without the time
/// 

/// It is called DateOnly to sort compatibility issues forward and backward.
/// Now you can upgrade your legacy code without breaking or not doing upgrades because it will break the code.



// Parse only accepts USA format
DateOnly birthday = DateOnly.Parse("12/14/2023");


// Even though we can formated with ToString in World date
Console.WriteLine(birthday.ToString("dd/MM/yyyy"));

Console.WriteLine("================ \n");

// Parse Exact you pass the date, the format, and disable the locale
DateOnly birthday2 = DateOnly.ParseExact("14/12/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday2 + "\n");




