using System;
using System.Collections.Generic;
using System.Linq;

public class WeightedStrings
{
    private static Dictionary<char, int> charWeights = new Dictionary<char, int>();

    // Static constructor to initialize the charWeights dictionary
    static WeightedStrings()
    {
        for (int i = 0; i < 26; i++)
        {
            charWeights.Add((char)('a' + i), i + 1);
        }
    }

    public static List<string> CheckQueries(string input, List<int> queries)
    {
        List<int> substringWeights = new List<int>();

        for (int i = 0; i < input.Length;)
        {
            int count = 1;
            while (i + count < input.Length && input[i] == input[i + count])
            {
                count++;
            }

            for (int j = 1; j <= count; j++)
            {
                substringWeights.Add(charWeights[input[i]] * j);
            }

            i += count;
        }

        List<string> results = queries.Select(query => substringWeights.Contains(query) ? "Yes" : "No").ToList();

        return results;
    }
    
    public static List<string> GenerateSubstrings(string input)
    {
        List<string> substrings = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            string temp = input[i].ToString();
            substrings.Add(temp);
            for (int j = i + 1; j < input.Length && input[j] == input[i]; j++)
            {
                temp += input[j];
                substrings.Add(temp);
                i = j;
            }
        }
        return substrings;
    }

    static void Main(string[] args)
    {
        string input1 = "abbcccd";
        List<int> queries1 = new List<int> { 1, 3, 9, 8 };
        List<string> results1 = CheckQueries(input1, queries1);
        Console.WriteLine($"Output for 'abbcccd': [{string.Join(", ", results1)}]");

        string input2 = "zzz";
        List<int> queries2 = new List<int> { 1, 26, 52, 78 };
        List<string> results2 = CheckQueries(input2, queries2);
        Console.WriteLine($"Output for 'zzz': [{string.Join(", ", results2)}]");

        string input3 = "aabb";
        List<int> queries3 = new List<int> { 2, 4, 6 };
        List<string> results3 = CheckQueries(input3, queries3);
        Console.WriteLine($"Output for 'aabb': [{string.Join(", ", results3)}]");

        string input4 = "bbccc";
        List<string> substrings4 = GenerateSubstrings(input4);
        Console.WriteLine($"Generated substrings for 'bbccc': [{string.Join(", ", substrings4)}]");

        List<int> queries4 = substrings4.Select(substring => substring.Length * charWeights[substring[0]]).ToList();
        List<string> results4 = CheckQueries(input4, queries4);
        Console.WriteLine($"Output for 'bbccc': [{string.Join(", ", results4)}]");
    }
}