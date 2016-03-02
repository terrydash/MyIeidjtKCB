using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Common
{
    public class ConvertMethod
    {

        public int? ConvertStringToInt(string stringToCovert)
        {
            int outInt;
            try
            {
                int.TryParse(stringToCovert,out outInt);
            }

            catch (Exception ex)
            {
                return null;
                
            }
            return outInt;

        }
    }
}
