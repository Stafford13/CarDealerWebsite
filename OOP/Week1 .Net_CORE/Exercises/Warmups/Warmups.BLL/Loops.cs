using System;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            int x = n;
            if (n == 1)
            {
                return str;
            }
            else if (n >= x)
            {
                string result = string.Join(str, new string[x + 1]);
                return result;
            }
            throw new NotImplementedException();
        }

        public string FrontTimes(string str, int n)
        {
            //string str.Substring(0, 3);
            int x = n;
            if (n == 1)
            {
                return str.Substring(0, 3);
            }
            else if (n >= x)
            {
                string result = string.Join(str.Substring(0,3), new string[x + 1]);
                return result;
            }

            throw new NotImplementedException();
        }

        public int CountXX(string str)
        {
            // XX counter
            int xx = 0;
            for (int i = 0; i < str.Length-1; i++)
                if (str.Substring(i, 2) == "xx")
                {
                    xx++;
                }
            return xx;
        }

        public bool DoubleX(string str)
        {
            //if (str.Substring("x"))

            //{
            //    return true;
            //}
            //else if ()
            throw new NotImplementedException();
        }

        public string EveryOther(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (i <= 0)
                {
                    Console.Write(str);
                }
                else if (i % 2 == 0)
                { 
                    Console.Write(str); 
                }
                else if (i % 2 != 0)
                {
                    continue;
                }
            throw new NotImplementedException();
        }

        public string StringSplosion(string str)
        {
           if (str.Length <= 2)
            {
                return str.Substring(0, 1) + str;
            }
           else if (str.Length == 3)
            {
                return str.Substring(0, 1) + str.Substring(0, 2) + str;
            }
           else if (str.Length == 4)
            {
                return str.Substring(0, 1) + str.Substring(0, 2) + str.Substring(0, 3) + str;
            }
            
            throw new NotImplementedException();
        }

        public int CountLast2(string str)
        {
            throw new NotImplementedException();
        } 

        public int Count9(int[] numbers)
        {
            //indexOf.numbers(9);
            throw new NotImplementedException();
        }

        public bool ArrayFront9(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Array123(int[] numbers)
        {
        //string numerical = int Array123[] = ;
        //while (true)
            //{
            //    if (numerical[.contains(1, 2, 3))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            throw new NotImplementedException();
        }

        public int SubStringMatch(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string StringX(string str)
        {
            throw new NotImplementedException();
        }

        public string AltPairs(string str)
        {
            string newString = "";
            for (int i = 0; i <str.Length; i+=4)
            {
                if (i+1 == str.Length)
                {
                    newString += str.Substring(i, 1);
                }
                else
                {
                    newString += str.Substring(i, 2);
                }
            }
            return newString;
        }

        public string DoNotYak(string str)
        {
            //int strLength = str.Length;
            //int x;
            //Int32.TryParse(str, out x);
            if (str.Length > 0)
            {
                return str.Replace("yak", "");
            }
            else
            {
                Console.WriteLine(str);
            }
            //str.Remove(x);
            //Console.WriteLine(str.Remove(x));
            throw new NotImplementedException();
        }

        public int Array667(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool NoTriples(int[] numbers)
        {
            //if (
            throw new NotImplementedException();
        }

        public bool Pattern51(int[] numbers)
        {
            throw new NotImplementedException();
        }

    }
}
