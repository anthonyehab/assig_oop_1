using System.Drawing;

namespace assig_oop_1
{




    internal class program
    {

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        enum Permissions
        {
           
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        enum Colors
        {
            Red,
            Green,
            Blue
        }

        static void main(string [] args)
        {
            #region 1. question 1
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            foreach (string day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
            #region 2.question 2
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();

            Season season;
            if (Enum.TryParse(input, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Month range: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Month range: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Month range: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Month range: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season. Please try again.");
            }
            #endregion
            #region 3.question 3
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            Permissions permission = Permissions.Read | Permissions.Write;

            Console.WriteLine("Initial permissions: " + permission);

            permission |= Permissions.Execute;
            Console.WriteLine("After adding Execute permission: " + permission);


            permission &= ~Permissions.Write;
            Console.WriteLine("After removing Write permission: " + permission);


            if ((permission & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission exists");
            }
            else
            {
                Console.WriteLine("Read permission does not exist");
            }


            if ((permission & Permissions.Delete) == Permissions.Delete)
            {
                Console.WriteLine("Delete permission exists");
            }
            else
            {
                Console.WriteLine("Delete permission does not exist");
            }
            #endregion
            #region 4.question 4
            //Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            static void Main(string[] args)
            {
                Console.Write("Enter a color: ");
                string input = Console.ReadLine();

                Colors color;
                if (Enum.TryParse(input, true, out color))
                {
                    bool isPrimaryColor = IsPrimaryColor(color);
                    if (isPrimaryColor)
                    {
                        Console.WriteLine($"{input} is a primary color.");
                    }
                    else
                    {
                        Console.WriteLine($"{input} is not a primary color.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid color. Please try again.");
                }
            }

            static bool IsPrimaryColor(Colors color)
            {
                return color == Colors.Red || color == Colors.Green || color == Colors.Blue;
            }

            #endregion
            #region 5.question 5
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            Console.Write("Enter X coordinate of point 1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y coordinate of point 1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter X coordinate of point 2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y coordinate of point 2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Point p1 = new Point { X = x1, Y = y1 };
            Point p2 = new Point { X = x2, Y = y2 };

            double distance = CalculateDistance(p1, p2);

            Console.WriteLine($"The distance between the two points is: {distance:F2}");
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;

            return deltaX * deltaX + deltaY * deltaY;
        }
        #endregion
    }



    }

