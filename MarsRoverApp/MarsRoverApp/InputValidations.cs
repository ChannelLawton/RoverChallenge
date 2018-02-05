using System.Text.RegularExpressions;

namespace MarsRoverApp
{
    public static class InputValidations
    {
        public static bool ValidDirection(string input)
        {
            Regex directionRegex = new Regex(@"^[NSEW]+$");

            return directionRegex.IsMatch(input);
        }

        public static bool ValidCommands(string input)
        {
            Regex commandsRegex = new Regex(@"^[MRL]+$");

            return commandsRegex.IsMatch(input);
        }

    }
}
