using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection conn1 = new OracleConnection("ASX12632");
            conn1.Open();

            SqlConnection conn2 = new SqlConnection("JSKGKee223");
            conn2.Close();
            conn1.Close();


        }
    }
}
