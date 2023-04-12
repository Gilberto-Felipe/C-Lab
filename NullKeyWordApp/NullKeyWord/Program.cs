

// null - lack of value

/// null is a key word that means lack of value in a variable.
/// Usually, types doesn't accept null. 
/// String is the only type that accepts null.
/// 
/// But null is usefull for defining the lack of initial value to types.
/// 


/// examples
/// 
string firstName = null; // it acceps null


/// but other types do not accept null, for example int, bool, etc.
/// The intellisense throws an error... We cannot do that directly.
/// assign a null to an int is invalid.

//int age = null;

//bool isBirthday = null;

//double battingAverage = null;

//decimal accountBalance = null;



// The default value of int, double, decimal is 0. 
/// How to manage null, if that is what we need.
/// Because age = 0, sometimes is innacurate. We do not want to have a value of 0 for null values.
/// 



// New feature of C# > nullables
/// nullable is the ? key workd, and you append it next to the end of the type key word.
/// For examples,
/// 

int? age = null;

bool? isBirthday = null;

double? battingAverage = null;

decimal? accountBalance = null;

// ? allows that a type accepts null as a value.



// Activate or deactivate nullable
/// You can turn off the nullable policy in the Project files.
/// Just remove <Nullable>enable</Nullable> line.
/// 


/// Usually it's good to use nullables. It's a new feature, so take advantage of this.


