using System;
using System.Data;
using System.Data.SqlClient;
using CommonLib.Database;

namespace CommonLib.Database.MSSQL
{
    public abstract class MSSQLConnectionBase : DBConnectionBase
    {
        public MSSQLConnectionBase(string connectionString) : base(connectionString)
        {
        }

        public override int Execute(string str)
        {
            return Execute(str, null);
        }

        public override int Execute(string str, params object[] paras)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = PrepareDBCommand(connection, str, paras);

                return command.ExecuteNonQuery();
            }
        }

        public override void ExecuteAsync(string str)
        {
            ExecuteAsync(str, null);
        }

        public override void ExecuteAsync(string str, params object[] paras)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = PrepareDBCommand(connection, str, paras);

                command.ExecuteNonQueryAsync();
            }
        }

        public override void Execute(PreparedStatement str, params object [] paras)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = PrepareDBCommand(connection, str, paras);

                if (str.ConnectionFlag == ConnectionFlags.CONNECTION_SYNCH)
                {
                    command.ExecuteNonQuery();
                }
                else
                {
                    command.ExecuteNonQueryAsync();
                }
            }
        }

        public override void Execute(PreparedStatement str)
        {
            Execute(str, null);
        }

        public override IDataReader QuerySync(PreparedStatement str)
        {
            return QuerySync(str, null);
        }

        public override IDataReader QuerySync(PreparedStatement str, params object[] paras)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = PrepareDBCommand(connection, str, paras);

            // close connection after IDataReader is closed
            return command.ExecuteReader(CommandBehavior.CloseConnection);
            
        }

        protected SqlCommand PrepareDBCommand(SqlConnection dbConnection, PreparedStatement str, params object[] paras)
        {
            SqlCommand command = new SqlCommand(str.SQLString, dbConnection);
            command.Prepare();

            if (paras != null)
            {
                foreach (object value in paras)
                {
                    command.Parameters.Add(value);
                }
            }

            return command;
        }

        protected SqlCommand PrepareDBCommand(SqlConnection dbConnection, string str, params object[] paras)
        {
            SqlCommand command = new SqlCommand(str, dbConnection);
            command.Prepare();

            if (paras != null)
            {
                foreach (object value in paras)
                {
                    command.Parameters.Add(value);
                }
            }

            return command;
        }

    }
}
