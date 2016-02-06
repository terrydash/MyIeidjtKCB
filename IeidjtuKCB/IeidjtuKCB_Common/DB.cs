using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
namespace IeidjtuKCB_Common
{   /// <summary>
    /// 数据库连接上下文
    /// </summary>
    public class DB
    {
        public static readonly DbSession Context = new DbSession(DatabaseType.SqlServer9, @"Data Source=.\xuguoxu52;Database=Education;User Id=sa;Password=52Xuguoxu;");
    }
}
