using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    public class ListDemo
    {
        public static void Run()
        {
            int x = 2;
            // must specify the size of the array
            int[] x1 = new int[2];
            // index starts at 0
            x1[0] = 1;
            x1[1] = 2;

            // increasing the size of the array needs a new array
            // ie. double the size of x1
            int[] x2 = new int[x1.Length * 2];
            Array.Copy(x1, 0, x2, 0, x1.Length);

            List<int> x3 = new List<int>();
            x3.Add(1);
            x3.Add(2);
            x3.Add(3);
            x3.Add(3);
            x3.Remove(3);
            List<string> s3 = new List<string>();
            s3.Add("Bob");
            s3.Add("Sally");
            s3.Add("Bob");
            s3.Add("John");
            s3.Add("Bob");


            // Do not do this... will error, instead use a for loop
            //foreach (string s in s3)
            //{
            //    if (s == "Bob")
            //    {
            //        s3.Remove(s);
            //    }
            //}
            for (int i = s3.Count-1; i >= 0; i--)
            {
                if (s3[i] == "Sally")
                {
                    s3.RemoveAt(i);
                }
            }

            // remove 1 instance of bob
            s3.Remove("Bob");

            // provide a predicate which is like a foreach statement
            // s => is the variable you defined in a foreach
            // right side of => is a condition statement that must result in true/false
            // RemoveAll will remove all that matches the predicate (true)
            s3.RemoveAll(s => s == "Bob");

            // removes all things!
            //s3.RemoveAll(s => true);
            s3.Clear();
            
            //foreach (string s in s3)
            //{
            //    if (s == "Bob")
            //    {
            //        s3.Remove(s);
            //    }
            //}

            s3.RemoveAt(2);

            Console.WriteLine(x3[1]);
        }
    }
}
