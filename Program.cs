string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal number = 0m;
decimal result = 0;

for (int i = 0; i < values.Length; i++)
{
    if (decimal.TryParse((values[i]), out number))
    {
        result += number;
    }
    else
    {
        message += values[i];
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Result: {result}");



// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }


// string name = "Bob";
// Console.WriteLine(int.Parse(name));

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// string[] myStrings = new string[]
// {
//     "I like pizza. I like roast chicken. I like salad",
//     "I like all three of the menu choices"
// };

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < myStrings.Length; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");
//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {
//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
//}

// string? readResult;
// string adjustedResult;
// bool validRole = false;
// string[] roles = { "Administrator, Manager, User" };

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do
// {
//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         adjustedResult = readResult.Trim().ToLower();

//         if (readResult == roles[0] || readResult == roles[1] || readResult == roles[2])
//         {
//             validRole = true;
//         }
//         else
//         {
//             Console.WriteLine(
//                 @"The role name that you entered, ""Admin"" is not valid. Enter your role name (Administrator, Manager, or User) ""Administrator"" "
//             );
//         }
//     }
// } while (!validRole);

// Console.WriteLine($"Number {readResult} accepted.");
