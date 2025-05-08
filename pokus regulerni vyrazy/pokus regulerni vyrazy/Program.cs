using System.Text.RegularExpressions;

string[] partNumbers = { "1298-673-4192", "A08Z-931-468a", "_A90-123-129X", "12345-KKA-1230", "0919-2893-1256" };
string pattern = @"^[A-Z0-9]\d{2}[A-Z0-9](-\d{3}){2}[A-Z0-9]$";
foreach (string partNumber in partNumbers)
{
    if (Regex.IsMatch(partNumber, pattern, RegexOptions.IgnoreCase))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}