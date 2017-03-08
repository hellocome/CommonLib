using System.Collections.Generic;
using CommonLib.Database.MSSQL;
using CommonLib.Database;

namespace CommonLib.Database.MSSQL
{
    public abstract class MSSQLDatabase : MSSQLConnectionBase
    {
        private IDatabaseStatements mStatements;

        public override Dictionary<int, PreparedStatement> PreparedStatementMap
        {
            get
            {
                return mStatements.GetPreparedStatementMap;
            }
        }

        public MSSQLDatabase(IDatabaseStatements statements, string connectionString) : base(connectionString)
        {
            mStatements = statements;
        }
    }
}
