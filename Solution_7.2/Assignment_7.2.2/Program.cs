//Given a string s, reverse only all the vowels in the string and
//return it. The vowels are 'a', 'e', 'i', 'o', and 'u', and they
//can appear in both lower and upper cases, more than once.

//Example 1:

//Input: s = "hello"

//Output: "holle"

//Example 2:

//Input: s = "avacado"

//Output: "ovacada"

//Example 3: “intelligent”-à   i , e, i, e

//Output: entillegint

namespace Assignment_7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "hello";
            //string s = "avocado";
            //string s = "intelligent";
            string s = "IceCreAm";

            Console.WriteLine(ReverseVowels(s));
        }
        static string ReverseVowels(string s)
        {
            // looks at the first vowel and search for the next one
            // then they switch places
            int startPointer = 0;
            int endPointer = s.Length -1;

            // converting string to char array so we can modify the characters
            char[] letters = s.ToCharArray();

            while (startPointer < endPointer)
            {

                //checking if startpointer is a vowel if not move to the next
                char currentStartChar = char.ToLower(s[startPointer]);

                // moves start pointer till it finds a vowel
                while(startPointer < endPointer &&
                    currentStartChar != 'a' &&
                    currentStartChar != 'e' &&
                    currentStartChar != 'i' &&
                    currentStartChar != 'o' &&
                    currentStartChar != 'u')
                {
                    startPointer++;
                    currentStartChar = char.ToLower(s[startPointer]);
                }

                //checking if endpointer is a vowel if not move to the next
                char currentEndChar = char.ToLower(s[endPointer]);

                // moves end pointer till it finds a vowel
                while(startPointer < endPointer &&
                    currentEndChar != 'a' &&
                    currentEndChar != 'e' &&
                    currentEndChar != 'i' &&
                    currentEndChar != 'o' &&
                    currentEndChar != 'u')
                {
                    endPointer--;
                    currentEndChar = char.ToLower(s[endPointer]);
                }
                
                // the pointers should be pointing at a vowels
                
                if(startPointer < endPointer)
                {
                    char temp = letters[startPointer];
                    letters[startPointer] = letters[endPointer];
                    letters[endPointer] = temp;

                    // move pointers inward
                    startPointer++;
                    endPointer--;
                }
            }
            
            return new string(letters);
        }
    }
}
