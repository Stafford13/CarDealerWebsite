using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        public string InsertWord(string container, string word) 
        {
            string FirstHalf = container.Substring(0, 2);
            string LastHalf = container.Substring(2, 2);
            return $"{FirstHalf}{word}{LastHalf}";
        }

        public string MultipleEndings(string str)
        { 
            string newline = str.Substring(str.Length - 2, 2);
            return $"{newline}{newline}{newline}";
            //throw new NotImplementedException();
        }

        public string FirstHalf(string str)
        {
            //string Half = str.Substring(str.Length / 2);
            //string first = Half..........
            //return first;
            throw new NotImplementedException();
        }

        public string TrimOne(string str)
        {
            //string newtrim = str.Substring
            throw new NotImplementedException();
        }

        public string LongInMiddle(string a, string b)
        {
            //string c = a < b;
            throw new NotImplementedException();
        }

        public string RotateLeft2(string str)
        {
            string newstring = str.Substring(0, 2);
            string rotate = str.Substring(2) + newstring;
            return rotate;
            //throw new NotImplementedException();
        }

        public string RotateRight2(string str)
        {
            //string newstring = str.Substring(str.Length, str.Length-2);
            //string rotate = $"{newstring}{str.Substring(str.Length)}";
            //return rotate;
            throw new NotImplementedException();
        }

        public string TakeOne(string str, bool fromFront)
        {
            //string newtake = 
            throw new NotImplementedException();
        }

        public string MiddleTwo(string str)
        {
            throw new NotImplementedException();
        }

        public bool EndsWithLy(string str)
        {
            //string ending = ToString.(str.Length - 2);
            //if (ending == "ly")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            throw new NotImplementedException();
        }

        public string FrontAndBack(string str, int n)
        {
            string front = str.Substring(0, n);
            string back = str.Substring(str.Length - n);
            return $"{front}{back}";
            //throw new NotImplementedException();
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            throw new NotImplementedException();
        }

        public bool HasBad(string str)
        {
            throw new NotImplementedException();
        }

        public string AtFirst(string str)
        {
           //Console.WriteLine($"{s.Remove(2)} 
            throw new NotImplementedException();
        }

        public string LastChars(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string ConCat(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string SwapLast(string str)
        {
            throw new NotImplementedException();
        }

        public bool FrontAgain(string str)
        {
            throw new NotImplementedException();
        }

        public string MinCat(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string TweakFront(string str)
        {
            throw new NotImplementedException();
        }

        public string StripX(string str)
        {
            Console.WriteLine(str.Replace("Hxix","Hxi"));

            throw new NotImplementedException();
        }
    }
}


//Select a gesture (throw hands):
//1. Rock
//2. Paper
//3. Scissor
//Choose 1-3:
//If loop (calls methods, like the practice.sln
//Random r = new Random():
// int choice = r.Next(3)+1;

// I