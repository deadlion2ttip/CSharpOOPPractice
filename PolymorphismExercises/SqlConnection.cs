using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection)
            :base(connection)
        {

        }
        public override void Close()
        {
            if (IsConnected)
            {
                Console.WriteLine("SQL Connection Closed");
                IsConnected = false;
            }
            else
            {
                throw new InvalidOperationException("Cannot close a connection that has not been opened");
            }
        }

        public override void Open()
        {
            if (!IsConnected)
            {
                Console.WriteLine("SQL Connection Opened");
                IsConnected = true;
            }
            else
            {
                throw new InvalidOperationException("Cannot open an already opened connection");
            }
        }
    }
}
