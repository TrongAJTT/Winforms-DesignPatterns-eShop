using MySql.Data.MySqlClient;
using System.Data;

namespace _3S_eShop.Connect
{
    public class MySqlDbFactory : DatabaseFactory
    {
        public override IDbCommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public override IDbCommand CreateCommand(string cmdText)
        {
            return new MySqlCommand(cmdText);
        }

        public override IDbCommand CreateCommand(string cmdText, IDbConnection cn)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)cn);
        }

        public override IDbConnection CreateConnection()
        {
            return new MySqlConnection();
        }

        public override IDbConnection CreateConnection(string cnString)
        {
            return new MySqlConnection(cnString);
        }

        public override IDbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        public override IDbDataAdapter CreateDataAdapter(IDbCommand selectCmd)
        {
            return new MySqlDataAdapter((MySqlCommand)selectCmd);
        }

        public override IDataReader CreateDataReader(IDbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }
    }
}
