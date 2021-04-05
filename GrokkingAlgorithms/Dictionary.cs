using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    /// <summary>
    /// Hash tables are also known as hash maps, maps, dictionaries, and associative arrays.
    /// Binary search, O(log n), is much faster than linear search, O(n), but hash tables, O(1) in average, are even more faster than binary search.
    /// </summary>
    public class Dictionary
    {
        Dictionary<string, double> books = new Dictionary<string, double>
        {
            {"Don Quixote", 13.32},
            {"War and Peace", 13.34},
            {"Ulysses", 7.66}
        };

        Dictionary<string, bool> voted = new Dictionary<string, bool>();

        public void DisplayPrice(string key)
        {
            Console.WriteLine($"The price of {key} is ${books[key]}");
        }

        public void CheckVoter(string voter)
        {
            if (voted.ContainsKey(voter)) Console.WriteLine("Kick them out!");
            else
            {
                voted.Add(voter, true);
                Console.WriteLine("Let them vote!");
            }
        }
    }
}
