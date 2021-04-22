using System;
using System.Collections.Generic;
using System.Text;

namespace Dotty.BLL
{
    public class NumberLogic
    {
        public int GetIntFromStringArr(string[] inputString)
        {
           
            if(inputString == Digits.Strings1)
            {
                return 1;
            }
            if (inputString == Digits.Strings3)
            {
                return 3;
            }

            return 0;

        }
    }
}
