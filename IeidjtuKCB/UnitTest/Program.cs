using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB_Common;
using IeidjtuKCB_DAL;
using IeidjtuKCB_Model;


using System.Reflection;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ActiveYear_DAL ActiveYearDal = new ActiveYear_DAL();
            var AllActiveYearList = ActiveYearDal.GetAllActvieYear();

            foreach (var a in AllActiveYearList)
           {
                
                
                var properties = a.GetType().GetProperties();
                foreach (var item in properties)
                    Console.WriteLine(item);
            

        }

            Console.ReadKey();
        }
        private static void FindItemID<T>(T val, string FindPropertyName, String FindProertyValue)
        {
            var pros = typeof(T).GetFields();
            foreach (FieldInfo p in pros)
            {
                Console.WriteLine(p.Name);

                
            }
        }
    }

   
}
