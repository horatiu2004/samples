using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(find_it(new int[] { 1,2,2 }));
        }

        public static int find_it(int[] seq)
        {
            var x = seq.GroupBy(i => i).Single(e => e.Count() % 2 == 1).Key;
          
            

           return -1;
        }

        public static string Solution(string key, string message)
        {
            string messageUnlocked = "";
            List<int> keyUnlocked = new List<int>();
            string ordered = String.Concat(key.OrderBy(item => item));

            for (int i = 0; i < ordered.Length; i++)
            {
                keyUnlocked.Add(ordered.IndexOf(key[i]) + 1);
            }

            int count = 0;
            while (count < message.Length)
            {
                if (count % keyUnlocked.Count == 0)
                {
                    for (int j = 0; j < keyUnlocked.Count; j++)
                    {
                        if(keyUnlocked.Count + count > message.Length)
                        {
                            break;
                        }
                        if (keyUnlocked[j] + count <= message.Length)
                        {
                            messageUnlocked += message[keyUnlocked[j] + count - 1];
                        }
                    }
                    count += keyUnlocked.Count;
                }
            }

            messageUnlocked += message.Substring(messageUnlocked.Length, message.Length - messageUnlocked.Length);

            return Regex.Replace(messageUnlocked, @"\s+", "");
        }

        public static string DecimalToHexadecimal(int n)
        {
            if (n >= 255) return "FF";
            else if (n <= 0) return "00";
            else if (n.ToString("X").Length == 1) return "0" + n.ToString("X");
            return n.ToString("X");
        }

        public static int CountBits(int n)
        {
            int test = Convert.ToString(n, 2).Where(element => element == '1').Count();

            return -1;
        }

        public static string dirReduc(string s)
        {
            //string weights = "11    1234000   11  123     44444444 9999   2000 10003 22";
            return string.Join(" ", s.Split(' ')
          .OrderBy(n => n.ToCharArray()
          .Select(c => (int)char.GetNumericValue(c)).Sum())
          .ThenBy(n => n));
        }

    public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            long boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static int[] largestValuesInTreeRows(Tree<int> t)
        {
            Queue<Tree<int>> q = new Queue<Tree<int>>();
            List<int> values = new List<int>();

            if (t != null)
            {
                q.Enqueue(t);
            }

            while (q.Count > 0)
            {
                values.Add(-2000);
                foreach (var i in q.ToList())
                {
                    var val = q.Dequeue();
                    if (val.value > values[values.Count - 1])
                    {
                        //Console.WriteLine(values[values.Count - 1]);
                        values[values.Count - 1] = val.value;
                    }
                    if (val.left != null)
                    {
                        q.Enqueue(val.left);
                    }
                    if (val.right != null)
                    {
                        q.Enqueue(val.right);
                    }
                }
            }
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            return values.ToArray();
        }



        private static int KthLargestElement(int[] nums, int k) => nums[k - 1];

        private static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial((n - 1));
        }

        private static int Power(int n, int pow)
        {
            if (pow == 1)
                return n;
            return n * Power(n, pow - 1);
        }


        public class Tree<T> {
           public T value { get; set; }
           public Tree<T> left { get; set; }
           public Tree<T> right { get; set; }
        }


        private static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            ListNode<int> iterator = l;

            while(iterator != null)
            {
                if(iterator.value == k)
                {
                    iterator = iterator?.next;
                    l = iterator;
                    continue;
                }

                if(iterator?.next?.value == k)
                {
                    iterator.next = iterator.next?.next;
                }
                else
                {
                    iterator = iterator.next;
                }
            }

            return l;
        }
    }
}