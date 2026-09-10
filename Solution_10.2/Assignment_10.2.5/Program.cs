//You are given an array of characters letters that is sorted in non-decreasing order,
//and a character target. There are at least two different characters in letters.
//Return the smallest character in letters that is lexicographically greater than target.
//If such a character does not exist, return the first character in letters.

//Example 1:

//Input: letters = ["c","f","j"], target = "a"

//Output: "c"

//Explanation: The smallest character that is lexicographically greater than 'a' in
//letters is 'c'.

//Example 2:

//Input: letters = ["c","f","j"], target = "c"

//Output: "f"

//Explanation: The smallest character that is lexicographically greater than 'c' in
//letters is 'f'.

//Example 3:

//Input: letters = ["x","x","y","y"], target = "z"

//Output: "x"

//Explanation: There are no characters in letters that is lexicographically greater than
//'z' so we return letters[0].You are given an array of characters letters that is sorted
//in non-decreasing order, and a character target. There are at least two different
//characters in letters.
//Return the smallest character in letters that is lexicographically greater than target.
//If such a character does not exist, return the first character in letters.

//Example 1:

//Input: letters = ["c","f","j"], target = "a"

//Output: "c"

//Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.

//Example 2:

//Input: letters = ["c","f","j"], target = "c"

//Output: "f"

//Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.

//Example 3:

//Input: letters = ["x","x","y","y"], target = "z"

//Output: "x"

//Explanation: There are no characters in letters that is lexicographically greater than 'z' so we
//return letters[0].
using System;
using System.Linq;

namespace Assignment_10._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] letters = { 'c', 'f', 'j' };
            char[] letters = { 'x', 'x', 'y', 'y' };
            //char target = 'a';
            //char target = 'c';
            char target = 'z';

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > target)
                {
                    Console.WriteLine(letters[i]);
                    return;
                }
            }
            Console.WriteLine(letters[0]);
        }
    }
}
