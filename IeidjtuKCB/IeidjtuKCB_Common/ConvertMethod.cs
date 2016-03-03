using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Common
{
    public static class ConvertMethod
    {

        public static int? ConvertStringToInt(string stringToCovert)
        {
            int outInt;
            try
            {
                int.TryParse(stringToCovert,out outInt);
            }

            catch 
            {
                return null;
                
            }
            return outInt;

        }
    }
}
