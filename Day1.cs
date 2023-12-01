using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode
{
    class Day1
    {

        public static void Part1()
        {

            StreamReader reader = new StreamReader(@"Day1.txt");
            string current_line = "";
            int counter = 0;

            while (current_line != null)
            {

                current_line = reader.ReadLine();

                if (current_line != null)
                {
                    string numberOnly = Regex.Replace(current_line, "[^0-9.]", "");

                    var input = numberOnly;

                    string firstDigit = new String(input.TakeWhile(Char.IsDigit).ToArray());

                    string first = $"{firstDigit.Substring(0, 1)}{firstDigit.Substring(firstDigit.Length - 1, 1)}";

                    counter = counter + Convert.ToInt32(first);

                }

            }

            reader.Close();

            Console.WriteLine(counter);

        }

        public static void Part2()
        {
            StreamReader reader = new StreamReader(@"Day1.txt");

            string current_line = "";

            int counter = 0;

            while (current_line != null)
            {
                current_line = reader.ReadLine();

                if (current_line != null)
                {
                    //needed because in the test data eightwothree would give eigh23, as some letters can be shared, so leaving the first and last one works
                    current_line = current_line.Replace("one", "o1e");
                    current_line = current_line.Replace("two", "t2o");
                    current_line = current_line.Replace("three", "t3e");
                    current_line = current_line.Replace("four", "f4r");
                    current_line = current_line.Replace("five", "f5e");
                    current_line = current_line.Replace("six", "s6x");
                    current_line = current_line.Replace("seven", "s7v");
                    current_line = current_line.Replace("eight", "e8t");
                    current_line = current_line.Replace("nine", "ni9ne");
                    string numberOnly = Regex.Replace(current_line, "[^0-9.]", "");

                    var input = numberOnly;

                    string firstDigit = new String(input.TakeWhile(Char.IsDigit).ToArray());

                    string first = $"{firstDigit.Substring(0, 1)}{firstDigit.Substring(firstDigit.Length - 1, 1)}";

                    counter = counter + Convert.ToInt32(first);
                }

            }

            reader.Close();

            Console.WriteLine(counter);

        }



    }
}
