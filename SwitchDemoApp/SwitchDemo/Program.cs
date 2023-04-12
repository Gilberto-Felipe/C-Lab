


// Switch statements 
/// Is other format for if-else if-else statement.
/// Here you have multiple choices.
/// The case (option) value match the switch value. If the value match, then the block of code is executed. 
/// 
/// Break jumps out of the switch.
/// 
/// default is like the else. If no case match the switch value, default handles that.
/// 

string firstName = "Tatyana";

switch (firstName.ToLower())
{
    case "gil" or "felipe":
        Console.WriteLine("Hello Professor.");
        break;
    case "ema":
        Console.WriteLine("Hello Ema");
        break;
    case "tatyana":
        Console.WriteLine("Could you marry me.");
        break;
    default:
        Console.WriteLine("Name not expected.");
        break;
}



// Be careful with the range in cases
/// You should cover all the posible values. 
/// Check if a value is cover by the ranges. It is easy to loose a value.
/// It is a bug.
/// 




double age = 18;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You're a child.");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should work. Good luck.");
        break;
    case >= 66 and < 100:
        Console.WriteLine("Hopfully you're retired.");
        break;
    default:
        Console.WriteLine("Age not in an expected range.");
        break;
}




// Switch or if
/// if is more powerfull and dynamic.
/// Switch is compact.
/// It depends on your circumstances. 
/// So analyse and take the decision of which one is better for you.
/// 



