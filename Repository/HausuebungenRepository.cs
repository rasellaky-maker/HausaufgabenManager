using HausaufgabenManagerUI_WinForm.Moduls;
using MySqlConnector;

namespace HausaufgabenManagerUI_WinForm.Repository
{
    internal class HausuebungenRepository
    {
        private string ConnectionString = string.Empty;
        internal HausuebungenRepository(string connectionString) 
        { 
            ConnectionString = connectionString;
        }

        internal async Task<List<Hausuebung>> GetAll()
        {
            List<Hausuebung> result = new List<Hausuebung>();

            const string sql = @"
                SELECT fach, inhalt, faelligkeitsdatum 
                FROM hausuebungen
                WHERE faelligkeitsdatum > CURDATE()
                ORDER BY faelligkeitsdatum ASC;
            ";

            try
            {
                using var conn = new MySqlConnection(ConnectionString);
                await conn.OpenAsync();

                using var cmd = new MySqlCommand(sql, conn);
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    string fach = reader.GetString(0);
                    string inhalt = reader.GetString(1);
                    DateTime faellig = reader.GetDateTime(2);

                    result.Add(new Hausuebung(fach, faellig, inhalt)); 
                }
                return result;
            }
            catch (MySqlException ex)
            {
                throw;
            }
        }
        internal async Task<Hausuebung> Add(Hausuebung newHomework)
        {
            const string sql = @"
                INSERT INTO hausuebungen (fach, inhalt, faelligkeitsdatum) 
                VALUES (@fach, @inhalt, @faelligkeitsdatum);
            ";
            try
            {
                using var conn = new MySqlConnection(ConnectionString);
                await conn.OpenAsync();
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fach", newHomework.Fach);
                cmd.Parameters.AddWithValue("@inhalt", newHomework.Inhalt);
                cmd.Parameters.AddWithValue("@faelligkeitsdatum", newHomework.Faelligkeitsdatum);
                await cmd.ExecuteNonQueryAsync();

                return newHomework;
            }
            catch (MySqlException ex)
            {
                throw;
            }
        }
    }
}
