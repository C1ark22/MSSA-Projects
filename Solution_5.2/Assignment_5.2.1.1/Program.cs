namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "Hello World";
            string s = "fly me to the moon";

            //we are looking for the last word in the string
            //we can store the string to
            //an array of strings and then get the last element of the array
            //then we print out the length of the last word
            //and its length

            List<string> list = new List<string>();
            string currentWord = "";

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    list.Add(currentWord);
                    currentWord = "";
                }
                else
                {
                    currentWord += s[i];
                }
            }
            list.Add(currentWord);

            string lastWord = list[list.Count - 1];

            int count = 0;
            for (int i = 0; i < lastWord.Length; i++)
            {
                count++;
            }
            Console.WriteLine($"The last word is: {lastWord} with length {count}");
        }
    }
}
