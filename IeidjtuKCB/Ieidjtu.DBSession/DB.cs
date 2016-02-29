using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
using System.Data.SqlClient;
using System.Data.Common;


namespace IeidjtuKCB.DBSession
{   /// <summary>
    /// 数据库连接上下文
    /// </summary>
    public  class DB
    {
        public static  DbSession Context = new DbSession(DatabaseType.SqlServer9, @"Data Source=.\XUGUOXU54;Database=Education;User Id=sa;Password=52Xuguoxu;");
        /// <summary>
        /// 执行带参数的SQL语句
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>返回影响的数目</returns>
        public int ExecutNoneQuery(string sql, IList<DbParameter> parameters)
        {
            DbCommand db = Context.Db.GetSqlStringCommand(sql);
            if (!(parameters == null || parameters.Count == 0))
            {
                foreach (DbParameter parameter in parameters)
                {
                    db.Parameters.Add(parameter);
                }
            }
           
            return Context.ExecuteNonQuery(db);
        }
    }
}
