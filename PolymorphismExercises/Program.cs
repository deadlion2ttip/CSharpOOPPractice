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
            SqlConnection SQL = new SqlConnection("SQL Connection");
            OracleConnection oracle = new OracleConnection("Oracle Connection");

            DbCommand SQLCommand = new DbCommand(SQL, "Drop Tables");
            DbCommand oracleCommand = new DbCommand(oracle, "Blow up");

            SQLCommand.Execute();
            oracleCommand.Execute();
        }
    }
}
