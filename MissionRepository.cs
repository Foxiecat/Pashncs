using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace Pashncs
{
    class MissionRepository
    {
        private readonly MySqlConnection _connection;

        public MissionRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<int> CreateOneMission(Mission mission) // Funker ikke
        {
            const string query = @"INSERT INTO missions(mission_name, mission_text)
                                    OUTPUT INSERTED.mission_id
                                    VALUES (@Name, @Text)";

            var id = await _connection.QuerySingleAsync<int>(query, mission);
            mission.Id = id;

            return id;
        }

        public async Task<int> DeleteAll()
        {
            var query = "DELETE FROM mission";
            return await _connection.ExecuteAsync(query);
        }

        //public async Task<int> CreateAll(Mission mission)
        //{
        //    const string query = @"INSERT INTO missions( FirstName, LastName, MiddleName)
        //                OUTPUT INSERTED.Id
        //                VALUES (@FirstName, @LastName, @MiddleName)";

        //    var id = await _connection.QuerySingleAsync<int>(query, mission);
        //    mission.Id = id;
        //    return id;
        //}
    }
}
