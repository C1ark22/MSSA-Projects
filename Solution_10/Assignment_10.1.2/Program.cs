//Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

//Example 1:

//Input: n = 3

//Output: ["((()))", "(()())", "(())()", "()(())", "()()()"]

//Example 2:

//Input: n = 1

//Output: ["()"]

namespace Assignment_10._1._2
{
    public class Solution
    {
        public void Backtrack(int openNums, int closeNums, int n, List<string> res, string currentString)
        {
            // Base case: if the number of open and close parentheses is equal to n,
            // add the current string to the result list
            if (openNums == closeNums && openNums == n)
            {
                // Add the current string to the result list
                res.Add(currentString);

                // Return to the previous recursive call
                return;
            }
            // If the number of open parentheses is less than n, add an open parenthesis
            if (openNums < n)
            {
                // Add an open parenthesis and increment the count of open parentheses
                Backtrack(openNums + 1, closeNums, n, res, currentString + "(");
            }

            // If the number of close parentheses is less than the number of open parentheses,
            // add a close parenthesis
            if (closeNums < openNums)
            {
                // Add a close parenthesis and increment the count of close parentheses
                Backtrack(openNums, closeNums + 1, n, res, currentString + ")");
            }
        }
        public List<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            string currentString = "";
            Backtrack(0, 0, n, result, currentString);
            return result;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 3;

            List<string> result = solution.GenerateParenthesis(n);

            foreach (string parentheses in result)
            {
                Console.WriteLine(parentheses);
            }
        }
        
    }
}
