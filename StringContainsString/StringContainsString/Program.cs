using System;

namespace StringContainsString
{
    class Program
    {
        static string isSubset(string[]a,string []b)
        {
            int i = 0;
            int j = 0;
            if (a.Length > b.Length) //if b has less elements than a, b cannot contain a
                return "No";
            for (i = 0; i < a.Length; i++) // serching elements from a in b
            {
                for (j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                        break;


                if (j == b.Length) // because we used break before, if j reaches the length of b, at least one element from a is not in b
                {
                    
                    return "No";
                }
            }

           
            return "Yes";
        }
        static void Main(string[] args)
        {
            string[] B = { "Purple", "Yellow" };
            string[] A = { "Green", "Yellow", "Red", "Blue", "Purple"};
            Console.WriteLine(isSubset(A, B));
           
        }
    }
}
