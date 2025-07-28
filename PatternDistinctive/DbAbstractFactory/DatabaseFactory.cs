using System.Data;

namespace _3S_eShop.Connect
{
    public abstract class DatabaseFactory
    {
        public abstract IDbCommand CreateCommand();
        public abstract IDbCommand CreateCommand(string cmdText);
        public abstract IDbCommand CreateCommand(string cmdText, IDbConnection cn);
        public abstract IDbConnection CreateConnection();
        public abstract IDbConnection CreateConnection(string cnString);
        public abstract IDbDataAdapter CreateDataAdapter();
        public abstract IDbDataAdapter CreateDataAdapter(IDbCommand selectCmd);
        public abstract IDataReader CreateDataReader(IDbCommand dbCmd);
    }

}
