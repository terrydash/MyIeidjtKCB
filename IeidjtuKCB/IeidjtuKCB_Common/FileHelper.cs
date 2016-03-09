using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Common
{/// <summary>
/// 生成静态文件类
/// </summary>
    public static class FileHelper
    {
        /// <summary>  
        /// 写文件  
        /// </summary>  
        /// <param name="Path">文件路径</param>  
        /// <param name="Name">文件名(包括后缀名)</param>  
        /// <param name="content">内容</param>  
        /// <returns></returns>  
        public static bool WriteFile(string fname, StringBuilder content)
        {
            try
            {
                string path = System.Environment.CurrentDirectory;
                
                if (!File.Exists(fname))
                {
                    FileStream fs = File.Create(fname);
                    fs.Close();
                }
                StreamWriter sw = new StreamWriter(fname, false, System.Text.Encoding.UTF8);
                sw.WriteLine(content);
                sw.Close();
                sw.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>  
        /// 读文件  
        /// </summary>  
        /// <param name="path">文件路径</param>  
        /// <returns></returns>  
        public static StringBuilder ReadFile(string filename)
        {
            String line;
            StringBuilder htmltext = new StringBuilder();
            try
            {
               

                StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8);
                while ((line = sr.ReadLine()) != null)
                {
                    htmltext.Append(line);
                }
                sr.Close();
            }

            catch
            {
                return null;
            }
            return htmltext;
          
        }
    }
 }

