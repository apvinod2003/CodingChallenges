namespace LeetCodeSolutions.ArraysAndStrings
{
    public class ValidParanthesis
    {
        /// <summary>
        /// Approach: Loop thro the string; Push opening paranthesis into stack; 
        /// When you get a closing paranthesis, peek into the stack if it has corresponding open paranthesis and pop it. Return false otherwise
        /// After all characters are processed, if stack contains elements, return false, else true.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();

            dict.Add('}', '{');
            dict.Add(']', '[');
            dict.Add(')', '(');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                    stack.Push(s[i]); //push open braces
                if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    if(stack.Peek() == dict[s[i]]) //peek into the stack if it has corresponding open paranthesis and pop it.
                        stack.Pop();
                    else
                        return false; //braces dont have corresponding match. return false.
                }
            }

            return stack.Count == 0; //if stack is empty all open parathesis had a corresponding closing paranthesis, so string is valid paranthesis; return true. False otherwise.
        }


    }
}
