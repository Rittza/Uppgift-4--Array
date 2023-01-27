using System;
namespace Uppgift_4_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Elijah", "Tim", "Eric", "Simon", "Ameen" };
            string förstanamnet = namn[0];

            for(int i = 1; i < namn.Length; i++)
            {
                if (namn[i].CompareTo(förstanamnet) < 0)
                {
                    Console.WriteLine(namn[i] +  " Kommer först ");
                }
            }
        }
    }
}