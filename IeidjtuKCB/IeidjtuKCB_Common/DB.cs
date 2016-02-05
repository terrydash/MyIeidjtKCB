using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
namespace IeidjtuKCB_Common
{
    public class DB
    {
        public static readonly DbSession Context = new DbSession(DatabaseType.SqlServer9, "Data Source=127.0.0.1;Database=DBName;User Id=root;Password=root;");
    }
}
