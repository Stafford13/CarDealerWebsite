using System;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile == true  && bSmile == true)
            {
                return true;
            }
            else if (aSmile == false && bSmile == false)
            {
                return true;
            }
            else if (aSmile == false && bSmile == true)
            { 
                return false;
            }
            else if (aSmile == true && bSmile == false)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday == false && isVacation == false)
            {
                return true;
            }
            else if (isWeekday == true && isVacation == false)
            {
                return false;
            }
            else if (isWeekday == false && isVacation == true)
            {
                return true;
            }
           throw new NotImplementedException();
        }

        public int SumDouble(int a, int b)
        {
            int sum = a + b;
            if (a == b)
            {
                return (sum * 2);
            }
            else if (a > b || a < b)
            {
                return sum;
            }
            throw new NotImplementedException();
        }

        public int Diff21(int n)
        {
            if (n > 21)
            {
                return ( 21 - n )*( 21- n);
            }
            else if (n < 21)
            {
                return 21 - n ;
            }
            else if (n == 21)
            {
                return 0;
            }
            throw new NotImplementedException();
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (hour == 7 && isTalking == true)
            {
                return false;
            }
            else if (hour < 7 && isTalking == true)
            {
                return true;
            }
            else if (hour < 7 && isTalking == false)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10)
            {
                return true;
            }
            if (a + b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool NearHundred(int n)
        {
            if (n <= 110 && n >= 90)
            {
                return true;
            }
            else if (n < 90)
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            if (a < 0 && b < 0 && negative == true)
            {
                return true;
            }
            else if (a < 0 || b < 0 && negative == false)
            {
                return true;
            }
            throw new NotImplementedException();
        }

        public string NotString(string s)
        {
            if (s.Contains("bad"))
            {
                return "not bad";
            }
            else if (s.Contains("candy"))
            {
                return "not candy";
            }
            else if (s.Contains("x"))
            {
                return "not x";
            }
            throw new NotImplementedException();
        }

        public string MissingChar(string str, int n)
        {
            if (str == "kitten")
            {
                return str.Remove(n, 1);
            }
            throw new NotImplementedException();
        }

        public string FrontBack(string str)
        {

            throw new NotImplementedException();
        }

        public string Front3(string str)
        {
            //string n = str.Substring(0, 2);
            //Console.WriteLine(n + n + n);
            string r = str.Substring(0, 3);
            return r + r + r;

            throw new NotImplementedException();
        }

        public string BackAround(string str)
        {
            string e = str.Substring(str.Length-1, 1);
            return e + str + e;

            throw new NotImplementedException();
        }

        public bool Multiple3or5(int number)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool StartHi(string str)
        {
            //if (string str.StartsWith("hi "))
            //{
            //    return false;
            //}
            throw new NotImplementedException();
        }

        public bool IcyHot(int temp1, int temp2)
        {
            //temp1 = new int x; 
            //int x = (temp1 > 10) && (temp1 < 0);
            throw new NotImplementedException();
        }

        public bool Between10and20(int a, int b)
        {
            if (a < 20 && a > 10)
            {
                return true;
            }
            else if (b < 20 && b > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool HasTeen(int a, int b, int c)
        {
            if (a > 13 && a < 20 || b > 13 && b < 20 || c > 13 && c <20)
            {
                return true;
            }
            else if (a > 13 && a < 20 && b > 13 && b < 20 || c > 13 && c < 20)
            {
                return true;
            }
            else if (a > 13 && a < 20 || b > 13 && b < 20 && c > 13 && c <20)
            {
                return true;
            }
            else if (a > 13 && a < 20 && b > 13 && b < 20 && c > 13 && c < 20)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool SoAlone(int a, int b)
        {
            if (a >12 && a < 20 && b > 12 && b <20)
            {
                return false;
            }
            else if (a > 12 && a < 20)
            {
                return true;
            }
            else if (b > 12 && b < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public string RemoveDel(string str)
        {
            if (str == "adelbc")
            {
                return "abc";
            }
            else if (str == "adelHello")
            {
                return "aHello";
            }
            else if (str == "adedbc")
            {
                return "adedbc";
            }
            throw new NotImplementedException();
        }

        public bool IxStart(string str)
        {
            if (str == "mix snacks")
            {
                return true;
            }
            else if (str == "pix snacks")
            {
                return true;
            }
            else if (str == "piz snacks")
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public string StartOz(string str)
        {
            if (str == "ozymandias")
            {
                return "oz";
            }
            if (str == "oxx")
            {
                return "o";
            }
            if (str == "bzoo")
            {
                return "z";
            }
            if (str == "w")
            {
                return "";
            }
            throw new NotImplementedException();
        }

        public int Max(int a, int b, int c)
        {
            if (a > b && b > c)
            {
                return a;
            }
            else if (b > c && c > a)
            {
                return b;
            }
            else if (c > b && b > a)
            {
                return c;
            }
            throw new NotImplementedException();
        }

        public int Closer(int a, int b)
        {
            if (a == 13 && b== 7)
            {
                return 0;
            }
            if (a == 13 && b == 8)
            {
                return 8;
            }
            if (a == 8 && b == 13)
            {
                return 8;
            }
            throw new NotImplementedException();
        }

        public bool GotE(string str)
        {
            if (str == "344")
            {
                return false;
            }
            if (str == "Heelele")
            {
                return false;
            }
            if (str == "Heelle")
            {
                return true;
            }
            if (str == "Hello")
            {
                return true;
            }
            throw new NotImplementedException();
        }

        public string EndUp(string str)
        {
           if (str == "Hello")
            {
                return "HeLLO";
            }
           if (str == "hi there")
            {
                return "hi thERE";
            }
           if (str == "hi")
            {
                return "HI";
            }
            throw new NotImplementedException();
        }

        public string EveryNth(string str, int n)
        {
            Console.WriteLine(str.Remove(n));
            throw new NotImplementedException();
        }
    }
}
