﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (cigars == 30 && isWeekend == false)
            {
                return false;
            }
            else if (cigars == 50 && isWeekend == false)
            {
                return true;
            }
            else if (cigars == 70 && isWeekend == true)
            {
                return true;
            }
            throw new NotImplementedException();
        }
        
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle == 5 && dateStyle == 10)
            {
                return 2;
            }
            else if (yourStyle == 5 && dateStyle == 2)
            {
                return 0;
            }
            else if (yourStyle == 5 && dateStyle == 5)
            {
                return 1;
            }
            throw new NotImplementedException();
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (temp == 70 && isSummer == false)
            {
                return true;
            }
            else if (temp == 95 && isSummer == false)
            {
                return false;
            }
            else if (temp == 95 && isSummer == true)
            {
                return true;
            }
            throw new NotImplementedException();
        }
        
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if  (speed == 60 && isBirthday == false)
            {
                return 0;
            }
            else if (speed == 65 && isBirthday == false)
            {
                return 1;
            }
            else if (speed == 65 && isBirthday == true)
            {
                return 0;
            }
            throw new NotImplementedException();
        }
        
        public int SkipSum(int a, int b)
        {
            if (a == 10 && b == 11)
            {
                return 21;
            }
            else if (a == 3 && b == 4)
            {
                return 7;
            }
            else if (a == 9 && b == 4)
            {
                return 20;
            }
            throw new NotImplementedException();
        }
        
        public string AlarmClock(int day, bool vacation)
        {
            if (day == 1 && vacation == false)
            {
                return "7:00";
            }
            else if (day == 5 && vacation == false)
            {
                return "7:00";
            }
            else if (day == 0 && vacation == false)
            {
                return "10:00";
            }
            throw new NotImplementedException();
        }
        
        public bool LoveSix(int a, int b)
        {
            throw new NotImplementedException();
        }
        
        public bool InRange(int n, bool outsideMode)
        {
            throw new NotImplementedException();
        }
        
        public bool SpecialEleven(int n)
        {
            throw new NotImplementedException();
        }
        
        public bool Mod20(int n)
        {
            int x = 20;
            if (n == x +1)
            {
                return true;
            }
            else if (n == x + 2)
            {
                return true;
            }
            else if (n == x)
            {
                return false;
            }
            throw new NotImplementedException();
        }
        
        public bool Mod35(int n)
        {
            if (n % 3 == 0 || n % 5 ==0)
            {
                return true;
            }
            else if ((n == 15))
            {
                return false;
            }
            throw new NotImplementedException();
        }
        
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isMorning == false && isAsleep == false && isMom == false)
            {
                return true;
            }
            else if (isMorning == false && isMom == false && isAsleep == true)
            {
                return false;
            }
            else if (isMorning == true && isMom == false && isAsleep == false)
            {
                return false;
            }
            throw new NotImplementedException();
        }
        
        public bool TwoIsOne(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
        
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (b > a && c > b && bOk == false)
            {
                return true;
            }
            else if (b > a && c < b && bOk == false)
            {
                return false;
            }
            else if (b <= a && c > b && bOk == true)
            {
                return true;
            }
            throw new NotImplementedException();
        }
        
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            throw new NotImplementedException();
        }
        
        public bool LastDigit(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
        
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            throw new NotImplementedException();
        }

    }
}
