using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace Pashncs
{
    class Program
    {
        static void Main(string[] args)
        {
            var connStr = "server=localhost;user id=root;database=pashn; Pwd=Progynova";
            var conn = new MySqlConnection(connStr);

            var missionRepository = new MissionRepository(conn);

            string formatForMySql = "1945-02-17 21:40:01";
            var mission1 = new Mission("Mission5", "Dette er en text", formatForMySql);

            var insertedId = missionRepository.CreateOneMission(mission1);

            //var jallaMøk = missionRepository.DeleteAll();

            //Console.WriteLine(insertedId.Result);
        }
    }
}
