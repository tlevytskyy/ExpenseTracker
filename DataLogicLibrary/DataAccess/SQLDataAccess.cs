using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        public static List<T> LoadData<T>(string connectionstring,string sql)
        {
            using(IDbConnection conn = new SqlConnection(connectionstring))
            {
                return conn.Query<T>(sql).ToList();
            }
        }

        public static List<T> LoadDataParam<T>(string connectionstring, string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(connectionstring))
            {
                return conn.Query<T>(sql,data).ToList();
            }
        }

        public static int SaveData<T>(string connectionstring, string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(connectionstring))
            {
                return conn.Execute(sql, data);
            }
        }
    }
}
