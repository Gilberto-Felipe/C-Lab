





// Double type 
/// double type can have decimal point - 1.23 
/// It is the defacto type for math operations with decimals
/// It could have integers and decimals.
/// In fact, if you have an operation only with integers, the compiler will assume that you want integers. So, it will drop decimals. Be cafefull, we do not want that.

/// 
/// If you want decimals in an operations with integers, you must use, at least, one number decimal.
/// 

/// the opposite, change from integer to double is not posible directly.

/// It has integers and drop the decimal part
double averageAge;

averageAge = (22 + 55 + 74) / 3;

Console.WriteLine(averageAge);



/// it has the decimals
var averageWithDecimals = (22.0 + 55 + 74) / 3;

Console.WriteLine(averageWithDecimals);