using System;

namespace CsharpRampUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PART 1");

            // Unit Converter
            Console.WriteLine("POUNDS TO KILOGRAMS");

            double userPounds;

            do
            {
                Console.Write(">ENTER VALUE IN POUNDS: ");
                userPounds = Convert.ToDouble(Console.ReadLine());

                if (userPounds <= 0)
                {
                    Console.WriteLine("Please enter a valid value.");
                }

            } while (userPounds <= 0);

            Console.WriteLine(">>VALUE IN POUNDS: " + userPounds);
            Console.WriteLine(">>VALUE IN KILOGRAMS: " + 0.453592 * userPounds);
            Console.WriteLine("======================================");


            //MILES TO KILOMETERS
            Console.WriteLine("MILES TO KILOMETERS");

            double userMiles;

            do
            {
                Console.Write(">ENTER VALUE IN MILES: ");
                userMiles = Convert.ToDouble(Console.ReadLine());

                if (userMiles <= 0)
                {
                    Console.WriteLine("Please enter a valid value.");
                }

            } while (userMiles <= 0);
            Console.WriteLine(">VALUE IN MILES: " + userMiles);
            Console.WriteLine(">>VALUE IN KILOMETERS: " + 1.60934 * userMiles);
            Console.WriteLine("======================================");

            //FAHRENHEIT TO CELSIUS * A negative value is acceptable.
            Console.WriteLine("FAHRENHEIT TO CELSIUS");
            Console.Write(">ENTER VALUE IN FAHRENHEIT: ");
            double userFahr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(">>VALUE IN FAHRENHEIT: " + userFahr);
            Console.WriteLine(">>VALUE IN CELSIUS: " + (userFahr - 32) / 1.8);
            Console.WriteLine("======================================");

            // Student Age
            int studentsAge1;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 1:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge1) && studentsAge1 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge2;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 2:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge2) && studentsAge2 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge3;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 3:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge3) && studentsAge3 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge4;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 4:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge4) && studentsAge4 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge5;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 5:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge5) && studentsAge5 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge6;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 6:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge6) && studentsAge6 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge7;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 7:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge7) && studentsAge7 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge8;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 8:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge8) && studentsAge8 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge9;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 9:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge9) && studentsAge9 > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            int studentsAge10;
            while (true)
            {
                Console.Write("ENTER AGE OF STUDENT 10: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentsAge10) && studentsAge10 >0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            //Printing Ages of Students
            Console.WriteLine("======================================");
            int[] studentAges = { studentsAge1, studentsAge2, studentsAge3, studentsAge4, studentsAge5, studentsAge6, studentsAge7, studentsAge8, studentsAge9, studentsAge10 };

            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.WriteLine($"Age of Student {i + 1}: {studentAges[i]}");
            }


            int aveAge = (studentsAge1 + studentsAge2 + studentsAge3 + studentsAge4 + studentsAge5 + studentsAge6 + studentsAge7 + studentsAge8 + studentsAge9 + studentsAge10) / 10;
            Console.WriteLine("======================================");
            Console.WriteLine("The average age is: " + aveAge);

            // MultiLine Story
            string charNameOne = "Laios";
            string charNameTwo = "Marcille";
            string charNameThree = "Chilchuck";
            string charNameFour = "Izutsumi";
            string charNameFive = "Senshi";

            string dndClassOne = "Knight";
            string dndClassTwo = "Elf";
            string dndClassThree = "Locksmith";
            string dndClassFour = "Beastman";
            string dndClassFive = "Dwarf";

            //Multiline Story
            Console.WriteLine("======================================");
            Console.WriteLine("DELICIOUS IN DUNGEON!");
            Console.WriteLine("My sister is inside the red dragons stomach..");
            Console.WriteLine("After a failed dungeon raid that resulted in his younger sister being eaten by a dragon, ");
            Console.WriteLine("Laios and the remaining members of his party, Marcille and Chilchuck, set out to rescue her from being digested by the dragon.");
            Console.WriteLine("While venturing, they meet a peculiar cast along the way and managed to make them hop into the team!");
            Console.WriteLine("This party, including " + charNameOne + " the " + dndClassOne + ", " + charNameTwo + " the " + dndClassTwo + ", " + charNameThree + " the " + dndClassThree + ", " + charNameFour + " the " + dndClassFour + " and " + charNameFive + " the " + dndClassFive);
            Console.WriteLine("prepares to venture the deep lore of the dungeons and its monster delicacies!");

            Console.WriteLine(" ");
            Console.WriteLine("PART 2");

            // First Experiment
            Console.WriteLine("================================================");
            Console.WriteLine(">>FIRST NUMBER PATTERN");
            Console.Write(">>ENTER NUMBER FOR THE FIRST NUMBER PATTERN: ");
            int numPatOne = Convert.ToInt32(Console.ReadLine());
            if (numPatOne <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= numPatOne; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("================================================");
            // Second Experiment
            Console.WriteLine(">>SECOND NUMBER PATTERN");
            Console.Write(">>ENTER NUMBER FOR THE SECOND NUMBER PATTERN: ");
            int numPatTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input: " + numPatTwo);

            if (numPatTwo <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                string formula = "";
                int result = 0;

                for (int i = 1; i <= numPatTwo; i++)
                {
                    result += i;
                    formula += i;

                    if (i < numPatTwo)
                    {
                        formula += "+";
                    }
                }

                Console.WriteLine("formula: " + formula);
                Console.WriteLine("output: " + result);
            }

            Console.WriteLine("================================================");
            // Third Experiment
            Console.WriteLine(">>THIRD NUMBER PATTERN"); 
            Console.Write(">>ENTER NUMBER FOR THE THIRD NUMBER PATTERN: ");
            int numPatThree = Convert.ToInt32(Console.ReadLine());
            if (numPatThree <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = numPatThree; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

