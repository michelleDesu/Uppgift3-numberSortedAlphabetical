using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Enumerable.Range(1, 25).ToList();


        Random rand = new Random();
        List<int> shuffledNumbers = numbers.OrderBy(x => rand.Next()).ToList();

        
        Dictionary<int, string> numberToSwedish = new Dictionary<int, string>
        {
            { 1, "ett" },
            { 2, "två" },
            { 3, "tre" },
            { 4, "fyra" },
            { 5, "fem" },
            { 6, "sex" },
            { 7, "sju" },
            { 8, "åtta" },
            { 9, "nio" },
            { 10, "tio" },
            { 11, "elva" },
            { 12, "tolv" },
            { 13, "tretton" },
            { 14, "fjorton" },
            { 15, "femton" },
            { 16, "sexton" },
            { 17, "sjutton" },
            { 18, "arton" },
            { 19, "nitton" },
            { 20, "tjugo" },
            { 21, "tjugoett" },
            { 22, "tjugotvå" },
            { 23, "tjugotre" },
            { 24, "tjugofyra" },
            { 25, "tjugofem" }
        };

        var sortedNumbers = shuffledNumbers.OrderBy(x => numberToSwedish[x]).ToList();

        Console.WriteLine("Numbers sorted in alphabetical order based on the Swedish names of the numbers:\n");
        int index = 1;
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine($"{index.ToString().PadLeft(2, '0')}, {numberToSwedish[number]}");
            index++;
        }

    }
}
