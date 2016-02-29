using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
namespace IeidjtuKCB.DBSession
{   /// <summary>
    /// 数据库连接上下文
    /// </summary>
    public class DB
    {
        public static readonly DbSession Context = new DbSession(DatabaseType.SqlServer9, @"Data Source=.\XUGUOXU54;Database=Education;User Id=sa;Password=52Xuguoxu;");
    }
}
