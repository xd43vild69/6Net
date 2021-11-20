using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6BaseLib;

public class SearchManager
{

    public SearchManager()
    {
        //if (searchManager.Palindrome("reconocer2")) Console.WriteLine("Palindromo");

        //if (searchManager.CountWordsIntoPhrare("Esto es uno ") == 2) Console.WriteLine("Counter Ok");

        //searchManager.IsAnagram("rot", "tor");

        //var reverse = searchManager.InReverse("DAVIDGOMEZMONSALVE");
        // Console.WriteLine(reverse);

        //searchManager.CounterCharacter("aaabbc");

        //searchManager.ReplaceCharacter("DavidGomezMonsalve", 'a', 'x');

        //r.ConvertNumberToBinary(2);

        //r.Fibonacci(8);
    }

    public bool Palindrome(string word)
    {
        if (word[0] != word[word.Length - 1]) return false;

        for (int i = 0; i <= word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i]) return false;
        }

        return true;
    }

    public int CountWordsIntoPhrare(string phrase)
    {
        int count = 0;
        char ch = ' ';

        // Validation CS 
        if (phrase.Any(char.IsUpper))
        {
            string p = phrase.ToLower();
        }

        if (!phrase.Contains(ch)) return count;

        count = phrase.Where(x => x == ch).Count();

        return count;
    }


    public int Binary(int item, int[] data, int min, int max)
    {
        // If minimum ends up being bigger than the maximum, then we know the item does not exist
        if (min >= max)
        {
            throw new Exception("That item is not in the dataset.");
        }

        // Calculate the midpoint
        int mid = (max + min) / 2;

        if (data[mid] < item)
        {
            // If the middle item is smaller than the item to be found, then call the function again with modded values
            return Binary(item, data, mid + 1, max);
        }
        else if (item < data[mid])
        {
            return Binary(item, data, min, mid - 1);
        }
        else
        {
            return mid;
        }
    }


    public bool IsAnagram(string word, string anagram)
    {

        Console.WriteLine(word.Substring(1) + word[0]);

        char[] wordChars = word.ToCharArray();
        char[] anagramChars = anagram.ToCharArray();

        Array.Sort(wordChars);
        Array.Sort(anagramChars);

        bool IsAnagram = Enumerable.SequenceEqual(wordChars, anagramChars);
        return IsAnagram;
    }

    public string InReverse(string str)
    {
        if (str.Length <= 1) return str;
        else return InReverse(str.Substring(1)) + str[0];
    }

    public void CounterCharacter(string str)
    {
        var count = 0;

        Dictionary<char, int> dic = new Dictionary<char, int>();

        // Validations

        foreach (char c in str)
        {
            if (dic.ContainsKey(c))
            {
                dic[c] = dic[c] + 1;
            }
            else
            {
                dic.Add(c, 1);
            }
        }

        foreach (KeyValuePair<char, int> pair in dic)
        {
            Console.WriteLine($"{pair.Key} is {pair.Value}");
        }

    }

    public void ReplaceCharacter(string str, char cN, char cO)
    {
        Console.WriteLine(str.Replace(cN, cO));
    }

}

