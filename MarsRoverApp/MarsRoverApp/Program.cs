using System;

namespace MarsRoverApp
{
    class Program
    {
        static string input;
        static int zoneSize;
        static int postition;
        static char direction;
        static string commands;
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Mars Rover App");

            try
            {

                PromptInputs();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please restart the app as a system error occurred. If this continue please contact the author of this app.");
                //Here the exception message would be mailed to the developer/support as well.
            }

        }

        static void PromptInputs()
        {
            do
            {
                Console.WriteLine("Please provide the zone size with two number values e.g 88 : ");
                input = Console.ReadLine();

            } while (int.TryParse(input, out zoneSize) == false && input.Length != 2);

            do
            {
                Console.WriteLine("Please provide the horizontal and vertical axis values e.g 55: ");
                input = Console.ReadLine();

            } while (int.TryParse(input, out postition) == false && input.Length != 2);

            do
            {
                Console.WriteLine("Please provide one direction the rover is facing e.g E - East, W - West, N -North and S - South: ");
                input = Console.ReadLine();

            } while (char.TryParse(input, out direction) == false && input.Length != 1 && !InputValidations.ValidDirection(input.ToUpper()));

            do
            {
                Console.WriteLine("Please provide list of commands for rover to complete. M - Move one forward, R - Rotate 90 degrees right and L - Rotate 90 degrees left: ");
                commands = Console.ReadLine().Trim();

            } while (!InputValidations.ValidCommands(commands.ToUpper()));

            CompassValue roverPosition = (CompassValue)Enum.Parse(typeof(CompassValue), direction.ToString());

            Rover rover = new Rover
            {
                ZoneSizeX = int.Parse(zoneSize.ToString().Substring(0, 1)),
                ZoneSizeY = int.Parse(zoneSize.ToString().Substring(1, 1)),
                PositionX = int.Parse(postition.ToString().Substring(0, 1)),
                PositionY = int.Parse(postition.ToString().Substring(1, 1)),
                RoverPosition = roverPosition,
                Commands = commands.ToUpper()
            };

            string results = rover.Calculate();

            Console.WriteLine(results);

            Console.WriteLine("Do you want to try again? Y/N");

            string tryAgain = Console.ReadLine().ToUpper();

            if (tryAgain == "Y")
                PromptInputs();
            else
                Environment.Exit(0);
        }

    }
}
