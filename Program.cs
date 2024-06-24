// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the input is a valid representation of an integer.
// If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
// Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

string? readResult;
string adjustedResult;
bool validRole = false;
string[] roles = { "Administrator, Manager, User" };

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        adjustedResult = readResult.Trim().ToLower();

        if (readResult == roles[0] || readResult == roles[1] || readResult == roles[2])
        {
            validRole = true;
        }
        else
        {
            Console.WriteLine(
                @"The role name that you entered, ""Admin"" is not valid. Enter your role name (Administrator, Manager, or User) ""Administrator"" "
            );
        }
    }
} while (!validRole);

Console.WriteLine($"Number {readResult} accepted.");
