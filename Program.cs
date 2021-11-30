using System;

using System.Text;

namespace ValueReferance
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;

            //int b = a;
            //a = 9;
            //Console.WriteLine($"a-{a}");
            //Console.WriteLine($"b-{b}");

            //int[] arr = { 1, 8, 7 };
            //int[] arr1 = arr;
            ////arr[0] = 10;
            //arr1[0] = 10;
            //Console.WriteLine(arr[0]);
            //int num=18;

            //Change(ref num);
            //Console.WriteLine($"num-{num}");

            //int[] arr = { 0, 19, 20 };
            //Console.WriteLine($"arr[0]-{arr[0]}");
            //ChangeArr(arr);
            //Console.WriteLine($"arr[0]-{arr[0]}");


            //int a=90;
            //Change(ref a);
            //Console.WriteLine($"a-{a}");

            //string word = "Hello";
            //string word1 = word;
            //word1 = "Bye";
            //word = word1;
            //Console.WriteLine(word1);
            //Console.WriteLine(word);

            //Console.WriteLine(CustomReverse("Hello World"));
            //string word1 = "World Hello";
            //string word = "helloo";

            //Console.WriteLine(word.Replace('l','s'));
            //Console.WriteLine(word.CompareTo(word1));
            //Console.WriteLine(String.Compare(word1, word));
            //Console.WriteLine(word1.Trim());
            //Console.WriteLine(word1.ToLower());
            //Console.WriteLine(word1.ToUpper());
            //Console.WriteLine();
            //string[] str = word1.Split(' ');
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            int[] arr = { 3, 4, 56, 8 };
         Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            //Array.Resize(ref arr, arr.Length + 1);
            //arr[4] = 19;
            //Console.WriteLine(arr[4]);
            //int[] arr1 = new int[5];



        }

        static StringBuilder CustomReverse(string str)
        {
            //string result = String.Empty;
            StringBuilder sb = new StringBuilder();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    result += str[i];
            //}
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            //foreach (char item in str)
            //{
            //    sb.Append(item);
            //}
            return sb;
        }

        //static void Change(ref int a)
        //{

        //    Console.WriteLine($"a-{a}");
        //}

        //static void ChangeArr(int[] arr)
        //{
        //    arr[0] = 16;
        //    Console.WriteLine($"arr[0]-{arr[0]}");
        //}
    }
}
