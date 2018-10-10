using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }
        public bool IsConnected { get; protected set; }

        public DbConnection(string connection)
        {
            if (connection != null && !String.IsNullOrWhiteSpace(connection))
            {
                this.ConnectionString = connection;
            }
            else
            {
                throw new ArgumentException("Connection must be initialized with a connnection string.", "connection");
            }
        }

        public abstract void Open();

        public abstract void Close();
    }
}
