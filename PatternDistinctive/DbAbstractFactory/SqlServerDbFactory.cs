using System.Data.SqlClient;
using System.Data;

namespace _3S_eShop.Connect
{
    public class SqlServerDbFactory : DatabaseFactory
    {
        public override IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override IDbCommand CreateCommand(string cmdText)
        {
            return new SqlCommand(cmdText);
        }

        public override IDbCommand CreateCommand(string cmdText, IDbConnection cn)
        {
            return new SqlCommand(cmdText, (SqlConnection)cn);
        }

        public override IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override IDbConnection CreateConnection(string cnString)
        {
            return new SqlConnection(cnString);
        }

        public override IDbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public override IDbDataAdapter CreateDataAdapter(IDbCommand selectCmd)
        {
            return new SqlDataAdapter((SqlCommand)selectCmd);
        }

        public override IDataReader CreateDataReader(IDbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }
    }
}
