using System;

namespace CsharpRampUp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unit Converter
            Console.WriteLine("POUNDS TO KILOGRAMS");
            Console.Write(">ENTER VALUE IN POUNDS: ");
            int userPounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">>VALUE IN POUNDS: " + userPounds);
            Console.WriteLine(">>VALUE IN KILOGRAMS: " + 0.453592 * userPounds);
            Console.WriteLine("======================================");

            //MILES TO KILOMETERS
            Console.WriteLine("MILES TO KILOMETERS");
            Console.Write(">ENTER VALUE IN MILES: ");
            int userMiles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">VALUE IN MILES: " + userMiles);
            Console.WriteLine(">>VALUE IN KILOMETERS: " + 1.60934 * userMiles);
            Console.WriteLine("======================================");

            //FAHRENHEIT TO CELSIUS
            Console.WriteLine("FAHRENHEIT TO CELSIUS");
            Console.Write(">ENTER VALUE IN FAHRENHEIT: ");
            int userFahr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">>VALUE IN FAHRENHEIT: " + userFahr);
            Console.WriteLine(">>VALUE IN CELSIUS: " + (userFahr - 32) / 1.8);
            Console.WriteLine("======================================");

            // Student Age
            Console.Write("ENTER AGE OF STUDENT 1:");
            int studentsAge1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 2:");
            int studentsAge2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 3:");
            int studentsAge3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 4:");
            int studentsAge4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 5:");
            int studentsAge5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 6:");
            int studentsAge6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 7:");
            int studentsAge7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 8:");
            int studentsAge8 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 9:");
            int studentsAge9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER AGE OF STUDENT 10:");
            int studentsAge10 = Convert.ToInt32(Console.ReadLine());

            //Printing Ages of Students
            Console.WriteLine("======================================");
            Console.WriteLine("Age of Student 1: " + studentsAge1);
            Console.WriteLine("Age of Student 2: " + studentsAge2);
            Console.WriteLine("Age of Student 3: " + studentsAge3);
            Console.WriteLine("Age of Student 4: " + studentsAge4);
            Console.WriteLine("Age of Student 5: " + studentsAge5);
            Console.WriteLine("Age of Student 6: " + studentsAge6);
            Console.WriteLine("Age of Student 7: " + studentsAge7);
            Console.WriteLine("Age of Student 8: " + studentsAge8);
            Console.WriteLine("Age of Student 9: " + studentsAge9);
            Console.WriteLine("Age of Student 10: " + studentsAge10);

            double aveAge = (studentsAge1 + studentsAge2 + studentsAge3 + studentsAge4 + studentsAge5 + studentsAge6 + studentsAge7 + studentsAge8 + studentsAge9 + studentsAge10) / 10;
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
            Console.WriteLine(",prepares to venture the deep lore of the dungeons and its monster delicacies!");

            // First Experiment
            Console.WriteLine("================================================");
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
            Console.Write(">>ENTER NUMBER FOR THE THIRD NUMBER PATTERN: ");
            int numPatThree = Convert.ToInt32(Console.ReadLine());
            if (numPatThree <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = numPatThree; i > 0; i--)
                {
                    Console.WriteLine(string.Join(" ", Enumerable.Range(1, i)));
                }
            }
        }
    }
}

