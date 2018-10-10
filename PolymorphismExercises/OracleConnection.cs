using System;

namespace PolymorphismExercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection)
            :base(connection)
        {

        }
        public override void Close()
        {
            if (IsConnected)
            {
                Console.WriteLine("Oracle Connection Closed");
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
                Console.WriteLine("Oracle Connection Opened");
                IsConnected = true;
            }
            else
            {
                throw new InvalidOperationException("Cannot open an already opened connection");
            }
        }
    }
}
