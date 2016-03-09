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
        public static bool WriteFile(string filename, string content)
        {
            try
            {
                string path = System.Environment.CurrentDirectory;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string fname = path + @"\" + filename;
                if (!File.Exists(fname))
                {
                    FileStream fs = File.Create(fname);
                    fs.Close();
                }
                StreamWriter sw = new StreamWriter(fname, false, System.Text.Encoding.GetEncoding("utf-8"));
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
        public static string ReadFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename, System.Text.Encoding.GetEncoding("utf-8"));
                string content = sr.ReadToEnd().ToString();
                sr.Close();
                return content;
            }
            catch
            {
                return null;
            }
        }
    }
}
