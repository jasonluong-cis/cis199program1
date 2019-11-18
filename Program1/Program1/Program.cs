//Program 1
//CIS 199-01
//Due: 9/26/2017
//By: A5604
//This program allows the user to find the total amount of paint needed to buy to paint walls

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double Length; //The length of the walls that will be used for calculations
            string LengthAsString; //The input that the user is putting in for the wall length

            double Height; //The height of the walls that will be used for calculations
            string HeightAsString; //The input that the user is putting in for the wall height

            int Doors; //The number of doors that will be used for calculations
            string DoorsAsString; //The input that the user is putting in for the number of doors
            const int DoorsSize = 20; //The constant that is the door size that will be subtracted from the gallon of paint

            int Windows; //The number of windows that will be used for calculations
            string WindowsAsString; //The input that the user is putting in for the number of windows
            const int WindowsSize = 15; //The constant that the window size that will be subtracted from the gallon of paint

            int Coats; //The number of coats that will be used for calculations
            string CoatsAsString; //The input that the user put in for the number of coats desired

            double Gallon; //The amount of paint that the user needs to paint their room
            int GallonsToBuy; //The amount of paint that the user needs to buy

            double Area; //The area that the user wants to paint over
            const double SquareFeet = 350; //The constant that one gallon of paint can buy

            System.Console.WriteLine("Welcome to the Handy-Dandy Paint Estimator");

            System.Console.WriteLine();

            System.Console.Write("Enter the total length of all walls (in feet): ");
            LengthAsString = System.Console.ReadLine();
            Length = double.Parse(LengthAsString);

            System.Console.Write("Enter the height of the walls (in feet): ");
            HeightAsString = System.Console.ReadLine();
            Height = double.Parse(HeightAsString);

            System.Console.Write("Enter the number of doors (non-neg int): ");
            DoorsAsString = System.Console.ReadLine();
            Doors = int.Parse(DoorsAsString);

            System.Console.Write("Enter the number of windows (non-neg int): ");
            WindowsAsString = System.Console.ReadLine();
            Windows = int.Parse(WindowsAsString);

            System.Console.Write("Enter the number of coats of paint (non-neg int): ");
            CoatsAsString = System.Console.ReadLine();
            Coats = int.Parse(CoatsAsString);

            //Calculations
            Area = ((Length * Height) - (((Doors * DoorsSize) + (Windows * WindowsSize))));

            Gallon = ((Area / SquareFeet) * Coats);
            GallonsToBuy = (int)Math.Ceiling(Gallon);

            System.Console.WriteLine($"You need a minimum of {Gallon:F1} gallons of paint");
            System.Console.WriteLine($"You'll need to buy {GallonsToBuy} gallons, though");



        }
    }
}
