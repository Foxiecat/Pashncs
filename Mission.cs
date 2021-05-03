using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace Pashncs
{
    class Mission
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Text { get; }
        public string StartDate { get; }

        public Mission(string name, string text, string startDate)
        {
            Name = name;
            Text = text;
            StartDate = startDate;
        }
    }
}
