using System;

namespace PolymorphismExercises
{
    public class DbCommand
    {
        public DbConnection Connection { get;private set; }
        public string Command { get; private set; }

        public DbCommand(DbConnection connection, string command)
        {
            if (connection != null)
            {
                this.Connection = connection;
            }
            else
            {
                throw new ArgumentNullException("connection");
            }

            if (!string.IsNullOrWhiteSpace(command))
            {
                this.Command = command;
            }
            else
            {
                throw new ArgumentNullException("connection");
            }

        }

        public void Execute()
        {
            this.Connection.Open();
            Console.WriteLine("Command {0} sent to connection {1}.", Command, Connection.ConnectionString);
            this.Connection.Close();
        }
    }
}
