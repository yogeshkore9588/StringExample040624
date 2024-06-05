namespace StringExample040624
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //5. Write a C# program to concatenate two strings using the + operator.*/ 
            /*
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();
            char[] ch3 = new char[ch1.Length + ch2.Length];
            for (int i = 0, j = 0; i < ch3.Length - 1; i++, j++)
            {
                if (j < ch1.Length)
                {
                    ch3[i] = ch1[j];
                    i++;
                }
                if (j < ch2.Length)
                {
                    ch3[i] = ch2[j];
                }
            }
            Console.WriteLine(ch3);
            */
            //6. Write a C# program to find the length of a string in C#.

            string S1 = " kore ";
            string s2 = "good morning india";
            Console.WriteLine(S1);

            Console.WriteLine("length of string is s1:" + S1.Length);
            Console.WriteLine(s2);
            Console.WriteLine("length of string is s2:" + s2.Length);

            string s3 = S1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine("length of string is s3:" + s3.Length);


            //7. write a program to convert a string to uppercase and lowercase in c#.
          /*
            string s1 = "Hello India";
            char[] ch1 = s1.ToCharArray();
            for (int i = 0; i < s1.Length; i++)
            {
                if (ch1[i] >= 'a' || ch1[i] <= 'z')
                {
                    ch1[i] = (char)(ch1[i]);
                }
            }
          */

            //8. Write a c# program to reverse a given string without using any built-in functions.
            /*
            string A1 = "I love india";
            char[] A11 = A1.ToCharArray();

            for (int i = 0; i < A11.Length; i++)
            {
                for (int j = i; j < A11.Length; j++)
                {

                    if (A11[i] > A11[j])
                    {
                        char temp = A11[i];
                        A11[i] = A11[j];
                        A11[j] = temp;
                    }

                }
            }
            //converting charArray  to string
            A1 = new string(A11);//

            Console.WriteLine(A1);
            */

            //9. Implement a method to check if a given string, is a palindrome.

            /*string a1 = "ABCBA";

       char[] A1 = a1.ToCharArray();
       string temp = a1;
       Console.WriteLine(temp);

       for (int i=0;i<a1.Length;i++)
       {
           char c;
           for (int j=i;j<a1.Length;j++)
           {
               c = A1[i];
               A1[i] = A1[j];
               A1[j] = c;

           }
       }
       a1=new string(A1);
       Console.WriteLine(a1);
       if(temp==a1)
       {
           Console.WriteLine(a1+" is Pallindrome");
       }
       else
       {
           Console.WriteLine(a1+" is not pallindrome");
       }
       */


            // 10. Write a C# method to count the number of occurrences of a specific character in a string.

            //Console.WriteLine("enter the string");
            //string s1 = Console.ReadLine();
            //int i = 0;
            //int count = 0;
            //while(i != s1.Length)
            //{
            //    count++;
            //    i++;
            //}
            //Console.WriteLine("The string is "+s1);
            //Console.WriteLine("count="+count);

        }
    }
}