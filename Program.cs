using System;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string group = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string[] members = new string[n];
            int[] hours = new int[n];

            char[] numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < n; i++)
            {

                string input = Console.ReadLine();
                int position = input.IndexOfAny(numbers);

                members[i] = input.Substring(0, position - 1);
                hours[i] = int.Parse(input.Substring(position));

            }

            string task = Console.ReadLine();

            if (task.ToLower() == "average")
            {
                float total = 0;

                foreach (int i in hours)
                {
                    total += i;
                }

                float average = total / n;

                Console.WriteLine("Average hours spent by {0}: {1} hours and {2} minutes.", group, (int)average, Math.Round((average - (int)average) * 60));

            }
            else
            {
                int numPos = task.IndexOfAny(numbers);
                int perPos = task.IndexOf("%");

                float percent = int.Parse(task.Substring(numPos, perPos - numPos));
                percent /= 100;

                int j = 0;

                foreach (int i in hours)
                {
                    float newHours = i - (i * percent);
                    Console.WriteLine("{0}'s reduced hours are: {1} hours and {2} minutes.", members[j], (int)newHours, Math.Round((newHours - (int)newHours) * 60));
                    j++;

                }

            }
        }
    }
}