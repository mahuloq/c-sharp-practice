string[] myStrings = new string[]
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};

string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {
        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

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
