/* BREIF:
 * 
 * Ask the user for a comma-separated list of first names (no spaces). 
 * Split the string into a string array. Loop through the array and print
 * "Hello «name>" to the Console for each person.
 * 
 */

// 1. Ask user for : comma-separated list of first names (no spaces)
Console.Write("Please write comma-separated list of first names (no spaces)");
string? firstNamesStr = Console.ReadLine();

// 2. Split to spring array
string[] firstNames = firstNamesStr.Split(',');

// 3. Loop through array and print hello name to console for each person
for (int i = 0; i < firstNames.Count(); i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}

