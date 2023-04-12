


// TimeOnly is for Time without Date
/// It only works for time
/// 

// Parse converts the string into a TimeOnly object
TimeOnly opensAt = TimeOnly.Parse("8:00 AM");

Console.WriteLine(opensAt);

// 't' only the A or P
// "tt" AM or PM
Console.WriteLine(opensAt.ToString("HH:mm:ss tt"));


// For the time Now it brings it from the DateTime library
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(rightNow);

Console.WriteLine("============== \n");

// Brings the time now from DateTime library Universal Time Coordinate
Console.WriteLine(TimeOnly.FromDateTime(DateTime.UtcNow));