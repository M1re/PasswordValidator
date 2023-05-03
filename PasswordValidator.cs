using System.Text.RegularExpressions;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        public int PasswordValidation(string filePath)
        {
            int validPasswordsCount = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Regex pattern = new Regex(@"(\w) (\d+)-(\d+): (\w+)");

                    while (!reader.EndOfStream)
                    {
                        Match match = pattern.Match(reader.ReadLine());

                        char symbol = match.Groups[1].Value[0];
                        int minCount = int.Parse(match.Groups[2].Value);
                        int maxCount = int.Parse(match.Groups[3].Value);
                        string password = match.Groups[4].Value;

                        int count = Regex.Matches(password, symbol.ToString()).Count;

                        if (count >= minCount && count <= maxCount)
                        {
                            validPasswordsCount++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return validPasswordsCount;
        }
    }
}