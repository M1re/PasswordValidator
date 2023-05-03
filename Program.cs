using PasswordValidation;
using System.Text.RegularExpressions;

public class Program
{
    static void Main()
    {
        var validator = new PasswordValidator();
        Console.WriteLine("Number of valid passwords in file: " + validator.PasswordValidation("Password.txt"));//Manually pass file with passwords into bin/debug/net6.0
    }
}