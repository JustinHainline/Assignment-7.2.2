namespace Assignment_7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Hainline";
            string reversed = ReverseVowels(word);
            Console.WriteLine(reversed);
        }
        public static string ReverseVowels(string s)
        {
            char[] chars = s.ToCharArray();
           // int i = 0;
           // int j = s.Length - 1;
           var vowelsStack = new Stack<char>();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in chars)
            {
                if (vowels.Contains(c))
                {
                    vowelsStack.Push(c);
                }
            }
            for (int i = 0; i < chars.Length;  i++)
            {
                if (vowels.Contains(chars[i]))
                {
                    chars[i] = vowelsStack.Pop();
                }
            }
            return new string(chars); 
        //    while (i < j)
        //    {
        //        if (vowels.Contains(chars[i])&& vowels.Contains(chars[j]))
        //        {
        //            char temp = chars[i];
        //            chars[i] = chars[j];
        //            chars[j] = temp;
        //            i++;
        //            j--;
        //        }
        //        else if (vowels.Contains(chars[i]))
        //        {
        //            j--;
        //        }
        //        else
        //        {
        //            i++;
        //        }
        //    }
        //    return new string(chars);
        }

    }
}
