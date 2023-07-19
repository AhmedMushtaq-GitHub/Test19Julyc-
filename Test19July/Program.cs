/*using System;

public class Program
{
    public static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');

        Array.Reverse(words);

        string reversedString = string.Join(" ", words);

        return reversedString;
    }

    public static void Main()
    {
        string inputString = "Hello Ahmed, how are you?";
        string reversedString = ReverseWords(inputString);

        Console.WriteLine("Original String: " + inputString);
        Console.WriteLine("Reversed String: " + reversedString);
    }
}
*//*
using System;

public class Program
{
    public static string ReverseWords(string input)
    {
        // Step 1: Split the string into individual words using space as the delimiter
        string[] words = input.Split(' ');

        // Step 2: Reverse each word
        for (int i = 0; i < words.Length; i++)
        {
            char[] wordArray = words[i].ToCharArray();
            Array.Reverse(wordArray);
            words[i] = new string(wordArray);
        }

        // Step 3: Reconstruct the string with reversed words
        string reversedString = string.Join(" ", words);

        return reversedString;
    }

    public static void Main()
    {
        string inputString = "Hello Ahmed, how are you?";
        string reversedWordsString = ReverseWords(inputString);

        Console.WriteLine("Original String: " + inputString);
        Console.WriteLine("String with Reversed Words: " + reversedWordsString);
    }
}
*/
/*using System;
using System.Collections.Generic;

public class Program
{
    public static Dictionary<char, int> CountCharacterOccurrences(string input)
    {
        // Create a dictionary to store character counts
        Dictionary<char, int> characterCounts = new Dictionary<char, int>();

        // Loop through each character in the input string
        foreach (char c in input)
        {
            // If the character is already present in the dictionary, increment its count
            if (characterCounts.ContainsKey(c))
            {
                characterCounts[c]++;
            }
            // If the character is not present in the dictionary, add it with a count of 1
            else
            {
                characterCounts[c] = 1;
            }
        }

        return characterCounts;
    }

    public static void Main()
    {
        string inputString = "hello world";

        Dictionary<char, int> characterOccurrences = CountCharacterOccurrences(inputString);

        // Print the character occurrences
        foreach (var pair in characterOccurrences)
        {
            Console.WriteLine($"Character '{pair.Key}' occurs {pair.Value} time(s)");
        }
    }
}
*/
/*using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string input = "abbcdeeff";
        string result = RemoveDuplicates(input);
        Console.WriteLine(result); // Output: abcdef
    }

    public static string RemoveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder resultBuilder = new StringBuilder();
        bool[] seenCharacters = new bool[128]; // Assuming ASCII character set, you can use a larger array for Unicode

        foreach (char c in input)
        {
            if (!seenCharacters[c])
            {
                seenCharacters[c] = true;
                resultBuilder.Append(c);
            }
        }

        return resultBuilder.ToString();
    }
}
*/
/*using System;

public class Program
{
    public static void Main()
    {
        string input = "Hello, how are you?";
        string substringToFind = "how";

        int index = input.IndexOf(substringToFind);

        if (index != -1)
        {
            Console.WriteLine("Substring found at index: " + index);
        }
        else
        {
            Console.WriteLine("Substring not found.");
        }
    }
}
*/
/*using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int rotationCount = 2;

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        LeftCircularRotate(arr, rotationCount);

        Console.WriteLine("\nArray after left circular rotation:");
        PrintArray(arr);
    }

    public static void LeftCircularRotate(int[] arr, int rotationCount)
    {
        int n = arr.Length;
        rotationCount %= n; // To handle cases where rotationCount > n

        if (rotationCount == 0)
            return;

        // Temporary array to store the elements to be rotated
        int[] tempArray = new int[rotationCount];

        // Store the first rotationCount elements in tempArray
        for (int i = 0; i < rotationCount; i++)
        {
            tempArray[i] = arr[i];
        }

        // Shift elements to the left by rotationCount positions
        for (int i = rotationCount; i < n; i++)
        {
            arr[i - rotationCount] = arr[i];
        }

        // Place the elements from tempArray at the end of the array
        for (int i = 0; i < rotationCount; i++)
        {
            arr[n - rotationCount + i] = tempArray[i];
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
    }
}
*/
/*using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int rotationCount = 2;

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        RightCircularRotate(arr, rotationCount);

        Console.WriteLine("\nArray after right circular rotation:");
        PrintArray(arr);
    }

    public static void RightCircularRotate(int[] arr, int rotationCount)
    {
        int n = arr.Length;
        rotationCount %= n; // To handle cases where rotationCount > n

        if (rotationCount == 0)
            return;

        // Temporary array to store the last rotationCount elements
        int[] tempArray = new int[rotationCount];

        // Store the last rotationCount elements in tempArray
        for (int i = 0; i < rotationCount; i++)
        {
            tempArray[i] = arr[n - rotationCount + i];
        }

        // Shift elements to the right by rotationCount positions
        for (int i = n - 1; i >= rotationCount; i--)
        {
            arr[i] = arr[i - rotationCount];
        }

        // Place the elements from tempArray at the beginning of the array
        for (int i = 0; i < rotationCount; i++)
        {
            arr[i] = tempArray[i];
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
    }
}
*/
using System;

public class Program
{
    public static void Main()
    {
        int num = 17; // Change this number to check different integers

        if (IsPrime(num))
        {
            Console.WriteLine($"{num} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a prime number.");
        }
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        if (num == 2)
            return true;

        // If the number is divisible by 2, it's not prime
        if (num % 2 == 0)
            return false;

        // Check for divisors from 3 up to the square root of the number
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
